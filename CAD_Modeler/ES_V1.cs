
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Color = System.Drawing.Color;
using Font = System.Drawing.Font;



// EyeShot 핸들링을 위한 그래픽라이브러리 코드 클래스
// version : 1.0
// 2021.08.06


// Eyeshot 정의 헤더
using devDept.Eyeshot.Entities;
using devDept.Geometry;

namespace CAD_Modeler
{
    internal enum ErrorCode
    {
        IsNull,
        Other_sketch_is_activated,

    }

    enum API_RESULT
    {
        OK,
        Fail,

    }
    public class ES_V1
    {
        private devDept.Eyeshot.Model Model1;           // Eyeshot Model 클래스 객체 선언

        Plane basis = new Plane(new Point3D(0, 0, 0), Vector3D.AxisX, Vector3D.AxisY);
        private DataTree dataTree = null;


        /* ******************************************************************
         * ES V1 클래스 초기화 함수
         * ****************************************************************** */
        public void Init(devDept.Eyeshot.Model model, DataTree dataTree)
        {
            this.Model1 = model;
            this.dataTree = dataTree;
            this.dataTree.basicPlaneList.Add(new Custom_Plane("XY", new Plane(new Point3D(0, 0, 0), Vector3D.AxisX, Vector3D.AxisY), true));
            this.dataTree.basicPlaneList.Add(new Custom_Plane("YZ", new Plane(new Point3D(0, 0, 0), Vector3D.AxisY, Vector3D.AxisZ), true));
            this.dataTree.basicPlaneList.Add(new Custom_Plane("XZ", new Plane(new Point3D(0, 0, 0), Vector3D.AxisX, Vector3D.AxisZ), true));

            foreach(Custom_Plane plane in dataTree.basicPlaneList)
            {
                dataTree.planeList.Add(plane);
            }
        }

        /* ******************************************************************
         * 기본 평면 Display 함수
         * ****************************************************************** */
        public void BasicPlane_Display()
        {
            foreach (Custom_Plane cp in dataTree.planeList)
            {
                if (cp.isVisible)
                    Model1.Entities.Add(cp, cp.color);
            }

            Model1.ActiveViewport.SetView(devDept.Eyeshot.viewType.Trimetric);
            Model1.ZoomFit();
            Model1.Invalidate();
        }
    }

    public class Custom_Plane : Quad
    {
        public string name;
        public Plane plane;
        public bool isVisible = false;
        public Color color = Color.FromArgb(100, Color.DeepSkyBlue);


        public Custom_Plane() : base(new Plane(), -100, -100, 200, 200)
        {
            this.name = "";
            this.plane = new Plane();
        }

        public Custom_Plane(string _name, Plane _plane) : base(_plane, -100, -100, 200, 200)
        {
            this.name = _name;
            this.plane = _plane;
        }

        public Custom_Plane(string _name, Plane _plane, bool _isVisible) : base(_plane, -100, -100, 200, 200)
        {
            this.name = _name;
            this.isVisible = _isVisible;
            this.plane = _plane;
        }

        public Custom_Plane(string _name, Plane _plane, Color _color) : base(_plane, -100, -100, 200, 200)
        {
            this.name = _name;
            this.color = _color;
            this.plane = _plane;
        }

        public Custom_Plane(string _name, Plane _plane, Color _color, bool _isVisible) : base(_plane, -100, -100, 200, 200)
        {
            this.name = _name;
            this.isVisible = _isVisible;
            this.color = _color;
            this.plane = _plane;
        }

        public Custom_Plane(string _name, Plane _plane, double _size, bool _isVisible) : base(_plane, -_size / 2, -_size / 2, _size, _size)
        {
            this.name = _name;
            this.isVisible = _isVisible;
            this.plane = _plane;
        }

        public Custom_Plane(string _name, Plane _plane, Color _color, double _size) : base(_plane, -_size / 2, -_size / 2, _size, _size)
        {
            this.name = _name;
            this.color = _color;
            this.plane = _plane;
        }

        public Custom_Plane(string _name, Plane _plane, Color _color, double _size, bool _isVisible) : base(_plane, -_size / 2, -_size / 2, _size, _size)
        {
            this.name = _name;
            this.isVisible = _isVisible;
            this.color = _color;
            this.plane = _plane;
        }

        public delegate void ItemSelectedEventHandler();

        public event ItemSelectedEventHandler SelectedEvent;

        
    }

    public class Sketch
    {
        public string name = "";
        public List<List<ICurve>> contourList = new List<List<ICurve>>();
        public Region region = new Region();
        public List<Point> pointList = new List<Point>();
        public bool isVisible = true;
        public Plane plane;
        public Color color = Color.FromArgb(100, Color.Blue);
        
        public Sketch(String _name, Plane _plane)
        {
            this.name = _name;
            this.plane = _plane;
        }
    }


