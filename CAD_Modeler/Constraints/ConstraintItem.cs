using devDept.Eyeshot.Entities;
using devDept.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD_Modeler
{
    public class ConstraintItem
    {
        public enum Type
        {
            Coincidence,
            MatchPoint_LineStartPoint,
            MatchPoint_LineEndPoint,
            Parallel_Line_Line,
            Perpendicular_Line_Line,
            Vertical_Line,
            Horizontal_Line,
        }

        public Type type { get; set; }

        public Entity targetEntity { get; set; }    // 기준에 따라 변형되는 객체

        public Entity sourceEntity { get; set; }    // 제약 조건의 기준이 되는 객체

        public Plane sourcePlane { get; set; }    // 제약 조건의 기준이 되는 평면

        virtual internal void Run()
        {
            if (targetEntity == null || (sourceEntity == null && sourcePlane == null))
                return;
            switch (type)
            {
                // 각 Entity의 position을 일치시킴.
                case Type.Coincidence:
                    {

                    }
                    break;

                // 점과 시작점을 일치시킴.
                case Type.MatchPoint_LineStartPoint:
                    {
                        Point targetPoint = targetEntity as Point;
                        Line sourceLine = sourceEntity as Line;
                        if (targetPoint == null || sourceLine == null)
                            return;
                        targetPoint.Position.Copy(sourceLine.StartPoint);
                    }
                    break;

                // 1개의 선의 시작점을 일치시킴.
                case Type.MatchPoint_LineEndPoint:
                    {
                        Point targetPoint = targetEntity as Point;
                        Line sourceLine = sourceEntity as Line;
                        if (targetPoint == null || sourceLine == null)
                            return;
                        targetPoint.Position.Copy(sourceLine.EndPoint);
                    }
                    break;

                // 두개의 선이 평행하게 함
                case Type.Parallel_Line_Line:
                    {
                        Line targetLine = targetEntity as Line;
                        Line sourceLine = sourceEntity as Line;
                        if (targetLine == null || sourceLine == null)
                            return;
                        var dir = sourceLine.Direction;
                        dir.Normalize();
                        if(targetLine.Direction * dir < 0)
                            targetLine.EndPoint = targetLine.StartPoint + dir * targetLine.Length();
                        else
                            targetLine.EndPoint = targetLine.StartPoint + dir * targetLine.Length();
                    }
                    break;

                // 두개의 선이 직교하게 함
                case Type.Perpendicular_Line_Line:
                    {
                        Line targetLine = targetEntity as Line;
                        Line sourceLine = sourceEntity as Line;
                        if (targetLine == null || sourceLine == null)
                            return;
                        Vector3D dir = new Vector3D();
                        dir.PerpendicularTo(sourceLine.Direction);
                        dir.Normalize();
                        if (targetLine.StartPoint.DistanceTo(sourceLine.StartPoint) < targetLine.EndPoint.DistanceTo(sourceLine.StartPoint))
                        {
                            targetLine.EndPoint = targetLine.StartPoint + dir * targetLine.Length();
                        }
                        else
                        {
                            targetLine.StartPoint = targetLine.EndPoint + dir * targetLine.Length();
                        }
                    }
                    break;

                // 지정된 선이 평면내 좌표계에서 수직하게 함
                case Type.Vertical_Line:
                    {
                        Line targetLine = targetEntity as Line;
                        if (targetLine == null || sourcePlane == null)
                            return;
                        var dir = sourcePlane.AxisY;
                        dir.Normalize();
                        targetLine.EndPoint = targetLine.StartPoint + dir * targetLine.Length();
                    }
                    break;

                // 지정된 선이 평면내 좌표계에서 수평하게 함
                case Type.Horizontal_Line:
                    {
                        Line targetLine = targetEntity as Line;
                        if (targetLine == null || sourcePlane == null)
                            return;
                        var dir = sourcePlane.AxisX;
                        dir.Normalize();
                        if (targetLine.Direction * dir > 0)
                            targetLine.EndPoint = targetLine.StartPoint + dir * targetLine.Length();
                        else
                            targetLine.StartPoint = targetLine.EndPoint + dir * targetLine.Length();
                    }
                    break;
            }
            targetEntity.Regen(0.1);
            if (sourceEntity != null)
                sourceEntity.Regen(0.1);
        }
    }
}
