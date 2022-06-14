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
    class Action_Sketch_Circle : ActionBase
    {
        Point3D firstPoint = null;
        Circle tempCircle = null;
        Sketch sketch = null;
        List<ICurve> curveList = new List<ICurve>();

        public Action_Sketch_Circle(Model model, Sketch sketch) : base(model)
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
            Circle circle;
            if (firstPoint.DistanceTo(point3D) < 1)
                circle = new Circle(activatedPlane, firstPoint, 1);
            else
                circle = new Circle(activatedPlane, firstPoint, firstPoint.DistanceTo(point3D));

            circle.Color = Color.Black;
            circle.ColorMethod = colorMethodType.byEntity;

            curveList.Add(circle);
            model1.Entities.Add(circle);
            model1.Entities.Regen();
            model1.Invalidate();

            EndAction();
            return true;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (firstPoint == null)
                return;

            if (tempCircle == null)
            {
                if (firstPoint.DistanceTo(point3D) < 1)
                    tempCircle = new Circle(activatedPlane, firstPoint, 1);
                else
                    tempCircle = new Circle(activatedPlane, firstPoint, firstPoint.DistanceTo(point3D));

                model1.TempEntities.Add(tempCircle);
            }
            else
            {
                tempCircle.Radius = firstPoint.DistanceTo(point3D);
            }
            tempCircle.Regen(0.1);
            model1.Invalidate();
        }

        protected override void EndAction()
        {
            base.EndAction();
            sketch.contourList.Add(curveList);
            model1.TempEntities.Remove(tempCircle);
            tempCircle = null;
        }
    }
}
