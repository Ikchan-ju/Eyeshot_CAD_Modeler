using CAD_Modeler.Action_Sketch;
using CAD_Modeler.ActionBase_Sketch;
using CAD_Modeler.Constraints;
using devDept.Eyeshot.Entities;
using devDept.Geometry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static devDept.Eyeshot.Environment;

namespace CAD_Modeler
{

    /* ******************************************************************
     * Sketch Menu 관련 코드
     * ****************************************************************** */

    public partial class Main_Form : Form
    {
        /* ******************************************************************
         * Sketch - Sketch In 클릭 함수
         * ****************************************************************** */
        private void btnSketch_In_Click(object sender, EventArgs e)
        {
            if (mode == Mode.Sketch)
                return;
            if (model1.Entities.Count == 0)
                return;

            foreach (var ent in model1.Entities)
            {
                if (ent.Selected && ent is Custom_Plane)
                {
                    dataTree.selectedPlane = ent as Custom_Plane;
                    continue;
                }
            }
            if (dataTree.selectedPlane == null)
                return;

            foreach (var ent in model1.Entities)
                ent.Visible = false;

            model1.Entities.ClearSelection();

            model1.SetView(dataTree.selectedPlane.plane.AxisZ, dataTree.selectedPlane.plane.AxisY, true, false);

            model1.ActiveViewport.Grid.Plane = dataTree.selectedPlane.plane;
            model1.ZoomOut(30000);

            model1.Invalidate();

            mode = Mode.Sketch;
            dataTree.sketchList.Add(new Sketch("Sketch" + dataTree.sketchList.Count.ToString("00"), dataTree.selectedPlane.plane));
            dataTree.selectedSketch = dataTree.sketchList[dataTree.sketchList.Count - 1];

            form_log.AddLog("Sketch In" + " 완료");
        }
        /* ******************************************************************
         * Sketch - Sketch Out 클릭 함수
         * ****************************************************************** */
        private async void btnSketch_Out_Click(object sender, EventArgs e)
        {
            if (mode != Mode.Sketch)
                return;

            foreach (var ent in model1.Entities)
            {
                var cp = ent as Custom_Plane;
                if (cp != null)
                {
                    cp.Visible = cp.isVisible;
                    continue;
                }
                else
                {
                    ent.Visible = true;
                }

            }

            model1.Entities.ClearSelection();

            model1.SetView(devDept.Eyeshot.viewType.Trimetric);

            model1.ActiveViewport.Grid.Plane = dataTree.planeList[0].plane;
            model1.ZoomFit();

            model1.Invalidate();
            mode = Mode.Modeling;

            // sketch로 Region 만들기
            Action_Sketch_SketchOut ac = new Action_Sketch_SketchOut(model1, dataTree.selectedSketch);
            await ac.RunAsync();

            // region 객체 datatree에 추가
            dataTree.regionList.Add(ac.region);

            form_log.AddLog("Sketch Out" + " 완료");
        }
        /* ******************************************************************
         * Sketch - Line 클릭 함수
         * ****************************************************************** */
        private async void btnSketch_Line_Click(object sender, EventArgs e)
        {
            if (mode != Mode.Sketch)
                return;

            if (dataTree == null || dataTree.selectedSketch == null)
                return;

            Action_Sketch_Line action = new Action_Sketch_Line(model1, dataTree.selectedSketch, ctManager);
            await action.RunAsync();
        }
        /* ******************************************************************
         * Sketch - Dashed Line 클릭 함수
         * ****************************************************************** */
        private void btnSketch_DashedLine_Click(object sender, EventArgs e)
        {

        }
        /* ******************************************************************
         * Sketch - Centered Rectangle 클릭 함수
         * ****************************************************************** */
        private async void btnSketch_RectCenter_Click(object sender, EventArgs e)
        {
            if (mode != Mode.Sketch)
                return;

            if (dataTree == null || dataTree.selectedSketch == null)
                return;

            Action_Sketch_CenteredRectangle action = new Action_Sketch_CenteredRectangle(model1, dataTree.selectedSketch);
            await action.RunAsync();
        }
        /* ******************************************************************
         * Sketch - Rectangle 클릭 함수
         * ****************************************************************** */
        private async void btnSketch_Rect_Click(object sender, EventArgs e)
        {
            if (mode != Mode.Sketch)
                return;

            if (dataTree == null || dataTree.selectedSketch == null)
                return;

            Action_Sketch_Rectangle action = new Action_Sketch_Rectangle(model1, dataTree.selectedSketch, ctManager);
            await action.RunAsync();
        }
        /* ******************************************************************
         * Sketch - Circle 클릭 함수
         * ****************************************************************** */
        private async void btnSketch_Circle_Click(object sender, EventArgs e)
        {
            if (mode != Mode.Sketch)
                return;

            if (dataTree == null || dataTree.selectedSketch == null)
                return;

            Action_Sketch_Circle action = new Action_Sketch_Circle(model1, dataTree.selectedSketch);
            await action.RunAsync();
        }
        /* ******************************************************************
         * Sketch - Polygon 클릭 함수
         * ****************************************************************** */
        private void btnSketch_Polygon_Click(object sender, EventArgs e)
        {

        }
        /* ******************************************************************
         * Sketch - Slot 클릭 함수
         * ****************************************************************** */
        private void btnSketch_Slot_Click(object sender, EventArgs e)
        {

        }
        /* ******************************************************************
         * Sketch - Round 클릭 함수
         * ****************************************************************** */
        private void btnSketch_Round_Click(object sender, EventArgs e)
        {

        }
        /* ******************************************************************
         * Sketch - Trim 클릭 함수
         * ****************************************************************** */
        private void btnSketch_Trim_Click(object sender, EventArgs e)
        {

        }


