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

namespace CAD_Modeler
{
    class Action_Sketch_Grip : ActionBase
    {
        GripManager gripManager = null;
        ConstraintManager ctManager = null;

        Sketch sketch = null;

        public Action_Sketch_Grip(Model model, Sketch sketch, GripManager gripManager, ConstraintManager ctManager) : base(model)
        {
            this.sketch = sketch;
            this.gripManager = gripManager;
            this.ctManager = ctManager;
        }

        public async override void Run()
        {
            await RunAsync();
        }

        public async Task<bool> RunAsync()
        {
            StartAction();
            while (true)
            {
                if (IsCanceled())
                    break;
                await Task.Delay(10);
            }
            EndAction();
            return true;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            Point3D screenPos;
            model1.ScreenToPlane(e.Location, Plane.XY, out screenPos);
            if (screenPos == null)
                return;
            if (gripManager.GetSelectedGrip() != null)
            {
                gripManager.MoveGrip(screenPos);
                ctManager.Run();
                model1.Entities.RegenAllCurved();
                model1.Invalidate();
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (gripManager.GetSelectedGrip() != null)
            {
                gripManager.Finish();
                ctManager.Run();
                model1.Invalidate();
            }
            else
            {
                //객체 선택시 그립 생성
                var item = model1.GetItemUnderMouseCursor(e.Location);
                if (item != null)
                {
                    gripManager.MakeGrips(item.Item as Entity);
                    model1.Entities.Regen();
                    model1.Invalidate();
                }
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                gripManager.Cancel();
                model1.Invalidate();
            }
        }
    }
}
