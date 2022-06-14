using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = System.Drawing.Color;

// Eyeshot 헤더 정의
using devDept.Eyeshot.Entities;
using devDept.Eyeshot;
using devDept.Graphics;
using devDept.Geometry;
using System.Collections;
using CAD_Modeler.ActionBase_Sketch;
using CAD_Modeler.Constraints;
using static devDept.Eyeshot.Environment;
using devDept.Eyeshot.Translators;




namespace CAD_Modeler
{
    public enum Mode
    {
        Idle,
        Modeling,
        Sketch,
        Assembly,
    }

    public partial class Main_Form : Form
    {
        bool dragFlag = false;
        ES_V1 ES_V1 =null;
        Mode mode = Mode.Modeling;
        DataTree dataTree = null;

        ConstraintManager ctManager = null;
        GripManager gripManager = null;

        public Form_Log form_log = null;

        ColorDialog colorDialog = new ColorDialog();


        public Main_Form()
        {
            InitializeComponent();
            model1.Unlock("US21-J8VX6-12E18-5EQC-RMYW");
            model1.MouseMove += Model1_MouseMove;
            model1.MouseMove += Model1_MouseDrag;
            model1.MouseClick += Model1_MouseClick;
            model1.KeyUp += Model1_KeyUp;
            model1.MouseDown += Model1_MouseDown;
            model1.MouseUp += Model1_MouseUp;
            model1.MouseClick += Model1_RightClick;
        }

