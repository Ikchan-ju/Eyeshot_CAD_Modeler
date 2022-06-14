using devDept.Eyeshot;
using devDept.Eyeshot.Entities;
using devDept.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = System.Drawing.Color;
using Font = System.Drawing.Font;

namespace CAD_Modeler.ActionBase_Sketch
{
    class Action_Sketch_ : ActionBase
    {
        public enum SketchMode
        {
            Idle,
            Line,
            Rectangle,
            CenteredRectangle,
            Circle,

        }
        Sketch sketch;
        public SketchMode sketchMode = SketchMode.Idle;

        public Action_Sketch_(Model _model) : base(_model)
        {

        }

        public Action_Sketch_(Model _model, Sketch _sketch) : base(_model)
        {
            this.sketch = _sketch;
        }

        public API_RESULT setSketch(Sketch _sketch)
        {
            if (!(this.sketch == null))
                return API_RESULT.Fail;

            this.sketch = _sketch;
            activatedPlane = _sketch.plane;
            return API_RESULT.OK;
        }


        public async override void Run()
        {
            switch (sketchMode)
            {
                case SketchMode.Line:
                    await RunAsync_Line();

                    break;
                case SketchMode.Rectangle:

                    break;
                case SketchMode.CenteredRectangle:

                    break;
                case SketchMode.Circle:

                    break;
            }
        }
        protected override void StartAction()
        {
            base.StartAction();
        }

        protected override void EndAction()
        {
            base.EndAction();
            SetSelectionMode(selectionFilterType.Entity, Mode.Sketch);
        }

        public async Task<bool> RunAsync_Line()
        {
            StartAction();

            var pt0 = await GetPoint3D("first point");
            model1.Entities.Add(sketch.pointList[0], Color.Black);
            if (IsCanceled())
            {
                MessageBox.Show("Canceled");
                EndAction();
                return false;
            }
            Point3D pt_last = pt0.Clone() as Point3D;
            Point3D pt_now = pt0.Clone() as Point3D;
            while (!IsCanceled())
            {
                Line l0 = new Line(pt_last, pt_now);
                model1.TempEntities.Add(l0, Color.Blue);
                model1.TempEntities.Remove(l0);

                if (IsCanceled())
                {
                    MessageBox.Show("Canceled");
                    EndAction();
                    return false;
                }

                Line l1 = new Line(pt_last, pt_now);
                model1.Entities.Add(l1, Color.Red);
                model1.Entities.Add(sketch.pointList[sketch.pointList.Count - 1], Color.Black);
                model1.Entities.Regen();
                model1.Invalidate();
                pt_last = pt_now.Clone() as Point3D;
            }

            EndAction();
            return true;
        }
        public async Task<bool> RunAsync_CenteredRectangle()
        {
            StartAction();

            while (!IsCanceled())
            {
                var pt0 = await GetPoint3D("first point");
                if (IsCanceled())
                {
                    MessageBox.Show("Canceled");
                    EndAction();
                    return false;
                }
                Point3D pt_last = pt0.Clone() as Point3D;
                Point3D pt_now = pt0.Clone() as Point3D;
                Custom_Rectangle rectangle = new Custom_Rectangle(activatedPlane, pt_last, pt_now, true);
                foreach(Line line in rectangle)
                    model1.TempEntities.Add(line, Color.Blue);

                if (IsCanceled())
                {
                    MessageBox.Show("Canceled");
                    EndAction();
                    return false;
                }

                rectangle.UpdateRectangle(pt_last, pt_now, true);
                foreach (Line line in rectangle)
                    model1.Entities.Add(line, Color.Red);
                foreach (Point pt in rectangle.pointList)
                    model1.Entities.Add(pt, Color.Black);
                model1.Entities.Regen();
                model1.Invalidate();
                pt_last = pt_now.Clone() as Point3D;
            }

            EndAction();
            return true;
        }

        public async Task<bool> RunAsync_Circle()
        {
            StartAction();

            while (!IsCanceled())
            {
                var pt0 = await GetPoint3D("first point");
                if (IsCanceled())
                {
                    MessageBox.Show("Canceled");
                    EndAction();
                    return false;
                }
                Point3D pt_last = pt0.Clone() as Point3D;
                Point3D pt_now = pt0.Clone() as Point3D;

                Circle circle = new Circle(activatedPlane, pt_last, 10);
                model1.TempEntities.Add(circle, Color.Blue);

                if (IsCanceled())
                {
                    MessageBox.Show("Canceled");
                    EndAction();
                    return false;
                }

                if (pt_last.DistanceTo(point3D) < 10)
                    circle.Radius = 10;
                else
                    circle.Radius = pt_last.DistanceTo(point3D);
                model1.Entities.Add(circle, Color.Red);

                model1.Entities.Regen();
                model1.Invalidate();
                pt_last = pt_now.Clone() as Point3D;
            }

            EndAction();
            return true;
        }
    }
}
