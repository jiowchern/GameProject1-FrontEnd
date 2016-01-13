using System;
using System.Linq;

using Regulus.Framework;
using Regulus.Remoting;
using Regulus.Utility;
using FluentBehaviourTree;

using Regulus.Project.ItIsNotAGame1.Data;

namespace Regulus.Project.ItIsNotAGame1.Game.Play
{

    public class Wisdom : IUpdatable
    {
        private readonly Entity _Entity;

        private readonly GpiTransponder _Transponder;

        private Regulus.Utility.TimeCounter _TimeCounter;
        IBehaviourTreeNode _Tree;

        private IVisible _Visible;

        private IMoveController _MoveController;

        private IBattleSkill _BattleSkill;

        public Wisdom(Entity entity)
        {
            _Entity = entity;
            _Visible = entity;
            _TimeCounter = new TimeCounter();
            _Transponder = new GpiTransponder();
            var builder = new BehaviourTreeBuilder();

            _Tree = builder.Selector("root")
                        .Sequence("turn")
                            .Condition("have collision", (td) => _CheckCollison())
                            .Do("Turn to Back", _TurnToBack)
                            .Do("Move", _Move)
                        .End()
                        .Sequence("Battle To Normal")
                            .Condition("have collision", (td) => _IsInBattle() )                            
                            .Do("to normal" , _Disarm )
                        .End()
                    .End().Build();
        }

        private BehaviourTreeStatus _Disarm(TimeData arg1)
        {
            _BattleSkill.Disarm();

            return BehaviourTreeStatus.Success;
        }

        private bool _IsInBattle()
        {
            return _BattleSkill != null;
        }

        bool _CheckCollison()
        {
            var res = _Entity.GetCollisionTargets().Any();
            return res;
        }
        private BehaviourTreeStatus _Move(TimeData arg)
        {
            if (_MoveController != null)
                _MoveController.Forward();
            return BehaviourTreeStatus.Success;
        }

        private BehaviourTreeStatus _TurnToBack(TimeData arg)
        {
            _Entity.SetDirection(Regulus.Utility.Random.Instance.NextFloat(90, 270));
            return BehaviourTreeStatus.Success;
        }

        public ISoulBinder GetSoulBinder()
        {
            return _Transponder;
        }
        void IBootable.Shutdown()
        {
            _Transponder.Query<IMoveController>().Unsupply -= _ClearMoveController;
            _Transponder.Query<IMoveController>().Supply -= _GetMoveController;

            _Transponder.Query<IBattleSkill>().Supply -= _GetBattle;
            _Transponder.Query<IBattleSkill>().Unsupply -= _ClearBattle;
        }
        

        void IBootable.Launch()
        {
            _Transponder.Query<IMoveController>().Unsupply += _ClearMoveController;
            _Transponder.Query<IMoveController>().Supply += _GetMoveController;
            _Transponder.Query<IBattleSkill>().Supply += _GetBattle;
            _Transponder.Query<IBattleSkill>().Unsupply += _ClearBattle;
            _TimeCounter.Reset();


        }

        private void _ClearBattle(IBattleSkill obj)
        {
            _BattleSkill = null;
        }

        private void _GetBattle(IBattleSkill obj)
        {
            _BattleSkill = obj;
        }

        private void _ClearMoveController(IMoveController obj)
        {
            _MoveController = null;
        }

        private void _GetMoveController(IMoveController obj)
        {
            _MoveController = obj;
        }

        bool IUpdatable.Update()
        {

            _Tree.Tick(new TimeData(_TimeCounter.Second));
            _TimeCounter.Reset();
            return true;
        }
    }
}