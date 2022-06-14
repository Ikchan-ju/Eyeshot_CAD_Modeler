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
using CAD_Modeler.Constraints;

namespace CAD_Modeler.ActionBase_Sketch
{
    class Action_Sketch_Rectangle : ActionBase
    {
        Point3D firstPoint = null;
        Custom_Rectangle tempRectangle = null;
        Sketch sketch = null;
        ConstraintManager ctManager = null;
        List<ICurve> curveList = new List<ICurve>();

        public Action_Sketch_Rectangle(Model model, Sketch sketch, ConstraintManager ctManager) : base(model)
        {
            this.sketch = sketch;
            this.ctManager = ctManager;
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

            Custom_Rectangle rectangle = new Custom_Rectangle(activatedPlane, pt1, pt2);
            for (int i = 0; i < 4; i++)
            {
                Point3D pt01 = rectangle.point3DList[i + 1];
                Point3D pt02 = rectangle.point3DList[(i + 1) % 4 + 1];
                Line line = new Line(pt01, pt02);
                line.Color = Color.Black;
                line.ColorMethod = colorMethodType.byEntity;

                Point p1 = new Point(pt01, 5);
                Point p2 = new Point(pt02, 5);

                sketch.pointList.Add(p1);
                sketch.pointList.Add(p2);
                curveList.Add(line);

                AddCtItem(p1, line, ConstraintItem.Type.MatchPoint_LineStartPoint);
                AddCtItem(p2, line, ConstraintItem.Type.MatchPoint_LineEndPoint);
                if(i%2 == 0)
                {
                    AddCtItem(line, activatedPlane, ConstraintItem.Type.Horizontal_Line);
                }
                else
                {
                    AddCtItem(line, activatedPlane, ConstraintItem.Type.Vertical_Line);
                }

                model1.Entities.Add(p1);
                model1.Entities.Add(p2);
                model1.Entities.Add(line);model1.Invalidate();
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
                tempRectangle.UpdateRectangle(firstPoint, point3D);
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
        private void AddCtItem(Entity targetEntity, Entity sourceEntity, ConstraintItem.Type ctItemType)
        {

            // CTItem 추가
            ConstraintItem item = new ConstraintItem();
            item.targetEntity = targetEntity;
            item.sourceEntity = sourceEntity;
            item.type = ctItemType;
            ctManager.items.Add(item);
        }
        private void AddCtItem(Entity targetEntity, Plane sourcePlane, ConstraintItem.Type ctItemType)
        {

            // CTItem 추가
            ConstraintItem item = new ConstraintItem();
            item.targetEntity = targetEntity;
            item.sourcePlane = sourcePlane;
            item.type = ctItemType;
            ctManager.items.Add(item);
        }
    }
}
