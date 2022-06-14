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
    class Action_Sketch_CenteredRectangle : ActionBase
    {
        Point3D firstPoint = null;
        Custom_Rectangle tempRectangle = null;
        Sketch sketch = null;
        List<ICurve> curveList = new List<ICurve>();

        public Action_Sketch_CenteredRectangle(Model model, Sketch sketch) : base(model)
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
            firstPoint = pt1;
            var pt2 = await GetPoint3D("second");
            Custom_Rectangle rectangle = new Custom_Rectangle(activatedPlane, pt1, pt2, true);
            foreach (Line line in rectangle)
            {
                line.Color = Color.Black;
                line.ColorMethod = colorMethodType.byEntity;
                model1.Entities.Add(line);
                curveList.Add(line);
            }
            foreach (Point pt in rectangle.pointList)
            {
                pt.Color = Color.Black;
                pt.ColorMethod = colorMethodType.byEntity;
                model1.Entities.Add(pt);
                sketch.pointList.Add(pt);
            }

            model1.Entities.Regen();
            model1.Invalidate();

            EndAction();
            return true;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (firstPoint == null)
                return;

            if (tempRectangle == null)
            {
                if (firstPoint.DistanceTo(point3D) < 1)
                    tempRectangle = new Custom_Rectangle(activatedPlane, firstPoint, point3D + new Point3D(1, 1, 1));
                else
                    tempRectangle = new Custom_Rectangle(activatedPlane, firstPoint, point3D);
                foreach (Line line in tempRectangle)
                {
                    model1.TempEntities.Add(line);
                }
            }
            else
            {
                if (firstPoint.DistanceTo(point3D) < 1)
                    return;
                tempRectangle.UpdateRectangle(firstPoint, point3D, true);
                foreach (Line line in tempRectangle)
                    line.Regen(1);
            }
            model1.Invalidate();
        }

        protected override void EndAction()
        {
            base.EndAction();
            sketch.contourList.Add(curveList);
            foreach (Line line in tempRectangle)
                model1.TempEntities.Remove(line);
            tempRectangle = null;
        }
    }
}
