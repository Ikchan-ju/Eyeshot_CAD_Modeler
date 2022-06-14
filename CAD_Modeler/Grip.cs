using devDept.Eyeshot.Entities;
using devDept.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD_Modeler
{
    public class Grip
    {

        public Grip(Point3D firstPos, Point gripPoint, GripType gripType, Entity targetEnt)
        {
            this.firstPos = firstPos;
            this.gripPoint = gripPoint;
            this.gripType = gripType;
            this.targetEntity = targetEnt;
        }

        public enum GripType
        {
            Line_StartPoint,
            Line_MidPoint,
            Line_EndPoint,
            Circle_CenterPoint,
            Circle_RadiusPoint, // todo : 계속 추가될 예정
        }

        public GripType gripType { get; set; }
        public Point3D firstPos { get; set; }
        public Point gripPoint { get; set; }
        public Entity targetEntity { get; set; }


    }
}
