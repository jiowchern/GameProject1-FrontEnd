
            using System;  
            using System.Collections.Generic;
            
            namespace Regulus.Project.ItIsNotAGame.Data{ 
                public class Protocol : Regulus.Remoting.IProtocol
                {
                    Regulus.Remoting.GPIProvider _GPIProvider;
                    Regulus.Remoting.EventProvider _EventProvider;
                    Regulus.Serialization.ISerializer _Serializer;
                    public Protocol()
                    {
                        var types = new Dictionary<Type, Type>();
                        types.Add(typeof(Regulus.Project.ItIsNotAGame1.Data.IAccountCreator) , typeof(Regulus.Project.ItIsNotAGame1.Data.Ghost.CIAccountCreator) );
types.Add(typeof(Regulus.Project.ItIsNotAGame1.Data.IAccountFinder) , typeof(Regulus.Project.ItIsNotAGame1.Data.Ghost.CIAccountFinder) );
types.Add(typeof(Regulus.Project.ItIsNotAGame1.Data.IAccountManager) , typeof(Regulus.Project.ItIsNotAGame1.Data.Ghost.CIAccountManager) );
types.Add(typeof(Regulus.Project.ItIsNotAGame1.Data.IAccountStatus) , typeof(Regulus.Project.ItIsNotAGame1.Data.Ghost.CIAccountStatus) );
types.Add(typeof(Regulus.Project.ItIsNotAGame1.Data.IBattleSkill) , typeof(Regulus.Project.ItIsNotAGame1.Data.Ghost.CIBattleSkill) );
types.Add(typeof(Regulus.Project.ItIsNotAGame1.Data.ICastSkill) , typeof(Regulus.Project.ItIsNotAGame1.Data.Ghost.CICastSkill) );
types.Add(typeof(Regulus.Project.ItIsNotAGame1.Data.IDevelopActor) , typeof(Regulus.Project.ItIsNotAGame1.Data.Ghost.CIDevelopActor) );
types.Add(typeof(Regulus.Project.ItIsNotAGame1.Data.IEmotion) , typeof(Regulus.Project.ItIsNotAGame1.Data.Ghost.CIEmotion) );
types.Add(typeof(Regulus.Project.ItIsNotAGame1.Data.IEquipmentNotifier) , typeof(Regulus.Project.ItIsNotAGame1.Data.Ghost.CIEquipmentNotifier) );
types.Add(typeof(Regulus.Project.ItIsNotAGame1.Data.IInventoryController) , typeof(Regulus.Project.ItIsNotAGame1.Data.Ghost.CIInventoryController) );
types.Add(typeof(Regulus.Project.ItIsNotAGame1.Data.IInventoryNotifier) , typeof(Regulus.Project.ItIsNotAGame1.Data.Ghost.CIInventoryNotifier) );
types.Add(typeof(Regulus.Project.ItIsNotAGame1.Data.IJumpMap) , typeof(Regulus.Project.ItIsNotAGame1.Data.Ghost.CIJumpMap) );
types.Add(typeof(Regulus.Project.ItIsNotAGame1.Data.IMakeSkill) , typeof(Regulus.Project.ItIsNotAGame1.Data.Ghost.CIMakeSkill) );
types.Add(typeof(Regulus.Project.ItIsNotAGame1.Data.IMoveController) , typeof(Regulus.Project.ItIsNotAGame1.Data.Ghost.CIMoveController) );
types.Add(typeof(Regulus.Project.ItIsNotAGame1.Data.IBagNotifier) , typeof(Regulus.Project.ItIsNotAGame1.Data.Ghost.CIBagNotifier) );
types.Add(typeof(Regulus.Project.ItIsNotAGame1.Data.IPlayerProperys) , typeof(Regulus.Project.ItIsNotAGame1.Data.Ghost.CIPlayerProperys) );
types.Add(typeof(Regulus.Project.ItIsNotAGame1.Data.IGameRecorder) , typeof(Regulus.Project.ItIsNotAGame1.Data.Ghost.CIGameRecorder) );
types.Add(typeof(Regulus.Project.ItIsNotAGame1.Data.IQuitable) , typeof(Regulus.Project.ItIsNotAGame1.Data.Ghost.CIQuitable) );
types.Add(typeof(Regulus.Project.ItIsNotAGame1.Data.INormalSkill) , typeof(Regulus.Project.ItIsNotAGame1.Data.Ghost.CINormalSkill) );
types.Add(typeof(Regulus.Project.ItIsNotAGame1.Data.IStorage) , typeof(Regulus.Project.ItIsNotAGame1.Data.Ghost.CIStorage) );
types.Add(typeof(Regulus.Project.ItIsNotAGame1.Data.IStorageCompetences) , typeof(Regulus.Project.ItIsNotAGame1.Data.Ghost.CIStorageCompetences) );
types.Add(typeof(Regulus.Project.ItIsNotAGame1.Data.IVerify) , typeof(Regulus.Project.ItIsNotAGame1.Data.Ghost.CIVerify) );
types.Add(typeof(Regulus.Project.ItIsNotAGame1.Data.IVersion) , typeof(Regulus.Project.ItIsNotAGame1.Data.Ghost.CIVersion) );
types.Add(typeof(Regulus.Project.ItIsNotAGame1.Data.IVisible) , typeof(Regulus.Project.ItIsNotAGame1.Data.Ghost.CIVisible) );
                        _GPIProvider = new Regulus.Remoting.GPIProvider(types);

                        var eventClosures = new List<Regulus.Remoting.IEventProxyCreator>();
                        eventClosures.Add(new Regulus.Project.ItIsNotAGame1.Data.Event.IAccountStatus.KickEvent() );
eventClosures.Add(new Regulus.Project.ItIsNotAGame1.Data.Event.ICastSkill.HitNextsEvent() );
eventClosures.Add(new Regulus.Project.ItIsNotAGame1.Data.Event.IInventoryController.BagItemsEvent() );
eventClosures.Add(new Regulus.Project.ItIsNotAGame1.Data.Event.IInventoryController.EquipItemsEvent() );
eventClosures.Add(new Regulus.Project.ItIsNotAGame1.Data.Event.IInventoryNotifier.AddEvent() );
eventClosures.Add(new Regulus.Project.ItIsNotAGame1.Data.Event.IInventoryNotifier.RemoveEvent() );
eventClosures.Add(new Regulus.Project.ItIsNotAGame1.Data.Event.IMakeSkill.FormulasEvent() );
eventClosures.Add(new Regulus.Project.ItIsNotAGame1.Data.Event.IVisible.EquipEvent() );
eventClosures.Add(new Regulus.Project.ItIsNotAGame1.Data.Event.IVisible.StatusEvent() );
eventClosures.Add(new Regulus.Project.ItIsNotAGame1.Data.Event.IVisible.EnergyEvent() );
eventClosures.Add(new Regulus.Project.ItIsNotAGame1.Data.Event.IVisible.TalkMessageEvent() );
                        _EventProvider = new Regulus.Remoting.EventProvider(eventClosures);

                        _Serializer = new Regulus.Serialization.Serializer(new Regulus.Serialization.DescriberBuilder(typeof(AForge.Math.Geometry.GrahamConvexHull),typeof(Regulus.CustomType.Point),typeof(Regulus.CustomType.Polygon),typeof(Regulus.CustomType.Vector2),typeof(Regulus.CustomType.Vector2[]),typeof(Regulus.Project.ItIsNotAGame1.Data.Account),typeof(Regulus.Project.ItIsNotAGame1.Data.Account[]),typeof(Regulus.Project.ItIsNotAGame1.Data.ACCOUNT_REQUEST_RESULT),typeof(Regulus.Project.ItIsNotAGame1.Data.Account.COMPETENCE),typeof(Regulus.Project.ItIsNotAGame1.Data.Account.COMPETENCE[]),typeof(Regulus.Project.ItIsNotAGame1.Data.ACTOR_STATUS_TYPE),typeof(Regulus.Project.ItIsNotAGame1.Data.ACTOR_STATUS_TYPE[]),typeof(Regulus.Project.ItIsNotAGame1.Data.ChestLayout),typeof(Regulus.Project.ItIsNotAGame1.Data.ChestLayout[]),typeof(Regulus.Project.ItIsNotAGame1.Data.Determination),typeof(Regulus.Project.ItIsNotAGame1.Data.Effect),typeof(Regulus.Project.ItIsNotAGame1.Data.Effect[]),typeof(Regulus.Project.ItIsNotAGame1.Data.EFFECT_TYPE),typeof(Regulus.Project.ItIsNotAGame1.Data.Energy),typeof(Regulus.Project.ItIsNotAGame1.Data.Energy.TYPE),typeof(Regulus.Project.ItIsNotAGame1.Data.EnteranceLayout),typeof(Regulus.Project.ItIsNotAGame1.Data.EnteranceLayout[]),typeof(Regulus.Project.ItIsNotAGame1.Data.ENTITY),typeof(Regulus.Project.ItIsNotAGame1.Data.ENTITY[]),typeof(Regulus.Project.ItIsNotAGame1.Data.EntityData),typeof(Regulus.Project.ItIsNotAGame1.Data.EntityData[]),typeof(Regulus.Project.ItIsNotAGame1.Data.EntityGroupLayout),typeof(Regulus.Project.ItIsNotAGame1.Data.EntityGroupLayout[]),typeof(Regulus.Project.ItIsNotAGame1.Data.EntityLayout),typeof(Regulus.Project.ItIsNotAGame1.Data.EntityLayout[]),typeof(Regulus.Project.ItIsNotAGame1.Data.EQUIP_PART),typeof(Regulus.Project.ItIsNotAGame1.Data.EquipStatus),typeof(Regulus.Project.ItIsNotAGame1.Data.EquipStatus[]),typeof(Regulus.Project.ItIsNotAGame1.Data.FieldLayout),typeof(Regulus.Project.ItIsNotAGame1.Data.FieldLayout[]),typeof(Regulus.Project.ItIsNotAGame1.Data.GamePlayerRecord),typeof(Regulus.Project.ItIsNotAGame1.Data.Item),typeof(Regulus.Project.ItIsNotAGame1.Data.Item[]),typeof(Regulus.Project.ItIsNotAGame1.Data.ITEM_FEATURES),typeof(Regulus.Project.ItIsNotAGame1.Data.ItemEffect),typeof(Regulus.Project.ItIsNotAGame1.Data.ItemEffect[]),typeof(Regulus.Project.ItIsNotAGame1.Data.ItemFormula),typeof(Regulus.Project.ItIsNotAGame1.Data.ItemFormula[]),typeof(Regulus.Project.ItIsNotAGame1.Data.ItemFormulaLite),typeof(Regulus.Project.ItIsNotAGame1.Data.ItemFormulaLite[]),typeof(Regulus.Project.ItIsNotAGame1.Data.ItemFormulaNeed),typeof(Regulus.Project.ItIsNotAGame1.Data.ItemFormulaNeed[]),typeof(Regulus.Project.ItIsNotAGame1.Data.ItemFormulaNeedLite),typeof(Regulus.Project.ItIsNotAGame1.Data.ItemFormulaNeedLite[]),typeof(Regulus.Project.ItIsNotAGame1.Data.ItemPrototype),typeof(Regulus.Project.ItIsNotAGame1.Data.ItemPrototype[]),typeof(Regulus.Project.ItIsNotAGame1.Data.Location),typeof(Regulus.Project.ItIsNotAGame1.Data.MazeInfomation),typeof(Regulus.Project.ItIsNotAGame1.Data.MazeUnitInfomation),typeof(Regulus.Project.ItIsNotAGame1.Data.MazeUnitInfomation[]),typeof(Regulus.Project.ItIsNotAGame1.Data.PortalData),typeof(Regulus.Project.ItIsNotAGame1.Data.ProtalLayout),typeof(Regulus.Project.ItIsNotAGame1.Data.ProtalLayout[]),typeof(Regulus.Project.ItIsNotAGame1.Data.RealmInfomation),typeof(Regulus.Project.ItIsNotAGame1.Data.Resource),typeof(Regulus.Project.ItIsNotAGame1.Data.ResourceItem),typeof(Regulus.Project.ItIsNotAGame1.Data.ResourceItem[]),typeof(Regulus.Project.ItIsNotAGame1.Data.ResourceLayout),typeof(Regulus.Project.ItIsNotAGame1.Data.ResourceLayout[]),typeof(Regulus.Project.ItIsNotAGame1.Data.SkillData),typeof(Regulus.Project.ItIsNotAGame1.Data.SkillData[]),typeof(Regulus.Project.ItIsNotAGame1.Data.StaticLayout),typeof(Regulus.Project.ItIsNotAGame1.Data.StaticLayout[]),typeof(Regulus.Project.ItIsNotAGame1.Data.StrongholdLayout),typeof(Regulus.Project.ItIsNotAGame1.Data.StrongholdLayout[]),typeof(Regulus.Project.ItIsNotAGame1.Data.TownInfomation),typeof(Regulus.Project.ItIsNotAGame1.Data.Translate),typeof(Regulus.Project.ItIsNotAGame1.Data.Translate[]),typeof(Regulus.Project.ItIsNotAGame1.Data.VisibleStatus),typeof(Regulus.Project.ItIsNotAGame1.Data.WallData),typeof(Regulus.Project.ItIsNotAGame1.Data.WallLayout),typeof(Regulus.Project.ItIsNotAGame1.Data.WallLayout[]),typeof(Regulus.Project.ItIsNotAGame1.Game.Data.LEVEL_UNIT),typeof(Regulus.Remoting.ClientToServerOpCode),typeof(Regulus.Remoting.PackageCallMethod),typeof(Regulus.Remoting.PackageErrorMethod),typeof(Regulus.Remoting.PackageInvokeEvent),typeof(Regulus.Remoting.PackageLoadSoul),typeof(Regulus.Remoting.PackageLoadSoulCompile),typeof(Regulus.Remoting.PackageProtocolSubmit),typeof(Regulus.Remoting.PackageRelease),typeof(Regulus.Remoting.PackageReturnValue),typeof(Regulus.Remoting.PackageUnloadSoul),typeof(Regulus.Remoting.PackageUpdateProperty),typeof(Regulus.Remoting.RequestPackage),typeof(Regulus.Remoting.ResponsePackage),typeof(Regulus.Remoting.ServerToClientOpCode),typeof(System.Boolean),typeof(System.Byte[]),typeof(System.Byte[][]),typeof(System.Char),typeof(System.Char[]),typeof(System.Double),typeof(System.Guid),typeof(System.Int32),typeof(System.Int32[]),typeof(System.Single),typeof(System.String)));
                    }

                    byte[] Regulus.Remoting.IProtocol.VerificationCode { get { return new byte[]{74,200,111,90,178,187,148,77,12,21,234,64,185,54,37,222};} }
                    Regulus.Remoting.GPIProvider Regulus.Remoting.IProtocol.GetGPIProvider()
                    {
                        return _GPIProvider;
                    }

                    Regulus.Remoting.EventProvider Regulus.Remoting.IProtocol.GetEventProvider()
                    {
                        return _EventProvider;
                    }

                    Regulus.Serialization.ISerializer Regulus.Remoting.IProtocol.GetSerialize()
                    {
                        return _Serializer;
                    }
                    
                }
            }
            