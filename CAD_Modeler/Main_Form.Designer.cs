
namespace CAD_Modeler
{
    partial class Main_Form
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            devDept.Eyeshot.DisplayModeSettingsFlat displayModeSettingsFlat1 = new devDept.Eyeshot.DisplayModeSettingsFlat(false, devDept.Eyeshot.edgeColorMethodType.SingleColor, System.Drawing.Color.Black, 2F, 2F, devDept.Eyeshot.silhouettesDrawingType.LastFrame, true, devDept.Eyeshot.flatColorMethodType.EntityColor);
            devDept.Eyeshot.CancelToolBarButton cancelToolBarButton1 = new devDept.Eyeshot.CancelToolBarButton("Cancel", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ProgressBar progressBar1 = new devDept.Eyeshot.ProgressBar(devDept.Eyeshot.ProgressBar.styleType.Circular, 0, "Idle", System.Drawing.Color.Black, System.Drawing.Color.Transparent, System.Drawing.Color.Green, 1D, true, cancelToolBarButton1, false, 0.1D, 0.333D, true);
            devDept.Eyeshot.DisplayModeSettingsRendered displayModeSettingsRendered1 = new devDept.Eyeshot.DisplayModeSettingsRendered(true, devDept.Eyeshot.edgeColorMethodType.SingleColor, System.Drawing.Color.Black, 1F, 2F, devDept.Eyeshot.silhouettesDrawingType.LastFrame, false, devDept.Graphics.shadowType.Realistic, null, false, false, 0.3F, devDept.Graphics.realisticShadowQualityType.High);
            devDept.Graphics.BackgroundSettings backgroundSettings1 = new devDept.Graphics.BackgroundSettings(devDept.Graphics.backgroundStyleType.LinearGradient, System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231))))), System.Drawing.Color.DodgerBlue, System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231))))), 0.75D, null, devDept.Graphics.colorThemeType.Auto, 0.33D);
            devDept.Eyeshot.Camera camera1 = new devDept.Eyeshot.Camera(new devDept.Geometry.Point3D(0D, 0D, 45D), 380D, new devDept.Geometry.Quaternion(0.018434349666532526D, 0.039532590434972079D, 0.42221602280006187D, 0.90544518284475428D), devDept.Graphics.projectionType.Perspective, 40D, 2D, false, 0.001D);
            devDept.Eyeshot.HomeToolBarButton homeToolBarButton1 = new devDept.Eyeshot.HomeToolBarButton("Home", devDept.Eyeshot.ToolBarButton.styleType.PushButton, true, true);
            devDept.Eyeshot.MagnifyingGlassToolBarButton magnifyingGlassToolBarButton1 = new devDept.Eyeshot.MagnifyingGlassToolBarButton("Magnifying Glass", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomWindowToolBarButton zoomWindowToolBarButton1 = new devDept.Eyeshot.ZoomWindowToolBarButton("Zoom Window", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomToolBarButton zoomToolBarButton1 = new devDept.Eyeshot.ZoomToolBarButton("Zoom", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.PanToolBarButton panToolBarButton1 = new devDept.Eyeshot.PanToolBarButton("Pan", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.RotateToolBarButton rotateToolBarButton1 = new devDept.Eyeshot.RotateToolBarButton("Rotate", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomFitToolBarButton zoomFitToolBarButton1 = new devDept.Eyeshot.ZoomFitToolBarButton("Zoom Fit", devDept.Eyeshot.ToolBarButton.styleType.PushButton, true, true);
            devDept.Eyeshot.ToolBar toolBar1 = new devDept.Eyeshot.ToolBar(devDept.Eyeshot.ToolBar.positionType.HorizontalTopCenter, true, new devDept.Eyeshot.ToolBarButton[] {
            ((devDept.Eyeshot.ToolBarButton)(homeToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(magnifyingGlassToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(zoomWindowToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(zoomToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(panToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(rotateToolBarButton1)),
            ((devDept.Eyeshot.ToolBarButton)(zoomFitToolBarButton1))});
            devDept.Eyeshot.Grid grid1 = new devDept.Eyeshot.Grid(new devDept.Geometry.Point2D(-100D, -100D), new devDept.Geometry.Point2D(100D, 100D), 10D, new devDept.Geometry.Plane(new devDept.Geometry.Point3D(0D, 0D, 0D), new devDept.Geometry.Vector3D(0D, 0D, 1D)), System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))), false, true, false, false, 10, 100, 10, System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90))))), System.Drawing.Color.Transparent, false, System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255))))));
            devDept.Eyeshot.OriginSymbol originSymbol1 = new devDept.Eyeshot.OriginSymbol(10, devDept.Eyeshot.originSymbolStyleType.Ball, new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129))), System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Red, System.Drawing.Color.Green, System.Drawing.Color.Blue, "Origin", "X", "Y", "Z", true, null, false);
            devDept.Eyeshot.RotateSettings rotateSettings1 = new devDept.Eyeshot.RotateSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.None), 10D, true, 1D, devDept.Eyeshot.rotationType.Trackball, devDept.Eyeshot.rotationCenterType.CursorLocation, new devDept.Geometry.Point3D(0D, 0D, 0D), false);
            devDept.Eyeshot.ZoomSettings zoomSettings1 = new devDept.Eyeshot.ZoomSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.Shift), 25, true, devDept.Eyeshot.zoomStyleType.AtCursorLocation, false, 1D, System.Drawing.Color.Empty, devDept.Eyeshot.Camera.perspectiveFitType.Accurate, false, 10, true);
            devDept.Eyeshot.PanSettings panSettings1 = new devDept.Eyeshot.PanSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.Ctrl), 25, true);
            devDept.Eyeshot.NavigationSettings navigationSettings1 = new devDept.Eyeshot.NavigationSettings(devDept.Eyeshot.Camera.navigationType.Examine, new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Left, devDept.Eyeshot.modifierKeys.None), new devDept.Geometry.Point3D(-1000D, -1000D, -1000D), new devDept.Geometry.Point3D(1000D, 1000D, 1000D), 8D, 50D, 50D);
            devDept.Eyeshot.CoordinateSystemIcon coordinateSystemIcon1 = new devDept.Eyeshot.CoordinateSystemIcon(new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129))), System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.OrangeRed, "Origin", "X", "Y", "Z", true, devDept.Eyeshot.coordinateSystemPositionType.BottomLeft, 37, null, false);
            devDept.Eyeshot.ViewCubeIcon viewCubeIcon1 = new devDept.Eyeshot.ViewCubeIcon(devDept.Eyeshot.coordinateSystemPositionType.TopRight, true, System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(60))))), true, "FRONT", "BACK", "LEFT", "RIGHT", "TOP", "BOTTOM", System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), 'S', 'N', 'W', 'E', true, null, System.Drawing.Color.White, System.Drawing.Color.Black, 120, true, true, null, null, null, null, null, null, false, new devDept.Geometry.Quaternion(0D, 0D, 0D, 1D));
            devDept.Eyeshot.Viewport.SavedViewsManager savedViewsManager1 = new devDept.Eyeshot.Viewport.SavedViewsManager(8);
            devDept.Eyeshot.Viewport viewport1 = new devDept.Eyeshot.Viewport(new System.Drawing.Point(0, 0), new System.Drawing.Size(1012, 826), backgroundSettings1, camera1, new devDept.Eyeshot.ToolBar[] {
            toolBar1}, new devDept.Eyeshot.Legend[0], devDept.Eyeshot.displayType.Rendered, true, false, false, false, new devDept.Eyeshot.Grid[] {
            grid1}, new devDept.Eyeshot.OriginSymbol[] {
            originSymbol1}, false, rotateSettings1, zoomSettings1, panSettings1, navigationSettings1, coordinateSystemIcon1, viewCubeIcon1, savedViewsManager1, devDept.Eyeshot.viewType.Trimetric);
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuStrip_file = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_file_open = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_file_import = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_file_export = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_file_save = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_view = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_insert = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_insert_part = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_tools = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_window = new System.Windows.Forms.ToolStripMenuItem();
            this.pbUpperMenuSymbol = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelUpperMenu = new System.Windows.Forms.Panel();
            this.gbRender = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRender_Wireframe1 = new System.Windows.Forms.Button();
            this.btnRender_HiddenWire = new System.Windows.Forms.Button();
            this.btnRender_Wireframe2 = new System.Windows.Forms.Button();
            this.btnRender_ShadeSmooth = new System.Windows.Forms.Button();
            this.btnRender_ShadeEdge = new System.Windows.Forms.Button();
            this.gbDisplay = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDisplay_Grid = new System.Windows.Forms.Button();
            this.btnDisplay_Perpendicular = new System.Windows.Forms.Button();
            this.btnDisplay_Perspective = new System.Windows.Forms.Button();
            this.gbSelection = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelection_Entity = new System.Windows.Forms.Button();
            this.btnSelection_Plane = new System.Windows.Forms.Button();
            this.btnSelection_Line = new System.Windows.Forms.Button();
            this.btnSelection_Point = new System.Windows.Forms.Button();
            this.gbProjection = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Normal = new System.Windows.Forms.Button();
            this.btnProjection_Bottom = new System.Windows.Forms.Button();
            this.btnProjection_Upper = new System.Windows.Forms.Button();
            this.btnProjection_Right = new System.Windows.Forms.Button();
            this.btnProjection_Left = new System.Windows.Forms.Button();
            this.btnProjection_Rear = new System.Windows.Forms.Button();
            this.btnProjection_Front = new System.Windows.Forms.Button();
            this.btnProjection_Isometric = new System.Windows.Forms.Button();
            this.btnSketch_In = new System.Windows.Forms.Button();
            this.panelRightMenu = new System.Windows.Forms.Panel();
            this.gbPart = new System.Windows.Forms.GroupBox();
            this.btnPart_RevolveCut = new System.Windows.Forms.Button();
            this.btnPart_Revolve = new System.Windows.Forms.Button();
            this.SweepCut = new System.Windows.Forms.Button();
            this.btnPart_Sweep = new System.Windows.Forms.Button();
            this.btnPart_Extrude = new System.Windows.Forms.Button();
            this.btnPart_ExtrudeCut = new System.Windows.Forms.Button();
            this.gbSketch = new System.Windows.Forms.GroupBox();
            this.btnSketch_Symmetry = new System.Windows.Forms.Button();
            this.btnSketch_Tangent = new System.Windows.Forms.Button();
            this.btnSketch_Coincidence = new System.Windows.Forms.Button();
            this.btnSketch_Parallel = new System.Windows.Forms.Button();
            this.btnSketch_Perpendicular = new System.Windows.Forms.Button();
            this.btnSketch_Horizontal = new System.Windows.Forms.Button();
            this.btnSketch_Vertical = new System.Windows.Forms.Button();
            this.btnSketch_Dimension = new System.Windows.Forms.Button();
            this.btnSketch_Trim = new System.Windows.Forms.Button();
            this.btnSketch_Slot = new System.Windows.Forms.Button();
            this.btnSketch_DashedLine = new System.Windows.Forms.Button();
            this.btnSketch_Line = new System.Windows.Forms.Button();
            this.btnSketch_Round = new System.Windows.Forms.Button();
            this.btnSketch_RectCenter = new System.Windows.Forms.Button();
            this.btnSketch_Rect = new System.Windows.Forms.Button();
            this.btnSketch_Polygon = new System.Windows.Forms.Button();
            this.btnSketch_Circle = new System.Windows.Forms.Button();
            this.btnSketch_Out = new System.Windows.Forms.Button();
            this.model1 = new devDept.Eyeshot.Model();
            this.panelBottomMenu = new System.Windows.Forms.Panel();
            this.lbMessage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.gbProperty = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnProperty_Material = new System.Windows.Forms.Button();
            this.btnProperty_Measure = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.색상변경ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.파트이동ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dragctrlTitleBar = new CAD_Modeler.DRAG_CONTROL();
            this.panelTitleBar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpperMenuSymbol)).BeginInit();
            this.panelUpperMenu.SuspendLayout();
            this.gbRender.SuspendLayout();
            this.gbDisplay.SuspendLayout();
            this.gbSelection.SuspendLayout();
            this.gbProjection.SuspendLayout();
            this.panelRightMenu.SuspendLayout();
            this.gbPart.SuspendLayout();
            this.gbSketch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).BeginInit();
            this.panelBottomMenu.SuspendLayout();
            this.gbProperty.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.panelTitleBar.Controls.Add(this.menuStrip1);
            this.panelTitleBar.Controls.Add(this.pbUpperMenuSymbol);
            this.panelTitleBar.Controls.Add(this.btnExit);
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1201, 40);
            this.panelTitleBar.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStrip_file,
            this.MenuStrip_edit,
            this.MenuStrip_view,
            this.MenuStrip_insert,
            this.MenuStrip_tools,
            this.MenuStrip_window});
            this.menuStrip1.Location = new System.Drawing.Point(156, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(370, 40);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuStrip_file
            // 
            this.MenuStrip_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStrip_file_open,
            this.MenuStrip_file_import,
            this.MenuStrip_file_export,
            this.MenuStrip_file_save});
            this.MenuStrip_file.Name = "MenuStrip_file";
            this.MenuStrip_file.Size = new System.Drawing.Size(55, 34);
            this.MenuStrip_file.Text = "File";
            // 
            // MenuStrip_file_open
            // 
            this.MenuStrip_file_open.Name = "MenuStrip_file_open";
            this.MenuStrip_file_open.Size = new System.Drawing.Size(169, 34);
            this.MenuStrip_file_open.Text = "Open";
            this.MenuStrip_file_open.Click += new System.EventHandler(this.MenuStrip_file_open_Click);
            // 
            // MenuStrip_file_import
            // 
            this.MenuStrip_file_import.Name = "MenuStrip_file_import";
            this.MenuStrip_file_import.Size = new System.Drawing.Size(169, 34);
            this.MenuStrip_file_import.Text = "Import";
            this.MenuStrip_file_import.Click += new System.EventHandler(this.MenuStrip_file_import_Click);
            // 
            // MenuStrip_file_export
            // 
            this.MenuStrip_file_export.Name = "MenuStrip_file_export";
            this.MenuStrip_file_export.Size = new System.Drawing.Size(169, 34);
            this.MenuStrip_file_export.Text = "Export";
            this.MenuStrip_file_export.Click += new System.EventHandler(this.MenuStrip_file_export_Click);
            // 
            // MenuStrip_file_save
            // 
            this.MenuStrip_file_save.Name = "MenuStrip_file_save";
            this.MenuStrip_file_save.Size = new System.Drawing.Size(169, 34);
            this.MenuStrip_file_save.Text = "Save";
            this.MenuStrip_file_save.Click += new System.EventHandler(this.MenuStrip_file_save_Click);
            // 
            // MenuStrip_edit
            // 
            this.MenuStrip_edit.Name = "MenuStrip_edit";
            this.MenuStrip_edit.Size = new System.Drawing.Size(58, 34);
            this.MenuStrip_edit.Text = "Edit";
            // 
            // MenuStrip_view
            // 
            this.MenuStrip_view.Name = "MenuStrip_view";
            this.MenuStrip_view.Size = new System.Drawing.Size(66, 34);
            this.MenuStrip_view.Text = "View";
            // 
            // MenuStrip_insert
            // 
            this.MenuStrip_insert.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStrip_insert_part});
            this.MenuStrip_insert.Name = "MenuStrip_insert";
            this.MenuStrip_insert.Size = new System.Drawing.Size(73, 34);
            this.MenuStrip_insert.Text = "Insert";
            // 
            // MenuStrip_insert_part
            // 
            this.MenuStrip_insert_part.Name = "MenuStrip_insert_part";
            this.MenuStrip_insert_part.Size = new System.Drawing.Size(145, 34);
            this.MenuStrip_insert_part.Text = "Part";
            this.MenuStrip_insert_part.Click += new System.EventHandler(this.MenuStrip_insert_part_Click);
            // 
            // MenuStrip_tools
            // 
            this.MenuStrip_tools.Name = "MenuStrip_tools";
            this.MenuStrip_tools.Size = new System.Drawing.Size(72, 34);
            this.MenuStrip_tools.Text = "Tools";
            // 
            // MenuStrip_window
            // 
            this.MenuStrip_window.Name = "MenuStrip_window";
            this.MenuStrip_window.Size = new System.Drawing.Size(94, 34);
            this.MenuStrip_window.Text = "Window";
            // 
            // pbUpperMenuSymbol
            // 
            this.pbUpperMenuSymbol.BackColor = System.Drawing.Color.White;
            this.pbUpperMenuSymbol.Image = ((System.Drawing.Image)(resources.GetObject("pbUpperMenuSymbol.Image")));
            this.pbUpperMenuSymbol.Location = new System.Drawing.Point(0, 0);
            this.pbUpperMenuSymbol.Name = "pbUpperMenuSymbol";
            this.pbUpperMenuSymbol.Size = new System.Drawing.Size(156, 40);
            this.pbUpperMenuSymbol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUpperMenuSymbol.TabIndex = 1;
            this.pbUpperMenuSymbol.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1163, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 35);
            this.btnExit.TabIndex = 7;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelUpperMenu
            // 
            this.panelUpperMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelUpperMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.panelUpperMenu.Controls.Add(this.gbRender);
            this.panelUpperMenu.Controls.Add(this.gbDisplay);
            this.panelUpperMenu.Controls.Add(this.gbSelection);
            this.panelUpperMenu.Controls.Add(this.gbProjection);
            this.panelUpperMenu.Location = new System.Drawing.Point(0, 40);
            this.panelUpperMenu.Name = "panelUpperMenu";
            this.panelUpperMenu.Size = new System.Drawing.Size(1201, 40);
            this.panelUpperMenu.TabIndex = 1;
            // 
            // gbRender
            // 
            this.gbRender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbRender.Controls.Add(this.label4);
            this.gbRender.Controls.Add(this.btnRender_Wireframe1);
            this.gbRender.Controls.Add(this.btnRender_HiddenWire);
            this.gbRender.Controls.Add(this.btnRender_Wireframe2);
            this.gbRender.Controls.Add(this.btnRender_ShadeSmooth);
            this.gbRender.Controls.Add(this.btnRender_ShadeEdge);
            this.gbRender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbRender.Location = new System.Drawing.Point(215, -5);
            this.gbRender.Name = "gbRender";
            this.gbRender.Size = new System.Drawing.Size(279, 43);
            this.gbRender.TabIndex = 13;
            this.gbRender.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(5, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Render";
            // 
            // btnRender_Wireframe1
            // 
            this.btnRender_Wireframe1.FlatAppearance.BorderSize = 0;
            this.btnRender_Wireframe1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRender_Wireframe1.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRender_Wireframe1.Image = ((System.Drawing.Image)(resources.GetObject("btnRender_Wireframe1.Image")));
            this.btnRender_Wireframe1.Location = new System.Drawing.Point(190, 12);
            this.btnRender_Wireframe1.Name = "btnRender_Wireframe1";
            this.btnRender_Wireframe1.Size = new System.Drawing.Size(38, 28);
            this.btnRender_Wireframe1.TabIndex = 3;
            this.btnRender_Wireframe1.UseVisualStyleBackColor = true;
            this.btnRender_Wireframe1.Click += new System.EventHandler(this.btnRender_Wireframe1_Click);
            // 
            // btnRender_HiddenWire
            // 
            this.btnRender_HiddenWire.FlatAppearance.BorderSize = 0;
            this.btnRender_HiddenWire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRender_HiddenWire.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRender_HiddenWire.Image = ((System.Drawing.Image)(resources.GetObject("btnRender_HiddenWire.Image")));
            this.btnRender_HiddenWire.Location = new System.Drawing.Point(148, 12);
            this.btnRender_HiddenWire.Name = "btnRender_HiddenWire";
            this.btnRender_HiddenWire.Size = new System.Drawing.Size(38, 28);
            this.btnRender_HiddenWire.TabIndex = 3;
            this.btnRender_HiddenWire.UseVisualStyleBackColor = true;
            this.btnRender_HiddenWire.Click += new System.EventHandler(this.btnRender_HiddenWire_Click);
            // 
            // btnRender_Wireframe2
            // 
            this.btnRender_Wireframe2.FlatAppearance.BorderSize = 0;
            this.btnRender_Wireframe2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRender_Wireframe2.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRender_Wireframe2.Image = ((System.Drawing.Image)(resources.GetObject("btnRender_Wireframe2.Image")));
            this.btnRender_Wireframe2.Location = new System.Drawing.Point(232, 11);
            this.btnRender_Wireframe2.Name = "btnRender_Wireframe2";
            this.btnRender_Wireframe2.Size = new System.Drawing.Size(38, 28);
            this.btnRender_Wireframe2.TabIndex = 3;
            this.btnRender_Wireframe2.UseVisualStyleBackColor = true;
            this.btnRender_Wireframe2.Click += new System.EventHandler(this.btnRender_Wireframe2_Click);
            // 
            // btnRender_ShadeSmooth
            // 
            this.btnRender_ShadeSmooth.FlatAppearance.BorderSize = 0;
            this.btnRender_ShadeSmooth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRender_ShadeSmooth.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRender_ShadeSmooth.Image = ((System.Drawing.Image)(resources.GetObject("btnRender_ShadeSmooth.Image")));
            this.btnRender_ShadeSmooth.Location = new System.Drawing.Point(106, 12);
            this.btnRender_ShadeSmooth.Name = "btnRender_ShadeSmooth";
            this.btnRender_ShadeSmooth.Size = new System.Drawing.Size(38, 28);
            this.btnRender_ShadeSmooth.TabIndex = 2;
            this.btnRender_ShadeSmooth.UseVisualStyleBackColor = true;
            this.btnRender_ShadeSmooth.Click += new System.EventHandler(this.btnRender_ShadeSmooth_Click);
            // 
            // btnRender_ShadeEdge
            // 
            this.btnRender_ShadeEdge.FlatAppearance.BorderSize = 0;
            this.btnRender_ShadeEdge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRender_ShadeEdge.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRender_ShadeEdge.Image = ((System.Drawing.Image)(resources.GetObject("btnRender_ShadeEdge.Image")));
            this.btnRender_ShadeEdge.Location = new System.Drawing.Point(64, 12);
            this.btnRender_ShadeEdge.Name = "btnRender_ShadeEdge";
            this.btnRender_ShadeEdge.Size = new System.Drawing.Size(38, 28);
            this.btnRender_ShadeEdge.TabIndex = 1;
            this.btnRender_ShadeEdge.UseVisualStyleBackColor = true;
            this.btnRender_ShadeEdge.Click += new System.EventHandler(this.btnRender_ShadeEdge_Click);
            // 
            // gbDisplay
            // 
            this.gbDisplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbDisplay.Controls.Add(this.label3);
            this.gbDisplay.Controls.Add(this.btnDisplay_Grid);
            this.gbDisplay.Controls.Add(this.btnDisplay_Perpendicular);
            this.gbDisplay.Controls.Add(this.btnDisplay_Perspective);
            this.gbDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbDisplay.Location = new System.Drawing.Point(7, -5);
            this.gbDisplay.Name = "gbDisplay";
            this.gbDisplay.Size = new System.Drawing.Size(202, 43);
            this.gbDisplay.TabIndex = 13;
            this.gbDisplay.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Display";
            // 
            // btnDisplay_Grid
            // 
            this.btnDisplay_Grid.FlatAppearance.BorderSize = 0;
            this.btnDisplay_Grid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplay_Grid.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDisplay_Grid.Image = ((System.Drawing.Image)(resources.GetObject("btnDisplay_Grid.Image")));
            this.btnDisplay_Grid.Location = new System.Drawing.Point(161, 11);
            this.btnDisplay_Grid.Name = "btnDisplay_Grid";
            this.btnDisplay_Grid.Size = new System.Drawing.Size(38, 28);
            this.btnDisplay_Grid.TabIndex = 3;
            this.btnDisplay_Grid.UseVisualStyleBackColor = true;
            this.btnDisplay_Grid.Click += new System.EventHandler(this.btnDisplay_Grid_Click);
            // 
            // btnDisplay_Perpendicular
            // 
            this.btnDisplay_Perpendicular.FlatAppearance.BorderSize = 0;
            this.btnDisplay_Perpendicular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplay_Perpendicular.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDisplay_Perpendicular.Image = ((System.Drawing.Image)(resources.GetObject("btnDisplay_Perpendicular.Image")));
            this.btnDisplay_Perpendicular.Location = new System.Drawing.Point(117, 12);
            this.btnDisplay_Perpendicular.Name = "btnDisplay_Perpendicular";
            this.btnDisplay_Perpendicular.Size = new System.Drawing.Size(38, 28);
            this.btnDisplay_Perpendicular.TabIndex = 2;
            this.btnDisplay_Perpendicular.UseVisualStyleBackColor = true;
            this.btnDisplay_Perpendicular.Click += new System.EventHandler(this.btnDisplay_Perpendicular_Click);
            // 
            // btnDisplay_Perspective
            // 
            this.btnDisplay_Perspective.FlatAppearance.BorderSize = 0;
            this.btnDisplay_Perspective.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplay_Perspective.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDisplay_Perspective.Image = ((System.Drawing.Image)(resources.GetObject("btnDisplay_Perspective.Image")));
            this.btnDisplay_Perspective.Location = new System.Drawing.Point(73, 12);
            this.btnDisplay_Perspective.Name = "btnDisplay_Perspective";
            this.btnDisplay_Perspective.Size = new System.Drawing.Size(38, 28);
            this.btnDisplay_Perspective.TabIndex = 1;
            this.btnDisplay_Perspective.UseVisualStyleBackColor = true;
            this.btnDisplay_Perspective.Click += new System.EventHandler(this.btnDisplay_Perspective_Click);
            // 
            // gbSelection
            // 
            this.gbSelection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbSelection.Controls.Add(this.label1);
            this.gbSelection.Controls.Add(this.btnSelection_Entity);
            this.gbSelection.Controls.Add(this.btnSelection_Plane);
            this.gbSelection.Controls.Add(this.btnSelection_Line);
            this.gbSelection.Controls.Add(this.btnSelection_Point);
            this.gbSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbSelection.Location = new System.Drawing.Point(942, -5);
            this.gbSelection.Name = "gbSelection";
            this.gbSelection.Size = new System.Drawing.Size(251, 43);
            this.gbSelection.TabIndex = 13;
            this.gbSelection.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selection";
            // 
            // btnSelection_Entity
            // 
            this.btnSelection_Entity.FlatAppearance.BorderSize = 0;
            this.btnSelection_Entity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelection_Entity.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSelection_Entity.Image = ((System.Drawing.Image)(resources.GetObject("btnSelection_Entity.Image")));
            this.btnSelection_Entity.Location = new System.Drawing.Point(205, 12);
            this.btnSelection_Entity.Name = "btnSelection_Entity";
            this.btnSelection_Entity.Size = new System.Drawing.Size(38, 28);
            this.btnSelection_Entity.TabIndex = 3;
            this.btnSelection_Entity.UseVisualStyleBackColor = true;
            this.btnSelection_Entity.Click += new System.EventHandler(this.btnSelection_Entity_Click);
            // 
            // btnSelection_Plane
            // 
            this.btnSelection_Plane.FlatAppearance.BorderSize = 0;
            this.btnSelection_Plane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelection_Plane.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSelection_Plane.Image = ((System.Drawing.Image)(resources.GetObject("btnSelection_Plane.Image")));
            this.btnSelection_Plane.Location = new System.Drawing.Point(161, 12);
            this.btnSelection_Plane.Name = "btnSelection_Plane";
            this.btnSelection_Plane.Size = new System.Drawing.Size(38, 28);
            this.btnSelection_Plane.TabIndex = 2;
            this.btnSelection_Plane.UseVisualStyleBackColor = true;
            this.btnSelection_Plane.Click += new System.EventHandler(this.btnSelection_Plane_Click);
            // 
            // btnSelection_Line
            // 
            this.btnSelection_Line.FlatAppearance.BorderSize = 0;
            this.btnSelection_Line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelection_Line.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSelection_Line.Image = ((System.Drawing.Image)(resources.GetObject("btnSelection_Line.Image")));
            this.btnSelection_Line.Location = new System.Drawing.Point(117, 12);
            this.btnSelection_Line.Name = "btnSelection_Line";
            this.btnSelection_Line.Size = new System.Drawing.Size(38, 28);
            this.btnSelection_Line.TabIndex = 1;
            this.btnSelection_Line.UseVisualStyleBackColor = true;
            this.btnSelection_Line.Click += new System.EventHandler(this.btnSelection_Line_Click);
            // 
            // btnSelection_Point
            // 
            this.btnSelection_Point.FlatAppearance.BorderSize = 0;
            this.btnSelection_Point.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelection_Point.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSelection_Point.Image = ((System.Drawing.Image)(resources.GetObject("btnSelection_Point.Image")));
            this.btnSelection_Point.Location = new System.Drawing.Point(73, 12);
            this.btnSelection_Point.Name = "btnSelection_Point";
            this.btnSelection_Point.Size = new System.Drawing.Size(38, 28);
            this.btnSelection_Point.TabIndex = 0;
            this.btnSelection_Point.UseVisualStyleBackColor = true;
            this.btnSelection_Point.Click += new System.EventHandler(this.btnSelection_Point_Click);
            // 
            // gbProjection
            // 
            this.gbProjection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbProjection.Controls.Add(this.label2);
            this.gbProjection.Controls.Add(this.Normal);
            this.gbProjection.Controls.Add(this.btnProjection_Bottom);
            this.gbProjection.Controls.Add(this.btnProjection_Upper);
            this.gbProjection.Controls.Add(this.btnProjection_Right);
            this.gbProjection.Controls.Add(this.btnProjection_Left);
            this.gbProjection.Controls.Add(this.btnProjection_Rear);
            this.gbProjection.Controls.Add(this.btnProjection_Front);
            this.gbProjection.Controls.Add(this.btnProjection_Isometric);
            this.gbProjection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbProjection.Location = new System.Drawing.Point(501, -5);
            this.gbProjection.Name = "gbProjection";
            this.gbProjection.Size = new System.Drawing.Size(432, 43);
            this.gbProjection.TabIndex = 12;
            this.gbProjection.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Projection";
            // 
            // Normal
            // 
            this.Normal.FlatAppearance.BorderSize = 0;
            this.Normal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Normal.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Normal.Image = ((System.Drawing.Image)(resources.GetObject("Normal.Image")));
            this.Normal.Location = new System.Drawing.Point(386, 12);
            this.Normal.Name = "Normal";
            this.Normal.Size = new System.Drawing.Size(38, 28);
            this.Normal.TabIndex = 4;
            this.Normal.UseVisualStyleBackColor = true;
            this.Normal.Click += new System.EventHandler(this.Normal_Click);
            // 
            // btnProjection_Bottom
            // 
            this.btnProjection_Bottom.FlatAppearance.BorderSize = 0;
            this.btnProjection_Bottom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjection_Bottom.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProjection_Bottom.Image = ((System.Drawing.Image)(resources.GetObject("btnProjection_Bottom.Image")));
            this.btnProjection_Bottom.Location = new System.Drawing.Point(347, 12);
            this.btnProjection_Bottom.Name = "btnProjection_Bottom";
            this.btnProjection_Bottom.Size = new System.Drawing.Size(38, 28);
            this.btnProjection_Bottom.TabIndex = 3;
            this.btnProjection_Bottom.UseVisualStyleBackColor = true;
            this.btnProjection_Bottom.Click += new System.EventHandler(this.btnProjection_Bottom_Click);
            // 
            // btnProjection_Upper
            // 
            this.btnProjection_Upper.FlatAppearance.BorderSize = 0;
            this.btnProjection_Upper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjection_Upper.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProjection_Upper.Image = ((System.Drawing.Image)(resources.GetObject("btnProjection_Upper.Image")));
            this.btnProjection_Upper.Location = new System.Drawing.Point(303, 12);
            this.btnProjection_Upper.Name = "btnProjection_Upper";
            this.btnProjection_Upper.Size = new System.Drawing.Size(38, 28);
            this.btnProjection_Upper.TabIndex = 3;
            this.btnProjection_Upper.UseVisualStyleBackColor = true;
            this.btnProjection_Upper.Click += new System.EventHandler(this.btnProjection_Upper_Click);
            // 
            // btnProjection_Right
            // 
            this.btnProjection_Right.FlatAppearance.BorderSize = 0;
            this.btnProjection_Right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjection_Right.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProjection_Right.Image = ((System.Drawing.Image)(resources.GetObject("btnProjection_Right.Image")));
            this.btnProjection_Right.Location = new System.Drawing.Point(259, 12);
            this.btnProjection_Right.Name = "btnProjection_Right";
            this.btnProjection_Right.Size = new System.Drawing.Size(38, 28);
            this.btnProjection_Right.TabIndex = 3;
            this.btnProjection_Right.UseVisualStyleBackColor = true;
            this.btnProjection_Right.Click += new System.EventHandler(this.btnProjection_Right_Click);
            // 
            // btnProjection_Left
            // 
            this.btnProjection_Left.FlatAppearance.BorderSize = 0;
            this.btnProjection_Left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjection_Left.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProjection_Left.Image = ((System.Drawing.Image)(resources.GetObject("btnProjection_Left.Image")));
            this.btnProjection_Left.Location = new System.Drawing.Point(215, 12);
            this.btnProjection_Left.Name = "btnProjection_Left";
            this.btnProjection_Left.Size = new System.Drawing.Size(38, 28);
            this.btnProjection_Left.TabIndex = 3;
            this.btnProjection_Left.UseVisualStyleBackColor = true;
            this.btnProjection_Left.Click += new System.EventHandler(this.btnProjection_Left_Click);
            // 
            // btnProjection_Rear
            // 
            this.btnProjection_Rear.FlatAppearance.BorderSize = 0;
            this.btnProjection_Rear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjection_Rear.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProjection_Rear.Image = ((System.Drawing.Image)(resources.GetObject("btnProjection_Rear.Image")));
            this.btnProjection_Rear.Location = new System.Drawing.Point(171, 12);
            this.btnProjection_Rear.Name = "btnProjection_Rear";
            this.btnProjection_Rear.Size = new System.Drawing.Size(38, 28);
            this.btnProjection_Rear.TabIndex = 2;
            this.btnProjection_Rear.UseVisualStyleBackColor = true;
            this.btnProjection_Rear.Click += new System.EventHandler(this.btnProjection_Rear_Click);
            // 
            // btnProjection_Front
            // 
            this.btnProjection_Front.FlatAppearance.BorderSize = 0;
            this.btnProjection_Front.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjection_Front.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProjection_Front.Image = ((System.Drawing.Image)(resources.GetObject("btnProjection_Front.Image")));
            this.btnProjection_Front.Location = new System.Drawing.Point(127, 12);
            this.btnProjection_Front.Name = "btnProjection_Front";
            this.btnProjection_Front.Size = new System.Drawing.Size(38, 28);
            this.btnProjection_Front.TabIndex = 1;
            this.btnProjection_Front.UseVisualStyleBackColor = true;
            this.btnProjection_Front.Click += new System.EventHandler(this.btnProjection_Front_Click);
            // 
            // btnProjection_Isometric
            // 
            this.btnProjection_Isometric.FlatAppearance.BorderSize = 0;
            this.btnProjection_Isometric.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjection_Isometric.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProjection_Isometric.Image = ((System.Drawing.Image)(resources.GetObject("btnProjection_Isometric.Image")));
            this.btnProjection_Isometric.Location = new System.Drawing.Point(83, 12);
            this.btnProjection_Isometric.Name = "btnProjection_Isometric";
            this.btnProjection_Isometric.Size = new System.Drawing.Size(38, 28);
            this.btnProjection_Isometric.TabIndex = 0;
            this.btnProjection_Isometric.UseVisualStyleBackColor = true;
            this.btnProjection_Isometric.Click += new System.EventHandler(this.btnProjection_Isometric_Click);
            // 
            // btnSketch_In
            // 
            this.btnSketch_In.FlatAppearance.BorderSize = 0;
            this.btnSketch_In.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSketch_In.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSketch_In.ForeColor = System.Drawing.Color.White;
            this.btnSketch_In.Image = ((System.Drawing.Image)(resources.GetObject("btnSketch_In.Image")));
            this.btnSketch_In.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSketch_In.Location = new System.Drawing.Point(4, 24);
            this.btnSketch_In.Name = "btnSketch_In";
            this.btnSketch_In.Size = new System.Drawing.Size(162, 39);
            this.btnSketch_In.TabIndex = 11;
            this.btnSketch_In.Text = "  Sketch In";
            this.btnSketch_In.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSketch_In.UseVisualStyleBackColor = true;
            this.btnSketch_In.Click += new System.EventHandler(this.btnSketch_In_Click);
            // 
            // panelRightMenu
            // 
            this.panelRightMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelRightMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.panelRightMenu.Controls.Add(this.gbPart);
            this.panelRightMenu.Controls.Add(this.gbSketch);
            this.panelRightMenu.Location = new System.Drawing.Point(1010, 79);
            this.panelRightMenu.Name = "panelRightMenu";
            this.panelRightMenu.Size = new System.Drawing.Size(191, 871);
            this.panelRightMenu.TabIndex = 2;
            // 
            // gbPart
            // 
            this.gbPart.Controls.Add(this.btnPart_RevolveCut);
            this.gbPart.Controls.Add(this.btnPart_Revolve);
            this.gbPart.Controls.Add(this.SweepCut);
            this.gbPart.Controls.Add(this.btnPart_Sweep);
            this.gbPart.Controls.Add(this.btnPart_Extrude);
            this.gbPart.Controls.Add(this.btnPart_ExtrudeCut);
            this.gbPart.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbPart.ForeColor = System.Drawing.Color.White;
            this.gbPart.Location = new System.Drawing.Point(11, 568);
            this.gbPart.Name = "gbPart";
            this.gbPart.Size = new System.Drawing.Size(172, 300);
            this.gbPart.TabIndex = 0;
            this.gbPart.TabStop = false;
            this.gbPart.Text = "Part";
            // 
            // btnPart_RevolveCut
            // 
            this.btnPart_RevolveCut.FlatAppearance.BorderSize = 0;
            this.btnPart_RevolveCut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPart_RevolveCut.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPart_RevolveCut.ForeColor = System.Drawing.Color.White;
            this.btnPart_RevolveCut.Image = ((System.Drawing.Image)(resources.GetObject("btnPart_RevolveCut.Image")));
            this.btnPart_RevolveCut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPart_RevolveCut.Location = new System.Drawing.Point(6, 156);
            this.btnPart_RevolveCut.Name = "btnPart_RevolveCut";
            this.btnPart_RevolveCut.Size = new System.Drawing.Size(162, 39);
            this.btnPart_RevolveCut.TabIndex = 11;
            this.btnPart_RevolveCut.Text = "  Revolve Cut";
            this.btnPart_RevolveCut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPart_RevolveCut.UseVisualStyleBackColor = true;
            this.btnPart_RevolveCut.Click += new System.EventHandler(this.btnPart_RevolveCut_Click);
            // 
            // btnPart_Revolve
            // 
            this.btnPart_Revolve.FlatAppearance.BorderSize = 0;
            this.btnPart_Revolve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPart_Revolve.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPart_Revolve.ForeColor = System.Drawing.Color.White;
            this.btnPart_Revolve.Image = ((System.Drawing.Image)(resources.GetObject("btnPart_Revolve.Image")));
            this.btnPart_Revolve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPart_Revolve.Location = new System.Drawing.Point(6, 112);
            this.btnPart_Revolve.Name = "btnPart_Revolve";
            this.btnPart_Revolve.Size = new System.Drawing.Size(162, 39);
            this.btnPart_Revolve.TabIndex = 11;
            this.btnPart_Revolve.Text = "  Revolve";
            this.btnPart_Revolve.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPart_Revolve.UseVisualStyleBackColor = true;
            this.btnPart_Revolve.Click += new System.EventHandler(this.btnPart_Revolve_Click);
            // 
            // SweepCut
            // 
            this.SweepCut.FlatAppearance.BorderSize = 0;
            this.SweepCut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SweepCut.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SweepCut.ForeColor = System.Drawing.Color.White;
            this.SweepCut.Image = ((System.Drawing.Image)(resources.GetObject("SweepCut.Image")));
            this.SweepCut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SweepCut.Location = new System.Drawing.Point(6, 245);
            this.SweepCut.Name = "SweepCut";
            this.SweepCut.Size = new System.Drawing.Size(162, 39);
            this.SweepCut.TabIndex = 11;
            this.SweepCut.Text = "  Sweep";
            this.SweepCut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SweepCut.UseVisualStyleBackColor = true;
            this.SweepCut.Click += new System.EventHandler(this.SweepCut_Click);
            // 
            // btnPart_Sweep
            // 
            this.btnPart_Sweep.FlatAppearance.BorderSize = 0;
            this.btnPart_Sweep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPart_Sweep.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPart_Sweep.ForeColor = System.Drawing.Color.White;
            this.btnPart_Sweep.Image = ((System.Drawing.Image)(resources.GetObject("btnPart_Sweep.Image")));
            this.btnPart_Sweep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPart_Sweep.Location = new System.Drawing.Point(6, 200);
            this.btnPart_Sweep.Name = "btnPart_Sweep";
            this.btnPart_Sweep.Size = new System.Drawing.Size(162, 39);
            this.btnPart_Sweep.TabIndex = 11;
            this.btnPart_Sweep.Text = "  Sweep";
            this.btnPart_Sweep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPart_Sweep.UseVisualStyleBackColor = true;
            this.btnPart_Sweep.Click += new System.EventHandler(this.btnPart_Sweep_Click);
            // 
            // btnPart_Extrude
            // 
            this.btnPart_Extrude.FlatAppearance.BorderSize = 0;
            this.btnPart_Extrude.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPart_Extrude.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPart_Extrude.ForeColor = System.Drawing.Color.White;
            this.btnPart_Extrude.Image = ((System.Drawing.Image)(resources.GetObject("btnPart_Extrude.Image")));
            this.btnPart_Extrude.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPart_Extrude.Location = new System.Drawing.Point(6, 24);
            this.btnPart_Extrude.Name = "btnPart_Extrude";
            this.btnPart_Extrude.Size = new System.Drawing.Size(162, 39);
            this.btnPart_Extrude.TabIndex = 11;
            this.btnPart_Extrude.Text = "  Extrude";
            this.btnPart_Extrude.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPart_Extrude.UseVisualStyleBackColor = true;
            this.btnPart_Extrude.Click += new System.EventHandler(this.btnPart_Extrude_Click);
            // 
            // btnPart_ExtrudeCut
            // 
            this.btnPart_ExtrudeCut.FlatAppearance.BorderSize = 0;
            this.btnPart_ExtrudeCut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPart_ExtrudeCut.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPart_ExtrudeCut.ForeColor = System.Drawing.Color.White;
            this.btnPart_ExtrudeCut.Image = ((System.Drawing.Image)(resources.GetObject("btnPart_ExtrudeCut.Image")));
            this.btnPart_ExtrudeCut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPart_ExtrudeCut.Location = new System.Drawing.Point(6, 68);
            this.btnPart_ExtrudeCut.Name = "btnPart_ExtrudeCut";
            this.btnPart_ExtrudeCut.Size = new System.Drawing.Size(162, 39);
            this.btnPart_ExtrudeCut.TabIndex = 11;
            this.btnPart_ExtrudeCut.Text = "  Extrude Cut";
            this.btnPart_ExtrudeCut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPart_ExtrudeCut.UseVisualStyleBackColor = true;
            this.btnPart_ExtrudeCut.Click += new System.EventHandler(this.btnPart_ExtrudeCut_Click);
            // 
            // gbSketch
            // 
            this.gbSketch.Controls.Add(this.btnSketch_Symmetry);
            this.gbSketch.Controls.Add(this.btnSketch_Tangent);
            this.gbSketch.Controls.Add(this.btnSketch_Coincidence);
            this.gbSketch.Controls.Add(this.btnSketch_Parallel);
            this.gbSketch.Controls.Add(this.btnSketch_Perpendicular);
            this.gbSketch.Controls.Add(this.btnSketch_Horizontal);
            this.gbSketch.Controls.Add(this.btnSketch_Vertical);
            this.gbSketch.Controls.Add(this.btnSketch_Dimension);
            this.gbSketch.Controls.Add(this.btnSketch_Trim);
            this.gbSketch.Controls.Add(this.btnSketch_Slot);
            this.gbSketch.Controls.Add(this.btnSketch_DashedLine);
            this.gbSketch.Controls.Add(this.btnSketch_Line);
            this.gbSketch.Controls.Add(this.btnSketch_Round);
            this.gbSketch.Controls.Add(this.btnSketch_RectCenter);
            this.gbSketch.Controls.Add(this.btnSketch_Rect);
            this.gbSketch.Controls.Add(this.btnSketch_Polygon);
            this.gbSketch.Controls.Add(this.btnSketch_Circle);
            this.gbSketch.Controls.Add(this.btnSketch_Out);
            this.gbSketch.Controls.Add(this.btnSketch_In);
            this.gbSketch.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbSketch.ForeColor = System.Drawing.Color.White;
            this.gbSketch.Location = new System.Drawing.Point(10, 7);
            this.gbSketch.Name = "gbSketch";
            this.gbSketch.Size = new System.Drawing.Size(172, 553);
            this.gbSketch.TabIndex = 0;
            this.gbSketch.TabStop = false;
            this.gbSketch.Text = "Sketch";
            // 
            // btnSketch_Symmetry
            // 
            this.btnSketch_Symmetry.FlatAppearance.BorderSize = 0;
            this.btnSketch_Symmetry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSketch_Symmetry.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSketch_Symmetry.ForeColor = System.Drawing.Color.White;
            this.btnSketch_Symmetry.Image = ((System.Drawing.Image)(resources.GetObject("btnSketch_Symmetry.Image")));
            this.btnSketch_Symmetry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSketch_Symmetry.Location = new System.Drawing.Point(4, 495);
            this.btnSketch_Symmetry.Name = "btnSketch_Symmetry";
            this.btnSketch_Symmetry.Size = new System.Drawing.Size(80, 39);
            this.btnSketch_Symmetry.TabIndex = 12;
            this.btnSketch_Symmetry.Text = " 대칭";
            this.btnSketch_Symmetry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSketch_Symmetry.UseVisualStyleBackColor = true;
            this.btnSketch_Symmetry.Click += new System.EventHandler(this.btnSketch_Symmetry_Click);
            // 
            // btnSketch_Tangent
            // 
            this.btnSketch_Tangent.FlatAppearance.BorderSize = 0;
            this.btnSketch_Tangent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSketch_Tangent.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSketch_Tangent.ForeColor = System.Drawing.Color.White;
            this.btnSketch_Tangent.Image = ((System.Drawing.Image)(resources.GetObject("btnSketch_Tangent.Image")));
            this.btnSketch_Tangent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSketch_Tangent.Location = new System.Drawing.Point(4, 450);
            this.btnSketch_Tangent.Name = "btnSketch_Tangent";
            this.btnSketch_Tangent.Size = new System.Drawing.Size(80, 39);
            this.btnSketch_Tangent.TabIndex = 12;
            this.btnSketch_Tangent.Text = " 접선";
            this.btnSketch_Tangent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSketch_Tangent.UseVisualStyleBackColor = true;
            this.btnSketch_Tangent.Click += new System.EventHandler(this.btnSketch_Tangent_Click);
            // 
            // btnSketch_Coincidence
            // 
            this.btnSketch_Coincidence.FlatAppearance.BorderSize = 0;
            this.btnSketch_Coincidence.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSketch_Coincidence.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSketch_Coincidence.ForeColor = System.Drawing.Color.White;
            this.btnSketch_Coincidence.Image = ((System.Drawing.Image)(resources.GetObject("btnSketch_Coincidence.Image")));
            this.btnSketch_Coincidence.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSketch_Coincidence.Location = new System.Drawing.Point(89, 450);
            this.btnSketch_Coincidence.Name = "btnSketch_Coincidence";
            this.btnSketch_Coincidence.Size = new System.Drawing.Size(80, 39);
            this.btnSketch_Coincidence.TabIndex = 12;
            this.btnSketch_Coincidence.Text = " 일치";
            this.btnSketch_Coincidence.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSketch_Coincidence.UseVisualStyleBackColor = true;
            this.btnSketch_Coincidence.Click += new System.EventHandler(this.btnSketch_Coincidence_Click);
            // 
            // btnSketch_Parallel
            // 
            this.btnSketch_Parallel.FlatAppearance.BorderSize = 0;
            this.btnSketch_Parallel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSketch_Parallel.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSketch_Parallel.ForeColor = System.Drawing.Color.White;
            this.btnSketch_Parallel.Image = ((System.Drawing.Image)(resources.GetObject("btnSketch_Parallel.Image")));
            this.btnSketch_Parallel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSketch_Parallel.Location = new System.Drawing.Point(89, 409);
            this.btnSketch_Parallel.Name = "btnSketch_Parallel";
            this.btnSketch_Parallel.Size = new System.Drawing.Size(80, 39);
            this.btnSketch_Parallel.TabIndex = 12;
            this.btnSketch_Parallel.Text = " 평행";
            this.btnSketch_Parallel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSketch_Parallel.UseVisualStyleBackColor = true;
            this.btnSketch_Parallel.Click += new System.EventHandler(this.btnSketch_Parallel_Click);
            // 
            // btnSketch_Perpendicular
            // 
            this.btnSketch_Perpendicular.FlatAppearance.BorderSize = 0;
            this.btnSketch_Perpendicular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSketch_Perpendicular.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSketch_Perpendicular.ForeColor = System.Drawing.Color.White;
            this.btnSketch_Perpendicular.Image = ((System.Drawing.Image)(resources.GetObject("btnSketch_Perpendicular.Image")));
            this.btnSketch_Perpendicular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSketch_Perpendicular.Location = new System.Drawing.Point(4, 409);
            this.btnSketch_Perpendicular.Name = "btnSketch_Perpendicular";
            this.btnSketch_Perpendicular.Size = new System.Drawing.Size(80, 39);
            this.btnSketch_Perpendicular.TabIndex = 12;
            this.btnSketch_Perpendicular.Text = " 직교";
            this.btnSketch_Perpendicular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSketch_Perpendicular.UseVisualStyleBackColor = true;
            this.btnSketch_Perpendicular.Click += new System.EventHandler(this.btnSketch_Perpendicular_Click);
            // 
            // btnSketch_Horizontal
            // 
            this.btnSketch_Horizontal.FlatAppearance.BorderSize = 0;
            this.btnSketch_Horizontal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSketch_Horizontal.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSketch_Horizontal.ForeColor = System.Drawing.Color.White;
            this.btnSketch_Horizontal.Image = ((System.Drawing.Image)(resources.GetObject("btnSketch_Horizontal.Image")));
            this.btnSketch_Horizontal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSketch_Horizontal.Location = new System.Drawing.Point(89, 368);
            this.btnSketch_Horizontal.Name = "btnSketch_Horizontal";
            this.btnSketch_Horizontal.Size = new System.Drawing.Size(80, 39);
            this.btnSketch_Horizontal.TabIndex = 12;
            this.btnSketch_Horizontal.Text = " 수평";
            this.btnSketch_Horizontal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSketch_Horizontal.UseVisualStyleBackColor = true;
            this.btnSketch_Horizontal.Click += new System.EventHandler(this.btnSketch_Horizontal_Click);
            // 
            // btnSketch_Vertical
            // 
            this.btnSketch_Vertical.FlatAppearance.BorderSize = 0;
            this.btnSketch_Vertical.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSketch_Vertical.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSketch_Vertical.ForeColor = System.Drawing.Color.White;
            this.btnSketch_Vertical.Image = ((System.Drawing.Image)(resources.GetObject("btnSketch_Vertical.Image")));
            this.btnSketch_Vertical.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSketch_Vertical.Location = new System.Drawing.Point(4, 368);
            this.btnSketch_Vertical.Name = "btnSketch_Vertical";
            this.btnSketch_Vertical.Size = new System.Drawing.Size(80, 39);
            this.btnSketch_Vertical.TabIndex = 12;
            this.btnSketch_Vertical.Text = " 수직";
            this.btnSketch_Vertical.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSketch_Vertical.UseVisualStyleBackColor = true;
            this.btnSketch_Vertical.Click += new System.EventHandler(this.btnSketch_Vertical_Click);
            // 
            // btnSketch_Dimension
            // 
            this.btnSketch_Dimension.FlatAppearance.BorderSize = 0;
            this.btnSketch_Dimension.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSketch_Dimension.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSketch_Dimension.ForeColor = System.Drawing.Color.White;
            this.btnSketch_Dimension.Image = ((System.Drawing.Image)(resources.GetObject("btnSketch_Dimension.Image")));
            this.btnSketch_Dimension.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSketch_Dimension.Location = new System.Drawing.Point(4, 278);
            this.btnSketch_Dimension.Name = "btnSketch_Dimension";
            this.btnSketch_Dimension.Size = new System.Drawing.Size(162, 39);
            this.btnSketch_Dimension.TabIndex = 11;
            this.btnSketch_Dimension.Text = "  Dimension";
            this.btnSketch_Dimension.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSketch_Dimension.UseVisualStyleBackColor = true;
            this.btnSketch_Dimension.Click += new System.EventHandler(this.btnSketch_Dimension_Click);
            // 
            // btnSketch_Trim
            // 
            this.btnSketch_Trim.FlatAppearance.BorderSize = 0;
            this.btnSketch_Trim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSketch_Trim.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSketch_Trim.ForeColor = System.Drawing.Color.White;
            this.btnSketch_Trim.Image = ((System.Drawing.Image)(resources.GetObject("btnSketch_Trim.Image")));
            this.btnSketch_Trim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSketch_Trim.Location = new System.Drawing.Point(4, 323);
            this.btnSketch_Trim.Name = "btnSketch_Trim";
            this.btnSketch_Trim.Size = new System.Drawing.Size(162, 39);
            this.btnSketch_Trim.TabIndex = 11;
            this.btnSketch_Trim.Text = "   Trim";
            this.btnSketch_Trim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSketch_Trim.UseVisualStyleBackColor = true;
            this.btnSketch_Trim.Click += new System.EventHandler(this.btnSketch_Trim_Click);
            // 
            // btnSketch_Slot
            // 
            this.btnSketch_Slot.FlatAppearance.BorderSize = 0;
            this.btnSketch_Slot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSketch_Slot.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSketch_Slot.ForeColor = System.Drawing.Color.White;
            this.btnSketch_Slot.Image = ((System.Drawing.Image)(resources.GetObject("btnSketch_Slot.Image")));
            this.btnSketch_Slot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSketch_Slot.Location = new System.Drawing.Point(97, 106);
            this.btnSketch_Slot.Name = "btnSketch_Slot";
            this.btnSketch_Slot.Size = new System.Drawing.Size(40, 39);
            this.btnSketch_Slot.TabIndex = 11;
            this.btnSketch_Slot.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSketch_Slot.UseVisualStyleBackColor = true;
            this.btnSketch_Slot.Click += new System.EventHandler(this.btnSketch_Slot_Click);
            // 
            // btnSketch_DashedLine
            // 
            this.btnSketch_DashedLine.FlatAppearance.BorderSize = 0;
            this.btnSketch_DashedLine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSketch_DashedLine.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSketch_DashedLine.ForeColor = System.Drawing.Color.White;
            this.btnSketch_DashedLine.Image = ((System.Drawing.Image)(resources.GetObject("btnSketch_DashedLine.Image")));
            this.btnSketch_DashedLine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSketch_DashedLine.Location = new System.Drawing.Point(51, 106);
            this.btnSketch_DashedLine.Name = "btnSketch_DashedLine";
            this.btnSketch_DashedLine.Size = new System.Drawing.Size(40, 39);
            this.btnSketch_DashedLine.TabIndex = 11;
            this.btnSketch_DashedLine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSketch_DashedLine.UseVisualStyleBackColor = true;
            this.btnSketch_DashedLine.Click += new System.EventHandler(this.btnSketch_DashedLine_Click);
            // 
            // btnSketch_Line
            // 
            this.btnSketch_Line.FlatAppearance.BorderSize = 0;
            this.btnSketch_Line.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSketch_Line.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSketch_Line.ForeColor = System.Drawing.Color.White;
            this.btnSketch_Line.Image = ((System.Drawing.Image)(resources.GetObject("btnSketch_Line.Image")));
            this.btnSketch_Line.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSketch_Line.Location = new System.Drawing.Point(4, 106);
            this.btnSketch_Line.Name = "btnSketch_Line";
            this.btnSketch_Line.Size = new System.Drawing.Size(40, 39);
            this.btnSketch_Line.TabIndex = 11;
            this.btnSketch_Line.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSketch_Line.UseVisualStyleBackColor = true;
            this.btnSketch_Line.Click += new System.EventHandler(this.btnSketch_Line_Click);
            // 
            // btnSketch_Round
            // 
            this.btnSketch_Round.FlatAppearance.BorderSize = 0;
            this.btnSketch_Round.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSketch_Round.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSketch_Round.ForeColor = System.Drawing.Color.White;
            this.btnSketch_Round.Image = ((System.Drawing.Image)(resources.GetObject("btnSketch_Round.Image")));
            this.btnSketch_Round.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSketch_Round.Location = new System.Drawing.Point(4, 233);
            this.btnSketch_Round.Name = "btnSketch_Round";
            this.btnSketch_Round.Size = new System.Drawing.Size(162, 39);
            this.btnSketch_Round.TabIndex = 11;
            this.btnSketch_Round.Text = "  Round";
            this.btnSketch_Round.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSketch_Round.UseVisualStyleBackColor = true;
            this.btnSketch_Round.Click += new System.EventHandler(this.btnSketch_Round_Click);
            // 
            // btnSketch_RectCenter
            // 
            this.btnSketch_RectCenter.FlatAppearance.BorderSize = 0;
            this.btnSketch_RectCenter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSketch_RectCenter.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSketch_RectCenter.ForeColor = System.Drawing.Color.White;
            this.btnSketch_RectCenter.Image = ((System.Drawing.Image)(resources.GetObject("btnSketch_RectCenter.Image")));
            this.btnSketch_RectCenter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSketch_RectCenter.Location = new System.Drawing.Point(4, 147);
            this.btnSketch_RectCenter.Name = "btnSketch_RectCenter";
            this.btnSketch_RectCenter.Size = new System.Drawing.Size(40, 39);
            this.btnSketch_RectCenter.TabIndex = 11;
            this.btnSketch_RectCenter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSketch_RectCenter.UseVisualStyleBackColor = true;
            this.btnSketch_RectCenter.Click += new System.EventHandler(this.btnSketch_RectCenter_Click);
            // 
            // btnSketch_Rect
            // 
            this.btnSketch_Rect.FlatAppearance.BorderSize = 0;
            this.btnSketch_Rect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSketch_Rect.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSketch_Rect.ForeColor = System.Drawing.Color.White;
            this.btnSketch_Rect.Image = ((System.Drawing.Image)(resources.GetObject("btnSketch_Rect.Image")));
            this.btnSketch_Rect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSketch_Rect.Location = new System.Drawing.Point(51, 147);
            this.btnSketch_Rect.Name = "btnSketch_Rect";
            this.btnSketch_Rect.Size = new System.Drawing.Size(40, 39);
            this.btnSketch_Rect.TabIndex = 11;
            this.btnSketch_Rect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSketch_Rect.UseVisualStyleBackColor = true;
            this.btnSketch_Rect.Click += new System.EventHandler(this.btnSketch_Rect_Click);
            // 
            // btnSketch_Polygon
            // 
            this.btnSketch_Polygon.FlatAppearance.BorderSize = 0;
            this.btnSketch_Polygon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSketch_Polygon.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSketch_Polygon.ForeColor = System.Drawing.Color.White;
            this.btnSketch_Polygon.Image = ((System.Drawing.Image)(resources.GetObject("btnSketch_Polygon.Image")));
            this.btnSketch_Polygon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSketch_Polygon.Location = new System.Drawing.Point(51, 188);
            this.btnSketch_Polygon.Name = "btnSketch_Polygon";
            this.btnSketch_Polygon.Size = new System.Drawing.Size(40, 39);
            this.btnSketch_Polygon.TabIndex = 11;
            this.btnSketch_Polygon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSketch_Polygon.UseVisualStyleBackColor = true;
            this.btnSketch_Polygon.Click += new System.EventHandler(this.btnSketch_Polygon_Click);
            // 
            // btnSketch_Circle
            // 
            this.btnSketch_Circle.FlatAppearance.BorderSize = 0;
            this.btnSketch_Circle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSketch_Circle.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSketch_Circle.ForeColor = System.Drawing.Color.White;
            this.btnSketch_Circle.Image = ((System.Drawing.Image)(resources.GetObject("btnSketch_Circle.Image")));
            this.btnSketch_Circle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSketch_Circle.Location = new System.Drawing.Point(4, 188);
            this.btnSketch_Circle.Name = "btnSketch_Circle";
            this.btnSketch_Circle.Size = new System.Drawing.Size(40, 39);
            this.btnSketch_Circle.TabIndex = 11;
            this.btnSketch_Circle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSketch_Circle.UseVisualStyleBackColor = true;
            this.btnSketch_Circle.Click += new System.EventHandler(this.btnSketch_Circle_Click);
            // 
            // btnSketch_Out
            // 
            this.btnSketch_Out.FlatAppearance.BorderSize = 0;
            this.btnSketch_Out.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSketch_Out.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSketch_Out.ForeColor = System.Drawing.Color.White;
            this.btnSketch_Out.Image = ((System.Drawing.Image)(resources.GetObject("btnSketch_Out.Image")));
            this.btnSketch_Out.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSketch_Out.Location = new System.Drawing.Point(4, 65);
            this.btnSketch_Out.Name = "btnSketch_Out";
            this.btnSketch_Out.Size = new System.Drawing.Size(162, 39);
            this.btnSketch_Out.TabIndex = 11;
            this.btnSketch_Out.Text = "  Sketch Out";
            this.btnSketch_Out.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSketch_Out.UseVisualStyleBackColor = true;
            this.btnSketch_Out.Click += new System.EventHandler(this.btnSketch_Out_Click);
            // 
            // model1
            // 
            this.model1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.model1.Cursor = System.Windows.Forms.Cursors.Default;
            this.model1.Flat = displayModeSettingsFlat1;
            this.model1.Location = new System.Drawing.Point(-1, 79);
            this.model1.Name = "model1";
            this.model1.ProgressBar = progressBar1;
            this.model1.Rendered = displayModeSettingsRendered1;
            this.model1.Size = new System.Drawing.Size(1012, 826);
            this.model1.TabIndex = 3;
            this.model1.Text = "model1";
            this.model1.Viewports.Add(viewport1);
            // 
            // panelBottomMenu
            // 
            this.panelBottomMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelBottomMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.panelBottomMenu.Controls.Add(this.lbMessage);
            this.panelBottomMenu.Controls.Add(this.label5);
            this.panelBottomMenu.Controls.Add(this.groupBox7);
            this.panelBottomMenu.Controls.Add(this.gbProperty);
            this.panelBottomMenu.Location = new System.Drawing.Point(0, 904);
            this.panelBottomMenu.Name = "panelBottomMenu";
            this.panelBottomMenu.Size = new System.Drawing.Size(1012, 46);
            this.panelBottomMenu.TabIndex = 14;
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbMessage.ForeColor = System.Drawing.Color.White;
            this.lbMessage.Location = new System.Drawing.Point(580, 14);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(162, 28);
            this.lbMessage.TabIndex = 14;
            this.lbMessage.Text = "Meassage here...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(489, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 28);
            this.label5.TabIndex = 14;
            this.label5.Text = "Meassage : ";
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox7.Location = new System.Drawing.Point(182, -2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(279, 43);
            this.groupBox7.TabIndex = 13;
            this.groupBox7.TabStop = false;
            // 
            // gbProperty
            // 
            this.gbProperty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbProperty.Controls.Add(this.label6);
            this.gbProperty.Controls.Add(this.btnProperty_Material);
            this.gbProperty.Controls.Add(this.btnProperty_Measure);
            this.gbProperty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbProperty.Location = new System.Drawing.Point(4, -2);
            this.gbProperty.Name = "gbProperty";
            this.gbProperty.Size = new System.Drawing.Size(170, 43);
            this.gbProperty.TabIndex = 13;
            this.gbProperty.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(5, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 28);
            this.label6.TabIndex = 4;
            this.label6.Text = "Property";
            // 
            // btnProperty_Material
            // 
            this.btnProperty_Material.FlatAppearance.BorderSize = 0;
            this.btnProperty_Material.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProperty_Material.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProperty_Material.Image = ((System.Drawing.Image)(resources.GetObject("btnProperty_Material.Image")));
            this.btnProperty_Material.Location = new System.Drawing.Point(117, 12);
            this.btnProperty_Material.Name = "btnProperty_Material";
            this.btnProperty_Material.Size = new System.Drawing.Size(38, 28);
            this.btnProperty_Material.TabIndex = 2;
            this.btnProperty_Material.UseVisualStyleBackColor = true;
            // 
            // btnProperty_Measure
            // 
            this.btnProperty_Measure.FlatAppearance.BorderSize = 0;
            this.btnProperty_Measure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProperty_Measure.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProperty_Measure.Image = ((System.Drawing.Image)(resources.GetObject("btnProperty_Measure.Image")));
            this.btnProperty_Measure.Location = new System.Drawing.Point(73, 12);
            this.btnProperty_Measure.Name = "btnProperty_Measure";
            this.btnProperty_Measure.Size = new System.Drawing.Size(38, 28);
            this.btnProperty_Measure.TabIndex = 1;
            this.btnProperty_Measure.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.색상변경ToolStripMenuItem,
            this.normalViewToolStripMenuItem,
            this.파트이동ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(206, 100);
            // 
            // 색상변경ToolStripMenuItem
            // 
            this.색상변경ToolStripMenuItem.Name = "색상변경ToolStripMenuItem";
            this.색상변경ToolStripMenuItem.Size = new System.Drawing.Size(205, 32);
            this.색상변경ToolStripMenuItem.Text = "색상변경";
            this.색상변경ToolStripMenuItem.Click += new System.EventHandler(this.색상변경ToolStripMenuItem_Click);
            // 
            // normalViewToolStripMenuItem
            // 
            this.normalViewToolStripMenuItem.Name = "normalViewToolStripMenuItem";
            this.normalViewToolStripMenuItem.Size = new System.Drawing.Size(205, 32);
            this.normalViewToolStripMenuItem.Text = "Normal View";
            this.normalViewToolStripMenuItem.Click += new System.EventHandler(this.normalViewToolStripMenuItem_Click);
            // 
            // 파트이동ToolStripMenuItem
            // 
            this.파트이동ToolStripMenuItem.Name = "파트이동ToolStripMenuItem";
            this.파트이동ToolStripMenuItem.Size = new System.Drawing.Size(205, 32);
            this.파트이동ToolStripMenuItem.Text = "파트 이동/회전";
            this.파트이동ToolStripMenuItem.Click += new System.EventHandler(this.파트이동ToolStripMenuItem_Click);
            // 
            // dragctrlTitleBar
            // 
            this.dragctrlTitleBar.SelectControl = this.panelTitleBar;
            // 
            // Main_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1200, 950);
            this.Controls.Add(this.panelBottomMenu);
            this.Controls.Add(this.model1);
            this.Controls.Add(this.panelRightMenu);
            this.Controls.Add(this.panelUpperMenu);
            this.Controls.Add(this.panelTitleBar);
            this.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpperMenuSymbol)).EndInit();
            this.panelUpperMenu.ResumeLayout(false);
            this.gbRender.ResumeLayout(false);
            this.gbRender.PerformLayout();
            this.gbDisplay.ResumeLayout(false);
            this.gbDisplay.PerformLayout();
            this.gbSelection.ResumeLayout(false);
            this.gbSelection.PerformLayout();
            this.gbProjection.ResumeLayout(false);
            this.gbProjection.PerformLayout();
            this.panelRightMenu.ResumeLayout(false);
            this.gbPart.ResumeLayout(false);
            this.gbSketch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.model1)).EndInit();
            this.panelBottomMenu.ResumeLayout(false);
            this.panelBottomMenu.PerformLayout();
            this.gbProperty.ResumeLayout(false);
            this.gbProperty.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.PictureBox pbUpperMenuSymbol;
        private System.Windows.Forms.Panel panelUpperMenu;
        private System.Windows.Forms.Panel panelRightMenu;
        private DRAG_CONTROL dragctrlTitleBar;
        private System.Windows.Forms.Button btnExit;
        private devDept.Eyeshot.Model model1;
        private System.Windows.Forms.GroupBox gbProjection;
        private System.Windows.Forms.Button btnSketch_In;
        private System.Windows.Forms.GroupBox gbPart;
        private System.Windows.Forms.GroupBox gbSketch;
        private System.Windows.Forms.Button Normal;
        private System.Windows.Forms.Button btnProjection_Bottom;
        private System.Windows.Forms.Button btnProjection_Upper;
        private System.Windows.Forms.Button btnProjection_Right;
        private System.Windows.Forms.Button btnProjection_Left;
        private System.Windows.Forms.Button btnProjection_Rear;
        private System.Windows.Forms.Button btnProjection_Front;
        private System.Windows.Forms.Button btnProjection_Isometric;
        private System.Windows.Forms.GroupBox gbSelection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelection_Entity;
        private System.Windows.Forms.Button btnSelection_Plane;
        private System.Windows.Forms.Button btnSelection_Line;
        private System.Windows.Forms.Button btnSelection_Point;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbDisplay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDisplay_Grid;
        private System.Windows.Forms.Button btnDisplay_Perpendicular;
        private System.Windows.Forms.Button btnDisplay_Perspective;
        private System.Windows.Forms.GroupBox gbRender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRender_Wireframe1;
        private System.Windows.Forms.Button btnRender_HiddenWire;
        private System.Windows.Forms.Button btnRender_Wireframe2;
        private System.Windows.Forms.Button btnRender_ShadeSmooth;
        private System.Windows.Forms.Button btnRender_ShadeEdge;
        private System.Windows.Forms.Button btnSketch_Out;
        private System.Windows.Forms.Button btnSketch_Trim;
        private System.Windows.Forms.Button btnSketch_Slot;
        private System.Windows.Forms.Button btnSketch_DashedLine;
        private System.Windows.Forms.Button btnSketch_Line;
        private System.Windows.Forms.Button btnSketch_Round;
        private System.Windows.Forms.Button btnSketch_RectCenter;
        private System.Windows.Forms.Button btnSketch_Rect;
        private System.Windows.Forms.Button btnSketch_Polygon;
        private System.Windows.Forms.Button btnSketch_Circle;
        private System.Windows.Forms.Button btnPart_RevolveCut;
        private System.Windows.Forms.Button btnPart_Revolve;
        private System.Windows.Forms.Button btnPart_Sweep;
        private System.Windows.Forms.Button btnPart_Extrude;
        private System.Windows.Forms.Button btnPart_ExtrudeCut;
        private System.Windows.Forms.Panel panelBottomMenu;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox gbProperty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnProperty_Material;
        private System.Windows.Forms.Button btnProperty_Measure;
        private System.Windows.Forms.Button btnSketch_Dimension;
        private System.Windows.Forms.Button SweepCut;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSketch_Symmetry;
        private System.Windows.Forms.Button btnSketch_Tangent;
        private System.Windows.Forms.Button btnSketch_Coincidence;
        private System.Windows.Forms.Button btnSketch_Parallel;
        private System.Windows.Forms.Button btnSketch_Perpendicular;
        private System.Windows.Forms.Button btnSketch_Horizontal;
        private System.Windows.Forms.Button btnSketch_Vertical;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 색상변경ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 파트이동ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_file;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_file_open;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_file_import;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_file_export;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_file_save;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_edit;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_view;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_insert;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_insert_part;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_tools;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_window;
    }
}

