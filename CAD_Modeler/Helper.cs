using devDept.Eyeshot.Entities;
using devDept.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD_Modeler
{
    public static class Helper
    {
        public static void Copy(this Point3D pt, Point3D pt2)
        {
            pt.X = pt2.X;
            pt.Y = pt2.Y;
            pt.Z = pt2.Z;
        }

        public static void Copy(this Point2D pt, Point2D pt2)
        {
            pt.X = pt2.X;
            pt.Y = pt2.Y;
        }

        public static void Copy(this Point pt, Point pt2)
        {
            pt.Position = pt2.Position;
            if (pt2.EntityData == null)
                return;
            pt.EntityData = pt2.EntityData;
        }

        static public void ConvertToPoint3D(this Point3D pt, Plane _plane, Point2D pt2)
        {
            if (pt == null)
                pt = new Joint(_plane, pt2, 1, 1).Position;
            else
                pt.Copy(new Joint(_plane, pt2, 1, 1).Position);
        }

        static public void ConvertToPoint3DArray(this Point3D[] ptArray, Plane _plane, Point2D[] ptArray2)
        {
            if (ptArray == null)
                ptArray = new Point3D[ptArray2.Length];

            for (int i = 0; i < ptArray2.Length; i++)
            {
                if (ptArray[i] == null)
                    ptArray[i] = new Point3D();
                ptArray[i].ConvertToPoint3D(_plane, ptArray2[i]);
            }
        }
        static public void ConvertToPoint(this Point pt, Plane _plane, Point2D pt2)
        {
            if (pt == null)
                pt = new Point(_plane, pt2);
            else
                pt.Copy(new Point(_plane, pt2));
        }

        static public void ConvertToPointArray(this Point[] ptArray, Plane _plane, Point2D[] ptArray2)
        {
            if(ptArray == null)
                ptArray = new Point[ptArray2.Length];

            for (int i = 0; i < ptArray2.Length; i++)
            {
                if (ptArray[i] == null)
                    ptArray[i] = new Point(_plane, ptArray2[i]);
                ptArray[i].ConvertToPoint(_plane, ptArray2[i]);
            }
        }
        static public void ConvertToPoint(this Point pt, Point3D pt2)
        {
            if (pt == null)
                pt = new Point(pt2, 10);
            else
                pt.Copy(new Point(pt2, 10));
        }

        static public void ConvertToPointArray(this Point[] ptArray, Point3D[] ptArray2)
        {
            if (ptArray == null)
                ptArray = new Point[ptArray2.Length];

            for (int i = 0; i < ptArray2.Length; i++)
            {
                if (ptArray[i] == null)
                    ptArray[i] = new Point(ptArray2[i], 10);
                ptArray[i].ConvertToPoint(ptArray2[i]);
            }
        }

    }
}
