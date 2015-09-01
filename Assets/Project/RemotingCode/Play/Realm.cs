using System;
using System.Collections.Generic;

using Regulus.CustomType;
using Regulus.Extension;
using Regulus.Project.ItIsNotAGame1.Data;

namespace Regulus.Project.ItIsNotAGame1.Game.Play
{
    public class Realm
    {        
        private readonly Map _Map;

        private readonly int _Witdh;

        private readonly int _Height;


        class WallShift
        {
            private readonly Vector2 _Offset;

            private readonly Func<Rect, Vector2, Vector2> _ShiftHandler;

            public WallShift(Vector2 offset , Func<Rect , Vector2 , Vector2> shift_handler)
            {
                this._Offset = offset;
                this._ShiftHandler = shift_handler;                
            }

            public static Vector2 _East(Rect bound, Vector2 offset)
            {                
                return new Vector2(offset.X - bound.Width/ 2, offset.Y);
            }

            public static Vector2 _South(Rect bound, Vector2 offset)
            {
                return new Vector2(offset.X , offset.Y + bound.Height / 2);
            }

            public static Vector2 _Western(Rect bound, Vector2 offset)
            {
                return new Vector2(offset.X + bound.Width / 2, offset.Y);
            }

            public static Vector2 _North(Rect bound, Vector2 offset)
            {
                return new Vector2(offset.X , offset.Y - bound.Height / 2);
            }

            public Vector2 GetDatum(Rect bound)
            {
                return _ShiftHandler(bound , _Offset);
            }
        }

        private readonly Dictionary<MAZEWALL, WallShift> _DirectionPoints;
        private readonly Dictionary<MAZEWALL, EntityData> _EntitySource;

        private readonly Dictionary<MAZEWALL ,ENTITY> _WallToEntity;

        public Realm(Dictionary<MAZEWALL, EntityData> entity_source)
        {
            _WallToEntity = new Dictionary<MAZEWALL, ENTITY>();
            _WallToEntity.Add(MAZEWALL.EAST, ENTITY.WALL_EAST);
            _WallToEntity.Add(MAZEWALL.SOUTH, ENTITY.WALL_SOUTH);
            _WallToEntity.Add(MAZEWALL.WESTERN, ENTITY.WALL_WESTERN);
            _WallToEntity.Add(MAZEWALL.NORTH, ENTITY.WALL_NORTH);
            _EntitySource = new Dictionary<MAZEWALL, EntityData>(entity_source); 

            

            _Witdh = 50;
            _Height = 50;

            _DirectionPoints = new Dictionary<MAZEWALL, WallShift>();
            _DirectionPoints.Add(MAZEWALL.EAST, new WallShift(new Vector2(_Witdh , 0) , WallShift._East));
            _DirectionPoints.Add(MAZEWALL.SOUTH, new WallShift(new Vector2(0, -_Height), WallShift._South));
            _DirectionPoints.Add(MAZEWALL.WESTERN, new WallShift(new Vector2(-_Witdh, 0), WallShift._Western));
            _DirectionPoints.Add(MAZEWALL.NORTH, new WallShift(new Vector2(0, _Height), WallShift._North));

            _Map = _BuildMap();

        }

        private Map _BuildMap()
        {
            var map = new Map();
            IEnumerable<MazeCell> cells = _BuildMaze(_Witdh,_Height);
            foreach(var cell in cells)
            {
                foreach(var wall in cell.Walls)
                {
                    IIndividual entity = _BuildWall(wall , cell.X , cell.Y  );
                    map.JoinStaff(entity);                    
                }
            }
            return map;
        }

        private IIndividual _BuildWall(MAZEWALL wall, int x, int y)
        {
            Entity entity = _GetEntity(wall);
            IIndividual individual = entity;
            var bound = individual.Mesh.Points.ToRect();
            Vector2 offset = _GetOffset(wall , x ,y , bound);
            individual.SetPosition(offset.X , offset.Y);
            return entity;
        }

        private Vector2 _GetOffset(MAZEWALL wall, int x, int y, Rect bound)
        {
            Vector2 directPoint = _DirectionPoints[wall].GetDatum(bound);
            return new Vector2(directPoint.X + x , directPoint.Y + y);
        }

        private Entity _GetEntity(MAZEWALL wall)
        {
            var source = _EntitySource[wall];
            var record = new GamePlayerRecord();
            record.Entity = _WallToEntity[wall];
            return EntityProvider.Create(record);
        }

        private IEnumerable<MazeCell> _BuildMaze(int width, int height)
        {
            var maze = new Maze();
            maze.Generate();
            int index = 0;
            Regulus.CustomType.Flag<MAZEWALL> walls = new Flag<MAZEWALL>();
            foreach(var cell in maze.Cells)
            {
                int x = index % width;
                int y = index / width;
                if(cell.Walls[0] == 1)
                {
                    walls[MAZEWALL.NORTH] = true;
                }
                if (cell.Walls[1] == 1)
                {
                    walls[MAZEWALL.WESTERN] = true;
                }
                if (cell.Walls[2] == 1)
                {
                    walls[MAZEWALL.SOUTH] = true;
                }
                if (cell.Walls[3] == 1)
                {
                    walls[MAZEWALL.EAST] = true;
                }
                yield return new MazeCell()
                {
                    X = x,
                    Y = y,
                    Walls = walls
                };

                index++;
            }
        }

        public Map Query()
        {
            return _Map;
        }
    }
}