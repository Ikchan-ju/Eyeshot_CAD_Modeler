using devDept.Eyeshot.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAD_Modeler
{

    /* ******************************************************************
     * Upper Menu 관련 코드
     * ****************************************************************** */

    public partial class Main_Form : Form
    {

        #region     DISPLAY

        /* ******************************************************************
         * Display - Perspective View 클릭 함수
         * ****************************************************************** */
        private void btnDisplay_Perspective_Click(object sender, EventArgs e)
        {

        }
        /* ******************************************************************
         * Display - Perpendicular View 클릭 함수
         * ****************************************************************** */
        private void btnDisplay_Perpendicular_Click(object sender, EventArgs e)
        {

        }
        /* ******************************************************************
         * Display - Grid 클릭 함수
         * ****************************************************************** */
        private void btnDisplay_Grid_Click(object sender, EventArgs e)
        {

        }

        #endregion     DISPLAY


        #region     RENDER
        /* ******************************************************************
         * Render - Shase with Edge 클릭 함수
         * ****************************************************************** */
        private void btnRender_ShadeEdge_Click(object sender, EventArgs e)
        {

        }
        /* ******************************************************************
         * Render - Shase Smooth 클릭 함수
         * ****************************************************************** */
        private void btnRender_ShadeSmooth_Click(object sender, EventArgs e)
        {

        }
        /* ******************************************************************
         * Render - Hidden Line Wireframe 클릭 함수
         * ****************************************************************** */
        private void btnRender_HiddenWire_Click(object sender, EventArgs e)
        {

        }
        /* ******************************************************************
         * Render - Wireframe 1(all line display) 클릭 함수
         * ****************************************************************** */
        private void btnRender_Wireframe1_Click(object sender, EventArgs e)
        {

        }
        /* ******************************************************************
         * Render - Wireframe 2(without hidden line) 클릭 함수
         * ****************************************************************** */
        private void btnRender_Wireframe2_Click(object sender, EventArgs e)
        {

        }
        #endregion     RENDER

        #region     PROJECTION
        /* ******************************************************************
         * Projection - Isometric View 클릭 함수
         * ****************************************************************** */
        private void btnProjection_Isometric_Click(object sender, EventArgs e)
        {

        }
        /* ******************************************************************
         * Projection - Front View 클릭 함수
         * ****************************************************************** */
        private void btnProjection_Front_Click(object sender, EventArgs e)
        {

        }
        /* ******************************************************************
         * Projection - Rear View 클릭 함수
         * ****************************************************************** */
        private void btnProjection_Rear_Click(object sender, EventArgs e)
        {

        }
        /* ******************************************************************
         * Projection - Left View 클릭 함수
         * ****************************************************************** */
        private void btnProjection_Left_Click(object sender, EventArgs e)
        {

        }
        /* ******************************************************************
         * Projection - Right View 클릭 함수
         * ****************************************************************** */
        private void btnProjection_Right_Click(object sender, EventArgs e)
        {

        }
        /* ******************************************************************
         * Projection - Upper View 클릭 함수
         * ****************************************************************** */
        private void btnProjection_Upper_Click(object sender, EventArgs e)
        {

        }
        /* ******************************************************************
         * Projection - Bottom View 클릭 함수
         * ****************************************************************** */
        private void btnProjection_Bottom_Click(object sender, EventArgs e)
        {

        }
        /* ******************************************************************
         * Projection - Normal View 클릭 함수
         * ****************************************************************** */
        private void Normal_Click(object sender, EventArgs e)
        {

        }
        #endregion     PROJECTION

        #region     SELECTION
        /* ******************************************************************
         * Selection - Point 클릭 함수
         * ****************************************************************** */
        private async void btnSelection_Point_Click(object sender, EventArgs e)
        {
            foreach(var ent in model1.Entities)
            {
                var pt = ent as Point;
                if (pt == null)
                    continue;
                pt.Visible = false;
            }
            Action_Sketch_Grip action = new Action_Sketch_Grip(model1, dataTree.selectedSketch, gripManager, ctManager);
            await action.RunAsync();
        }
        /* ******************************************************************
         * Selection - Line 클릭 함수
         * ****************************************************************** */
        private void btnSelection_Line_Click(object sender, EventArgs e)
        {
            ActionBase.SetSelectionMode(devDept.Eyeshot.selectionFilterType.Edge, mode);
        }
        /* ******************************************************************
         * Selection - Plane 클릭 함수
         * ****************************************************************** */
        private void btnSelection_Plane_Click(object sender, EventArgs e)
        {
            ActionBase.SetSelectionMode(devDept.Eyeshot.selectionFilterType.Face, mode);
        }
        /* ******************************************************************
         * Selection - Entity 클릭 함수
         * ****************************************************************** */
        private void btnSelection_Entity_Click(object sender, EventArgs e)
        {
            ActionBase.SetSelectionMode(devDept.Eyeshot.selectionFilterType.Entity, mode);
        }
        #endregion     SELECTION


    }   // The end of public partial class Main_Form : Form

}   // The end of namespace CAD_Modeler
