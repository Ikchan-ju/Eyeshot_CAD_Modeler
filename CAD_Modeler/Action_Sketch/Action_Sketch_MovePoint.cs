using devDept.Eyeshot;
using devDept.Eyeshot.Entities;
using devDept.Geometry;
using Color = System.Drawing.Color;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAD_Modeler.ActionBase_Sketch
{
    class Action_Sketch_MovePoint : ActionBase
    {
        Point3D firstPoint = null;
        Line tempLine = null;
        Sketch sketch = null;
        List<ICurve> curveList = new List<ICurve>();

        public Action_Sketch_MovePoint(Model model, Sketch sketch) : base(model)
        {
            this.sketch = sketch;
        }

        public async override void Run()
        {
            await RunAsync();
        }

        public async Task<bool> RunAsync()
        {
            StartAction();
            var pt1 = await GetPoint3D("first");
            if (IsCanceled())
            {
                MessageBox.Show("Canceled");
                EndAction();
                return false;
            }
            firstPoint = pt1;
            while (!IsCanceled())
            {

                var pt2 = await GetPoint3D("second");
                if (IsCanceled())
                {
                    MessageBox.Show("Canceled");
                    EndAction();
                    return false;
                }

                Line l = new Line(pt1, pt2);
                l.Color = Color.Black;
                l.ColorMethod = colorMethodType.byEntity;

                Point p1 = new Point(pt1, 5);
                Point p2 = new Point(pt2, 5);
                sketch.pointList.Add(p1);
                sketch.pointList.Add(p2);
                model1.Entities.Add(p1);
                model1.Entities.Add(p2);

                l.StartPoint = p1.Position;
                l.EndPoint = p2.Position;
                p1.EntityData = l;
                p2.EntityData = l;

                curveList.Add(l);
                model1.Entities.Add(l);
                model1.Entities.Regen();
                model1.Invalidate();

                model1.TempEntities.Remove(tempLine);
                firstPoint = pt2;
                tempLine = null;
                pt1 = pt2;
            }

            EndAction();
            return true;
        }

        protected override void OnMouseDrag(MouseEventArgs e)
        {
                if (selectedPt == null)
                    return;

        }

        protected override void EndAction()
        {
            base.EndAction();
            sketch.contourList.Add(curveList);
            model1.TempEntities.Remove(tempLine);
            tempLine = null;
        }
    }
}