        /* ******************************************************************
         * Sketch - Dimension 클릭 함수
         * ****************************************************************** */
        private void btnSketch_Dimension_Click(object sender, EventArgs e)
        {

        }

        #region CONSTRAINTS
        /* ******************************************************************
         * Sketch - 제약조건 - 수직 클릭 함수
         * ****************************************************************** */
        private async void btnSketch_Vertical_Click(object sender, EventArgs e)
        {
            Action_AddConstraintItem ac = new Action_AddConstraintItem(model1, ctManager, ConstraintItem.Type.Vertical_Line);
            await ac.RunAsync();
        }
        /* ******************************************************************
         * Sketch - 제약조건 - 수평 클릭 함수
         * ****************************************************************** */
        private async void btnSketch_Horizontal_Click(object sender, EventArgs e)
        {
            Action_AddConstraintItem ac = new Action_AddConstraintItem(model1, ctManager, ConstraintItem.Type.Horizontal_Line);
            await ac.RunAsync();
        }
        /* ******************************************************************
         * Sketch - 제약조건 - 직교 클릭 함수
         * ****************************************************************** */
        private async void btnSketch_Perpendicular_Click(object sender, EventArgs e)
        {
            Action_AddConstraintItem ac = new Action_AddConstraintItem(model1, ctManager, ConstraintItem.Type.Perpendicular_Line_Line);
            await ac.RunAsync();
        }
        /* ******************************************************************
         * Sketch - 제약조건 - 평행 클릭 함수
         * ****************************************************************** */
        private async void btnSketch_Parallel_Click(object sender, EventArgs e)
        {
            Action_AddConstraintItem ac = new Action_AddConstraintItem(model1, ctManager, ConstraintItem.Type.Parallel_Line_Line);
            await ac.RunAsync();
        }
        /* ******************************************************************
         * Sketch - 제약조건 - 접선 클릭 함수
         * ****************************************************************** */
        private void btnSketch_Tangent_Click(object sender, EventArgs e)
        {

        }
        /* ******************************************************************
         * Sketch - 제약조건 - 일치 클릭 함수
         * ****************************************************************** */
        private void btnSketch_Coincidence_Click(object sender, EventArgs e)
        {

        }
        /* ******************************************************************
         * Sketch - 제약조건 - 대칭 클릭 함수
         * ****************************************************************** */
        private void btnSketch_Symmetry_Click(object sender, EventArgs e)
        {

        }

        #endregion  CONSTRAINTS

    }   // The end of public partial class Main_Form : Form

}   // The end of namespace CAD_Modeler
