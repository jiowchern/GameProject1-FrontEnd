﻿using System;
using System.Collections.Generic;


using System.Linq;


using Regulus.Collection;

using Regulus.Project.ItIsNotAGame1.Data;
using Regulus.Remoting;
using Regulus.Utility;


namespace Regulus.Project.ItIsNotAGame1.Game.Play
{
    internal class GameStage : IStage, IQuitable,        
        IEmotion        
    {
        private readonly ISoulBinder _Binder;

        private readonly Map _Map;


        private readonly TimeCounter _DeltaTimeCounter;
        private readonly TimeCounter _UpdateTimeCounter;
        private const float _UpdateTime = 1.0f / 30.0f;

        private float _UpdateAllItemTime;

        private readonly Entity _Player;

        private readonly Mover _Mover;

        private readonly DifferenceNoticer<IIndividual> _DifferenceNoticer;



        private bool _RequestAllItems;
        

        private readonly Regulus.Utility.Updater _Updater;

        private readonly Regulus.Utility.StageMachine _Machine;

        private readonly Wisdom _Wisdom;

        public event Action DoneEvent;

        public GameStage(ISoulBinder binder, Map map, Entity entity)
        {
            _Map = map;
            _Binder = binder;
            _DeltaTimeCounter = new TimeCounter();
            _UpdateTimeCounter = new TimeCounter();
            _Updater = new Updater();
            _Machine = new StageMachine();
            _DifferenceNoticer = new DifferenceNoticer<IIndividual>();

            _Player = entity;
            _Mover = new Mover(this._Player);            
        }
        public GameStage(ISoulBinder binder, Map map, Entity entity, Wisdom wisdom) : this(binder, map, entity)
        {
            _Wisdom = wisdom;
        }
        void IStage.Leave()
        {
            _Machine.Termination();
            _Updater.Shutdown();
            
            _DifferenceNoticer.Set(new IIndividual[0]) ;
            _DifferenceNoticer.JoinEvent -= this._BroadcastJoin;
            _DifferenceNoticer.LeftEvent -= this._BroadcastLeft;            

            _Binder.Unbind<IEmotion>(this);
            _Binder.Unbind<IDevelopActor>(_Player);            
            _Binder.Unbind<IPlayerProperys>(_Player);            
            _Map.Left(_Player);
        }

        void IStage.Enter()
        {
            this._DifferenceNoticer.JoinEvent += this._BroadcastJoin;
            this._DifferenceNoticer.LeftEvent += this._BroadcastLeft;

            this._Map.JoinChallenger(this._Player);
            this._Binder.Bind<IPlayerProperys>(_Player);                        
            _Binder.Bind<IDevelopActor>(_Player);
            _Binder.Bind<IEmotion>(this);
            _ToSurvival();

            if (_Wisdom != null)
                _Updater.Add(_Wisdom);
        }

        

        void IStage.Update()
        {
            if (_UpdateTimeCounter.Second < _UpdateTime)
                return;
            var deltaTime = this._GetDeltaTime();
            _Machine.Update();
            _Updater.Working();

            var lastDeltaTime = deltaTime;
            _Move(lastDeltaTime);
            _Broadcast(_Map.Find(_Player.GetView()));
            _Player.Equipment.UpdateEffect(lastDeltaTime);

        }

        private void _Move(float deltaTime)
        {
            
            _Player.TrunDirection(deltaTime);
            var velocity = this._Player.GetVelocity(deltaTime);
            var orbit = this._Mover.GetOrbit(velocity);
            var entitys = this._Map.Find(orbit);
            var hitthetargets = _Mover.Move(velocity, entitys.Where(x => x.Id != this._Player.Id));
            
            if (hitthetargets.Any())
            {
                _Player.SetCollisionTargets(hitthetargets);
                this._Player.ClearOffset();
            }
        }

        private void _Broadcast(IEnumerable<IIndividual> controllers)
        {
            this._DifferenceNoticer.Set(controllers);
        }

        private void _BroadcastLeft(IEnumerable<IIndividual> controllers)
        {
            foreach (var controller in controllers)
            {
                this._Binder.Unbind<IVisible>(controller);
            }
        }

        private void _BroadcastJoin(IEnumerable<IIndividual> controllers)
        {
            foreach (var controller in controllers)
            {
                this._Binder.Bind<IVisible>(controller);
            }
        }

        private float _GetDeltaTime()
        {
            var second = this._DeltaTimeCounter.Second;
            this._DeltaTimeCounter.Reset();
            return second;
        }

        public void Quit()
        {
            this.DoneEvent.Invoke();
        }
        
        
        private void _ToSurvival()
        {
            var status = new ControlStatus(_Binder, _Player, _Mover, _Map);
            status.StunEvent += _ToStun;
            _Machine.Push(status);
        }

        private void _ToStun()
        {
            var status = new StunStatus(_Binder, _Player);
            status.ExitEvent += DoneEvent;
            status.WakeEvent += _ToSurvival;

            _Machine.Push(status);
        }

        void IEmotion.Talk(string message)
        {
            _Player.Talk(message);
        }
    }
}