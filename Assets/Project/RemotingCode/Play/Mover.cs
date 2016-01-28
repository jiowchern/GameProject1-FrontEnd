using System;
using System.Collections.Generic;
using System.Linq;
using Regulus.Extension;
using Regulus.CustomType;

namespace Regulus.Project.ItIsNotAGame1.Game.Play
{
    public class Mover
    {

        private Entity _Entity;

        private IIndividual _Individual { get { return this._Entity; } }

        public Mover(Entity entity)
        {
            this._Entity = entity;
        }
        public Rect GetOrbit(Vector2 velocity)
        {
            return new Orbit(this._Individual.Mesh, velocity).Vision;
        }

        public class Orbit
        {
            private readonly Rect _Rect;

            public Orbit(Polygon body, Vector2 velocity)
            {
                List<Vector2> points = new List<Vector2>();
                points.AddRange(body.Points);

                var polygon = body.Clone();
                polygon.Offset(velocity);

                points.AddRange(polygon.Points);
                _Rect = points.ToRect();
            }

            public Rect Vision { get { return this._Rect; } }
        }

        public void Set(Vector2 velocity)
        {
            this._Entity.UpdatePosition(velocity);
        }

        public IEnumerable<IIndividual> Move(Vector2 velocity, IEnumerable<IIndividual> entitys)
        {
            var polygon = this._GetThroughRange(velocity);

            //var polygon = _Individual.Mesh;

            var targets = from x in entitys
                          let result = this._Collide(x, polygon, new Vector2())
                          where
                              x.EntityType != Data.ENTITY.ACTOR1
                              && x.EntityType != Data.ENTITY.ENTRANCE
                              && x.EntityType != Data.ENTITY.ACTOR2
                              && result.Intersect
                          //&& result.WillIntersect
                          select x;
            if (targets.Any() == false)
            {
                this.Set(velocity);
            }
            return targets;
        }

        public static Vector2[] FindHull(IEnumerable<Vector2> points)
        {
            List<PointToProcess> pointsToProcess = new List<PointToProcess>();
            List<PointToProcess> convexHullTemp = new List<PointToProcess>();
            try
            {
                

                // convert input points to points we can process
                foreach (Vector2 point in points)
                {
                    pointsToProcess.Add(new PointToProcess(point));
                }

                // find a point, with lowest X and lowest Y
                int firstCornerIndex = 0;
                PointToProcess firstCorner = pointsToProcess[0];

                for (int i = 1, n = pointsToProcess.Count; i < n; i++)
                {
                    if ((pointsToProcess[i].x < firstCorner.x) ||
                         ((pointsToProcess[i].x == firstCorner.x) && (pointsToProcess[i].y < firstCorner.y)))
                    {
                        firstCorner = pointsToProcess[i];
                        firstCornerIndex = i;
                    }
                }

                // remove the just found point
                pointsToProcess.RemoveAt(firstCornerIndex);

                // find K (tangent of line's angle) and distance to the first corner
                for (int i = 0, n = pointsToProcess.Count; i < n; i++)
                {
                    float dx = pointsToProcess[i].x - firstCorner.x;
                    float dy = pointsToProcess[i].y - firstCorner.y;

                    // don't need square root, since it is not important in our case
                    pointsToProcess[i].Distance = dx * dx + dy * dy;
                    // tangent of lines angle
                    pointsToProcess[i].K = (dx == 0) ? float.PositiveInfinity : (float)dy / dx;
                }

                // sort points by angle and distance
                pointsToProcess.Sort();

                

                // add first corner, which is always on the hull
                convexHullTemp.Add(firstCorner);
                // add another point, which forms a line with lowest slope
                convexHullTemp.Add(pointsToProcess[0]);
                pointsToProcess.RemoveAt(0);

                PointToProcess lastPoint = convexHullTemp[1];
                PointToProcess prevPoint = convexHullTemp[0];

                while (pointsToProcess.Count != 0)
                {
                    PointToProcess newPoint = pointsToProcess[0];

                    // skip any point, which has the same slope as the last one or
                    // has 0 distance to the first point
                    if ((newPoint.K == lastPoint.K) || (newPoint.Distance == 0))
                    {
                        pointsToProcess.RemoveAt(0);
                        continue;
                    }

                    // check if current point is on the left side from two last points
                    if ((newPoint.x - prevPoint.x) * (lastPoint.y - newPoint.y) - (lastPoint.x - newPoint.x) * (newPoint.y - prevPoint.y) < 0)
                    {
                        // add the point to the hull
                        convexHullTemp.Add(newPoint);
                        // and remove it from the list of points to process
                        pointsToProcess.RemoveAt(0);

                        prevPoint = lastPoint;
                        lastPoint = newPoint;
                    }
                    else
                    {
                        // remove the last point from the hull
                        convexHullTemp.RemoveAt(convexHullTemp.Count - 1);

                        lastPoint = prevPoint;
                        prevPoint = convexHullTemp[convexHullTemp.Count - 2];
                    }
                }

                // convert points back
                Vector2[] convexHull = new Vector2[convexHullTemp.Count];

                for (int i = 0; i < convexHullTemp.Count; i++)
                {
                    convexHull[i] = convexHullTemp[i].ToPoint();
                }


                return convexHull;

            }
            catch (System.ArgumentOutOfRangeException aooe)
            {
                var posints = string.Join(",", (from p in points select p.ShowMembers()).ToArray());
                var ptps = string.Join(",", (from p in pointsToProcess select p.ShowMembers()).ToArray());
                var cuts = string.Join(",", (from p in convexHullTemp select p.ShowMembers()).ToArray());
                
                var message = string.Format(
                    "_GetThroughRange 參數超出範圍異常中 {0}\n ptps = {1} points {2} curs {3}"
                    , aooe, ptps , posints , cuts);
                Regulus.Utility.Log.Instance.WriteDebug(message);
                throw aooe;
            }
            return new Vector2[0];
        }
        // Internal comparer for sorting points
        private class PointToProcess : IComparable
        {
            public float x;
            public float y;
            public float K;
            public float Distance;

            public PointToProcess(Vector2 point)
            {
                x = point.X;
                y = point.Y;

                K = 0;
                Distance = 0;
            }

            public int CompareTo(object obj)
            {
                PointToProcess another = (PointToProcess)obj;

                return (K < another.K) ? -1 : (K > another.K) ? 1 :
                    ((Distance > another.Distance) ? -1 : (Distance < another.Distance) ? 1 : 0);
            }

            public Vector2 ToPoint()
            {
                return new Vector2(x, y);
            }
        }
        private Polygon _GetThroughRange(Vector2 velocity)
        {
            var after = this._Individual.Mesh.Clone();
            after.Offset(velocity);

            Vector2[] points = new Vector2[8];
            points[0] = _Individual.Mesh.Points[0];
            points[1] = _Individual.Mesh.Points[1];
            points[2] = _Individual.Mesh.Points[2];
            points[3] = _Individual.Mesh.Points[3];

            points[4] = after.Points[0];
            points[5] = after.Points[1];
            points[6] = after.Points[2];
            points[7] = after.Points[3];

            

            var polygon = new Polygon(points);
            polygon.Convex();
            return polygon;

        }

        private Regulus.CustomType.Polygon.CollisionResult _Collide(IIndividual individual, Polygon polygon, Vector2 velocity)
        {
            var result = Polygon.Collision(polygon, individual.Mesh, velocity);
            return result;
        }
    }
}