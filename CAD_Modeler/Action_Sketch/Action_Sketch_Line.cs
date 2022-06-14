using CAD_Modeler.Constraints;
using devDept.Eyeshot;
using devDept.Eyeshot.Entities;
using devDept.Geometry;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = System.Drawing.Color;

namespace CAD_Modeler.ActionBase_Sketch
{
    class Action_Sketch_Line : ActionBase
    {
        Point3D firstPoint = null;
        Line tempLine = null;
        Sketch sketch = null;
        ConstraintManager ctManager = null;
        List<ICurve> curveList = new List<ICurve>();

        public Action_Sketch_Line(Model model, Sketch sketch, ConstraintManager ctManager) : base(model)
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
                curveList.Add(l);

                AddCtItem(p1, l, ConstraintItem.Type.MatchPoint_LineStartPoint);
                AddCtItem(p2, l, ConstraintItem.Type.MatchPoint_LineEndPoint);

                model1.Entities.Add(p1);
                model1.Entities.Add(p2);
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

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (firstPoint == null)
                return;

            if (tempLine == null)
            {
                tempLine = new Line(firstPoint, point3D);
                tempLine.Color = Color.Red;
                model1.TempEntities.Add(tempLine);
            }
            else
            {
                tempLine.EndPoint = point3D;
            }
            model1.Invalidate();
        }

        protected override void EndAction()
        {
            base.EndAction();
            sketch.contourList.Add(curveList);
            model1.TempEntities.Remove(tempLine);
            tempLine = null;
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
    }
}