    public class Custom_Rectangle : List<Line>
    {
        ///////////////////////////////////////
        // 각 포인트 위치
        //           Line2
        //   4 ------------------ 3
        // L |                    | L
        // i |                    | i
        // n |         0          | n
        // e |                    | e
        // 3 |                    | 1
        //   1 ------------------ 2
        //           Line0
        ///////////////////////////////////////
        public Point3D[] point3DList = new Point3D[5];
        public Point2D[] point2DList = new Point2D[5];
        public Point[] pointList = new Point[5];
        public Plane plane;
        public bool centred = false;

        public Custom_Rectangle(Plane _plane, Point3D pt1, Point3D pt2, bool _centered = false) : base()
        {
            this.plane = _plane;
            if (_centered)
            {
                point2DList[0] = this.plane.Project(pt1);
                point2DList[3] = this.plane.Project(pt2);

                point2DList[1] = new Point2D(point2DList[0].X * 2.0 - point2DList[3].X, point2DList[0].Y * 2.0 - point2DList[3].Y);
                point2DList[2] = new Point2D(point2DList[3].X, point2DList[1].Y);
                point2DList[4] = new Point2D(point2DList[1].X, point2DList[3].Y);
            }
            else
            {
                point2DList[1] = this.plane.Project(pt1);
                point2DList[3] = this.plane.Project(pt2);

                point2DList[0] = new Point2D((point2DList[1].X + point2DList[3].X) / 2.0, (point2DList[1].Y + point2DList[3].Y) / 2.0);
                point2DList[2] = new Point2D(point2DList[3].X, point2DList[1].Y);
                point2DList[4] = new Point2D(point2DList[1].X, point2DList[3].Y);
            }

            DrawRectangle();
            point3DList.ConvertToPoint3DArray(this.plane, point2DList);
            pointList.ConvertToPointArray(point3DList);
        }

        public Custom_Rectangle(Plane _plane, Point2D pt1, Point2D pt2) : base()
        {
            this.plane = _plane;
            point2DList[1] = pt1;
            point2DList[3] = pt2;

            point2DList[0] = new Point2D((point2DList[1].X + point2DList[3].X) / 2.0, (point2DList[1].Y + point2DList[3].Y) / 2.0);
            point2DList[2] = new Point2D(point2DList[3].X, point2DList[1].Y);
            point2DList[4] = new Point2D(point2DList[1].X, point2DList[3].Y);

            DrawRectangle();
            point3DList.ConvertToPoint3DArray(this.plane, point2DList);
            pointList.ConvertToPointArray(point3DList);
        }
        void DrawRectangle()
        {
            if(this.Count > 0)
                this.Clear();

            for (int i = 1; i < 5; i++)
            {
                if (i != 4)
                    this.Add(new Line(plane, point2DList[i], point2DList[i + 1]));
                else
                    this.Add(new Line(plane, point2DList[4], point2DList[1]));
            }
        }

        public void UpdateRectangle(Point3D pt1, Point3D pt2, bool _Centered = false)
        {
            if (_Centered)
            {
                Point2D pt01 = this.plane.Project(pt1);
                Point2D pt02 = this.plane.Project(pt2);
                point2DList[0].X = pt01.X;
                point2DList[0].Y = pt01.Y;
                point2DList[1].X = pt01.X*2 - pt02.X;
                point2DList[1].Y = pt01.Y*2 - pt02.Y;
                pt01 = point2DList[1].Clone() as Point2D;
                point2DList[2].X = pt02.X;
                point2DList[2].Y = pt01.Y;
                point2DList[3].X = pt02.X;
                point2DList[3].Y = pt02.Y;
                point2DList[4].X = pt01.X;
                point2DList[4].Y = pt02.Y;
            }
            else
            {
                Point2D pt01 = this.plane.Project(pt1);
                Point2D pt02 = this.plane.Project(pt2);
                point2DList[0].X = (pt01.X + pt02.X) / 2.0;
                point2DList[0].Y = (pt01.X + pt02.X) / 2.0;
                point2DList[1].X = pt01.X;
                point2DList[1].Y = pt01.Y;
                point2DList[2].X = pt02.X;
                point2DList[2].Y = pt01.Y;
                point2DList[3].X = pt02.X;
                point2DList[3].Y = pt02.Y;
                point2DList[4].X = pt01.X;
                point2DList[4].Y = pt02.Y;
            }

            point3DList.ConvertToPoint3DArray(this.plane, point2DList);
            pointList.ConvertToPointArray(point3DList);

            updateLines();
        }

        void updateLines()
        {
            for(int i = 0; i < 4; i++)
            {
                this[i].StartPoint = point3DList[i+1];
                this[i].EndPoint = point3DList[(i + 1) % 4 + 1];
            }
        }
    }

    public enum ConstraintType
    {
        Coincidence,
        Centered,
        Parallel,
        Vertical,
        Horizontal,
        InRectangle,

    }
}