        private void Model1_RightClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.contextMenuStrip1.Show(model1, new System.Drawing.Point(e.X, e.Y));
            }
        }



        // ------------------------------------------------------------------------------------------
        // ------------------------------------------------------------------------------------------
        // ------------------------------------------------------------------------------------------

        /* ******************************************************************
         * Main Form 로딩 함수
         * 
         * Display의 기본 설정
         * 
         * 1) View 설정 - Grid / Perspective / 
         * 2) 기본 평면 띄우기
         * ****************************************************************** */
        private void Main_Form_Load(object sender, EventArgs e)
        {
            // 0. 초기화
            ES_V1 = new ES_V1();
            dataTree = new DataTree();
            ctManager = new ConstraintManager();
            gripManager = new GripManager(model1);
            form_log = new Form_Log();
            form_log.Show();
            this.ES_V1.Init(this.model1, dataTree);

            // 1. View 설정
            Load_View_Setting();

            // 2. 기본 평면 띄우기
            Load_BasicPlane_Setting();

            // 10. ActionBase 생성

            // 11. 모델 투명 민감도 설정
            model1.AccurateTransparency = false;

            // 12. ActionBase 셀렉션 모드 설정
            ActionBase.SetSelectionMode(selectionFilterType.Entity);

            // 99. View - Zoomfit
            model1.ZoomFit(false, 100);     // true : selected only, margin = 100

            // 100. Refresh
            this.model1.Invalidate();
        }
        /* ******************************************************************
         * Load - 기본 View 설정 함수
         * ****************************************************************** */
        private void Load_View_Setting()
        {
            // model1의 그리드 설정
            model1.ActiveViewport.Grid.Max = new Point2D(200, 200);   // 최대값(X, Y)
            model1.ActiveViewport.Grid.Min = new Point2D(-200, -200);   // 최소값(X, Y)
            model1.ActiveViewport.Grid.Step = 20;                      // 그리드 간격

            // model1의 View 설정 - ISOmetric Vie / TOP / BOTTOM....
            model1.SetView(viewType.Trimetric);

            // model1의 View - 평행/원근 모드
            model1.ActiveViewport.Camera.ProjectionMode = projectionType.Orthographic;
        }

        /* ******************************************************************
         * Load - 기본 평면 Display 함수
         * ****************************************************************** */
        private void Load_BasicPlane_Setting()
        {
            this.model1.Entities.Clear();
            this.ES_V1.BasicPlane_Display();
        }



        // ------------------------------------------------------------------------------------------
        // ------------------------------------------------------------------------------------------
        // ------------------------------------------------------------------------------------------

        /* ******************************************************************
         * 종료 버튼 클릭함수
         * ****************************************************************** */
        private void btnExit_Click(object sender, EventArgs e)
        {
            // 종료 시 처리 코드 여기 ...
            this.Close();
        }

        /* ******************************************************************
         * Model 상의 마우스 이동 이벤트
         * ****************************************************************** */
        private void Model1_MouseMove(object sender, MouseEventArgs e)
        {
            ActionBase.MouseMoveHandler(model1, e);
        }

        /* ******************************************************************
         * Model 상의 마우스 이동 이벤트 중 drag 전용
         * ****************************************************************** */
        private void Model1_MouseDrag(object sender, MouseEventArgs e)
        {
            if (dragFlag)
                ActionBase.MouseDragHandler(model1, e);
        }

        /* ******************************************************************
         * Model 상의 마우스 클릭 이벤트
         * ****************************************************************** */
        private void Model1_MouseClick(object sender, MouseEventArgs e)
        {
            ActionBase.MouseClickHandler(model1, e);
        }

        /* ******************************************************************
         * Model 상의 키보드 키업 이벤트
         * ****************************************************************** */
        private void Model1_KeyUp(object sender, KeyEventArgs e)
        {
            ActionBase.KeyUpHandler(e);
        }

        /* ******************************************************************
         * Model 상의 마우스 업 이벤트
         * ****************************************************************** */
        private void Model1_MouseUp(object sender, MouseEventArgs e)
        {
            dragFlag = false;
            ActionBase.MouseUpHandler(model1, e);
        }

        /* ******************************************************************
         * Model 상의 마우스 다운 이벤트
         * ****************************************************************** */
        private void Model1_MouseDown(object sender, MouseEventArgs e)
        {
            dragFlag = true;
            ActionBase.MouseDownHandler(model1, e);
        }


        /// <summary>
        /// Extrude 버튼 기능 시작
        /// </summary>
        
        internal Model GetModel()
        {
            return model1;
        }

        private void btnPart_Extrude_Click(object sender, EventArgs e)
        {
            if (mode != Mode.Modeling)
                return;

            Region tempRegion = null;
            foreach (var en in model1.Entities)
            {
                if (!(en is Region))
                    continue;
                if (en.Selected)
                {
                    tempRegion = en as Region;
                }
            }
            Form_Modeler form= new Form_Modeler(this, Form_Modeler.Type.Extrude, tempRegion);

            form.Show();
        }

        private void btnPart_ExtrudeCut_Click(object sender, EventArgs e)
        {
            if (mode != Mode.Modeling)
                return;

            Region tempRegion = null;
            foreach (var en in model1.Entities)
            {
                if (!(en is Region))
                    continue;
                if (en.Selected)
                {
                    tempRegion = en as Region;
                }
            }
            Form_Modeler form = new Form_Modeler(this, Form_Modeler.Type.ExtrudeCut, tempRegion);

            form.Show();
        }

        private void btnPart_Revolve_Click(object sender, EventArgs e)
        {
            if (mode != Mode.Modeling)
                return;

            Region tempRegion = null;
            foreach (var en in model1.Entities)
            {
                if (!(en is Region))
                    continue;
                if (en.Selected)
                {
                    tempRegion = en as Region;
                }
            }
            Form_Modeler form = new Form_Modeler(this, Form_Modeler.Type.Revolve, tempRegion);

            form.Show();
        }

        private void btnPart_RevolveCut_Click(object sender, EventArgs e)
        {
            if (mode != Mode.Modeling)
                return;

            Region tempRegion = null;
            foreach (var en in model1.Entities)
            {
                if (!(en is Region))
                    continue;
                if (en.Selected)
                {
                    tempRegion = en as Region;
                }
            }
            Form_Modeler form = new Form_Modeler(this, Form_Modeler.Type.RevolveCut, tempRegion);

            form.Show();
        }

        private void btnPart_Sweep_Click(object sender, EventArgs e)
        {
            if (mode != Mode.Modeling)
                return;

            Region tempRegion = null;
            foreach (var en in model1.Entities)
            {
                if (!(en is Region))
                    continue;
                if (en.Selected)
                {
                    tempRegion = en as Region;
                }
            }
            Form_Modeler form = new Form_Modeler(this, Form_Modeler.Type.Sweep, tempRegion);

            form.Show();
        }

        private void SweepCut_Click(object sender, EventArgs e)
        {
            if (mode != Mode.Modeling)
                return;

            Region tempRegion = null;
            foreach (var en in model1.Entities)
            {
                if (!(en is Region))
                    continue;
                if (en.Selected)
                {
                    tempRegion = en as Region;
                }
            }
            Form_Modeler form = new Form_Modeler(this, Form_Modeler.Type.SweepCut, tempRegion);

            form.Show();
        }

        private void 색상변경ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Entity selectedEntity = null;

                foreach (var ent in model1.Entities)
                {
                    if (ent.Selected && ent is Brep)
                    {
                        selectedEntity = ent;
                    }
                }
                Brep brep = selectedEntity as Brep;
                if (brep == null)
                    return;

                selectedEntity.Color = colorDialog.Color;
                model1.Entities.Regen();
                model1.Invalidate();
            }
        }

        private void normalViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Custom_Plane selectedPlane = null;

            foreach (var ent in model1.Entities)
            {
                if (ent.Selected && ent is Custom_Plane)
                {
                    selectedPlane = ent as Custom_Plane;
                }
            }
            if (selectedPlane == null)
                return;

            model1.Entities.ClearSelection();

            model1.SetView(selectedPlane.plane.AxisZ, selectedPlane.plane.AxisY, true, false);

            model1.ActiveViewport.Grid.Plane = selectedPlane.plane;

            model1.ZoomFit();

            model1.Invalidate();
        }

        private void 파트이동ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mode != Mode.Modeling)
                return;

            mode = Mode.Assembly;
            Form_Transformation form = new Form_Transformation(this);

            form.Show();
        }

        private void MenuStrip_file_export_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = ImportExportHelper.GetExportFilter(false, true, false, true);

            saveFileDialog1.AddExtension = true;
            saveFileDialog1.CheckPathExists = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (var bp in dataTree.basicPlaneList)
                {
                    model1.Entities.Remove(bp);
                }
                WriteFileAsync wfa = ImportExportHelper.GetExportWriter(saveFileDialog1.FileName, model1);
                foreach (var bp in dataTree.basicPlaneList)
                {
                    model1.Entities.Add(bp);
                }
                if (wfa != null)
                {
                    model1.StartWork(wfa);
                }
            }
        }
        private void MenuStrip_file_import_Click(object sender, EventArgs e)
        {
            using (var importFileDialog1 = new OpenFileDialog())
            {
                importFileDialog1.Filter = ImportExportHelper.GetImportFilter(false, true, false, true, false, true, false, false);
                importFileDialog1.Multiselect = false;
                importFileDialog1.AddExtension = true;
                importFileDialog1.CheckFileExists = true;
                importFileDialog1.CheckPathExists = true;

                if (importFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    ReadFileAsync rfa = ImportExportHelper.GetImportReader(importFileDialog1.FileName);
                    rfa.DoWork();

                    ResetControls();
                    if (rfa != null)
                    {
                        rfa.AddToScene(model1);
                        model1.Invalidate();
                    }
                }
            }
        }


        private void MenuStrip_file_open_Click(object sender, EventArgs e)
        {

        }

        private void MenuStrip_file_save_Click(object sender, EventArgs e)
        {

        }

        private void ResetControls()
        {
            model1.Entities.RemoveRange(0, model1.Entities.Count);
            foreach (var bp in dataTree.basicPlaneList)
            {
                model1.Entities.Add(bp);
            }
        }

        private void MenuStrip_insert_part_Click(object sender, EventArgs e)
        {
            using (var importFileDialog1 = new OpenFileDialog())
            {
                importFileDialog1.Filter = ImportExportHelper.GetImportFilter(false, true, false, true, false, true, false, false);
                importFileDialog1.Multiselect = false;
                importFileDialog1.AddExtension = true;
                importFileDialog1.CheckFileExists = true;
                importFileDialog1.CheckPathExists = true;

                if (importFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    ReadFileAsync rfa = ImportExportHelper.GetImportReader(importFileDialog1.FileName);
                    rfa.DoWork();

                    if (rfa != null)
                    {
                        rfa.AddToScene(model1);
                        model1.Invalidate();
                    }
                }
            }
        }


        /////////////////// Extrude 버튼 기능 끝
    }   // The end of public partial class Main_Form : Form

}   // The end of namespace CAD_Modeler
