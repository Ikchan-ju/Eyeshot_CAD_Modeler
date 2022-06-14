using devDept.Eyeshot;
using devDept.Eyeshot.Entities;
using devDept.Geometry;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using static devDept.Eyeshot.Environment;
using Color = System.Drawing.Color;

namespace CAD_Modeler
{
    abstract public class ActionBase
    {
        enum UserInput
        {
            GettingPoint3D, // Point3D 를 입력받고 있는지?
            SelectingEntity, // Entity를 선택하고있는지?(행동 기준) 정리가 필요함
            SelectionEntity, // Entity를 선택하고있는지?(속성 기준)
            SelectionFace, // Face를 선택하고있는지?
            SelectionEdge, // Edge를 선택하고있는지?
            SelectionVertex, // Vertex를 선택하고있는지?
            MovingPoint, // 점 선택해서 이동할때
            Count
        }

        static protected Point3D point3D = new Point3D();
        static private bool[] userInputting = new bool[(int)UserInput.Count];
        static public ActionBase runningAction = null;
        static public Plane activatedPlane;
        static protected Point selectedPt;
        static private Entity selectedEntity;

        // 명령이 취소된 경우 
        static public bool Canceled = false;

        // enter가 입력된 경우(다음 step으로 진행하는 의미)
        static public bool Entered = false;
        protected Model model1;

        static private bool IsStopedCurrentStep
        {
            get
            {
                return Canceled || Entered ? true : false;
            }
            set
            {
                Canceled = false;
                Entered = false;
            }
        }
        public ActionBase(Model _model)
        {
            this.model1 = _model;

        }
        abstract public void Run();
        protected bool IsCanceled()
        {
            if (ActionBase.Canceled == true)
                return true;

            return false;
        }
        // 액션 시작할때 반드시 호출해야 한다.
        virtual protected void StartAction()
        {
            // 시작할때 이미 실행중인 액션이 있다면 종료 시킨다.
            if (ActionBase.runningAction != null && ActionBase.runningAction != this)
            {
                ActionBase.Canceled = true;
                while (ActionBase.runningAction != null)
                {
                    // c++의 PeekMessage와 비슷한 역할을 한다.
                    System.Windows.Forms.Application.DoEvents();
                    System.Threading.Thread.Sleep(100);
                }
            }

            ActionBase.runningAction = this;
            ActionBase.Canceled = false;
            for (int i = 0; i < (int)UserInput.Count; ++i)
            {
                userInputting[i] = false;
            }

        }

        // 액션 종료할때 반드시 호출해야 한다.
        virtual protected void EndAction()
        {


            model1.ActionMode = actionType.None;
            model1.SelectionFilterMode = selectionFilterType.Entity;
            model1.Cursor = System.Windows.Forms.Cursors.Default;
            ActionBase.runningAction = null;
            SetSelectionMode(selectionFilterType.Entity);
        }

        // 객체 1개를 선택받거나 키를 입력받는다.
        public async Task<Entity> GetEntity(string message = null, int stepID = -1, bool dynamicHighlight = false, Dictionary<Type, bool> selectableType = null)
        {
            ActionBase.userInputting[(int)UserInput.SelectingEntity] = true;
            ActionBase.IsStopedCurrentStep = false;

            while (ActionBase.userInputting[(int)UserInput.SelectingEntity] == true)
            {
                // 스탭이 중지되었다면 그냥 보낸다.
                if (ActionBase.IsStopedCurrentStep)
                {
                    ActionBase.userInputting[(int)UserInput.SelectingEntity] = false;
                    break;
                }

                await Task.Delay(100);
            }


            if (selectedEntity != null)
            {
                selectedEntity.Selected = true;
                model1.Invalidate();
            }

            return selectedEntity;
        }

        public async Task<Point3D> GetPoint3D(string message = null, int stepID = -1)
        {
            ActionBase.userInputting[(int)UserInput.GettingPoint3D] = true;
            ActionBase.IsStopedCurrentStep = false;
            while (ActionBase.userInputting[(int)UserInput.GettingPoint3D] == true)
            {
                // 스탭이 중지되었다면 그냥 보낸다.
                if (ActionBase.IsStopedCurrentStep)
                {
                    ActionBase.userInputting[(int)UserInput.GettingPoint3D] = false;
                    break;
                }

                await Task.Delay(100);
            }
            return point3D;
        }
        virtual protected void OnMouseMove(MouseEventArgs e)
        {

        }
        virtual protected void OnMouseDrag(MouseEventArgs e)
        {

        }
        virtual protected void OnMouseUp(MouseEventArgs e)
        {

        }
        virtual protected void OnMouseDown(MouseEventArgs e)
        {

        }
        virtual protected void OnKeyUp(KeyEventArgs e)
        {

        }

        static public bool IsUserInputting()
        {
            // 실행중인 액션이 없으면 사용자 입력이 아님
            // 액션시작할때 StartAction 함수에서 설정된다.
            if (ActionBase.runningAction == null)
                return false;

            for (int i = 0; i < (int)UserInput.Count; ++i)
            {
                if (userInputting[i] == true)
                    return true;
            }


            return false;
        }

        static public void MouseMoveHandler(Model _model, MouseEventArgs e)
        {
            if (userInputting[(int)UserInput.GettingPoint3D] == true)
            {
                SetPoint3DByMouseEventArgs(_model, e);
            }

            if (runningAction != null)
            {
                runningAction.OnMouseMove(e);
            }
        }
        static public void MouseDragHandler(Model _model, MouseEventArgs e)
        {
            if (userInputting[(int)UserInput.GettingPoint3D] == true)
            {
                SetPoint3DByMouseEventArgs(_model, e);
            }

            if (runningAction != null)
            {
                runningAction.OnMouseDrag(e);
            }
        }

        static void SetPoint3DByMouseEventArgs(Model _model, MouseEventArgs e)
        {

            point3D = GetPoint3DByMouseLocation(_model, e.Location);

        }

        static public void SetSelectionMode(devDept.Eyeshot.selectionFilterType _filterMode, Mode _mode = Mode.Idle)
        {
            switch (_mode)
            {
                case Mode.Sketch:
                    switch (_filterMode)
                    {
                        case selectionFilterType.Entity:
                            userInputting[(int)UserInput.SelectionEntity] = true;
                            userInputting[(int)UserInput.SelectionFace] = false;
                            userInputting[(int)UserInput.SelectionEdge] = false;
                            userInputting[(int)UserInput.SelectionVertex] = false;
                            userInputting[(int)UserInput.MovingPoint] = false;
                            break;
                        case selectionFilterType.Face:
                            userInputting[(int)UserInput.SelectionEntity] = false;
                            userInputting[(int)UserInput.SelectionFace] = true;
                            userInputting[(int)UserInput.SelectionEdge] = false;
                            userInputting[(int)UserInput.SelectionVertex] = false;
                            userInputting[(int)UserInput.MovingPoint] = false;
                            break;
                        case selectionFilterType.Edge:
                            userInputting[(int)UserInput.SelectionEntity] = false;
                            userInputting[(int)UserInput.SelectionFace] = false;
                            userInputting[(int)UserInput.SelectionEdge] = true;
                            userInputting[(int)UserInput.SelectionVertex] = false;
                            userInputting[(int)UserInput.MovingPoint] = false;
                            break;
                        case selectionFilterType.Vertex:
                            userInputting[(int)UserInput.SelectionEntity] = true;
                            userInputting[(int)UserInput.SelectionFace] = false;
                            userInputting[(int)UserInput.SelectionEdge] = false;
                            userInputting[(int)UserInput.SelectionVertex] = false;
                            userInputting[(int)UserInput.MovingPoint] = true;
                            break;
                    }
                    break;

                default:
                    switch (_filterMode)
                    {
                        case selectionFilterType.Entity:
                            userInputting[(int)UserInput.SelectionEntity] = true;
                            userInputting[(int)UserInput.SelectionFace] = false;
                            userInputting[(int)UserInput.SelectionEdge] = false;
                            userInputting[(int)UserInput.SelectionVertex] = false;
                            userInputting[(int)UserInput.MovingPoint] = false;
                            break;
                        case selectionFilterType.Face:
                            userInputting[(int)UserInput.SelectionEntity] = false;
                            userInputting[(int)UserInput.SelectionFace] = true;
                            userInputting[(int)UserInput.SelectionEdge] = false;
                            userInputting[(int)UserInput.SelectionVertex] = false;
                            userInputting[(int)UserInput.MovingPoint] = false;
                            break;
                        case selectionFilterType.Edge:
                            userInputting[(int)UserInput.SelectionEntity] = false;
                            userInputting[(int)UserInput.SelectionFace] = false;
                            userInputting[(int)UserInput.SelectionEdge] = true;
                            userInputting[(int)UserInput.SelectionVertex] = false;
                            userInputting[(int)UserInput.MovingPoint] = false;
                            break;
                        case selectionFilterType.Vertex:
                            userInputting[(int)UserInput.SelectionEntity] = false;
                            userInputting[(int)UserInput.SelectionFace] = false;
                            userInputting[(int)UserInput.SelectionEdge] = false;
                            userInputting[(int)UserInput.SelectionVertex] = true;
                            userInputting[(int)UserInput.MovingPoint] = false;
                            break;
                    }
                    break;
            }
        }

        static void SelectEntityByMouseEventArgs(Model _model, MouseEventArgs e)
        {
            var item = _model.GetItemUnderMouseCursor(e.Location);

            SelectItem(_model, item);
            SelectPlane(_model, item);
        }

        static void SelectItem(Model _model, SelectedItem item)
        {
            if (item == null)
            {
                if (Form.ModifierKeys != Keys.Control)
                    _model.Entities.ClearSelection();
                return;
            }

            if (Form.ModifierKeys == Keys.Control)
            {
                item.Item.Selected = !item.Item.Selected;
            }
            else
            {
                _model.Entities.ClearSelection();
                item.Item.Selected = true;
                selectedEntity = item.Item as Entity;
            }
            _model.Invalidate();
        }

        static void SelectPlane(Model _model, SelectedItem item)
        {
            activatedPlane = null;
            if (item == null)
                return;
            if (runningAction != null)
                return;

            if (item.Item is Custom_Plane)
                activatedPlane = (item.Item as Custom_Plane).plane;

            if (item is SelectedFace)
            {
                SelectedFace sf = item as SelectedFace;
                Brep br = item.Item as Brep;
                if (br != null)
                {
                    br.ClearFacesSelection();
                    br.Rebuild();
                    br.SetFaceSelection(sf.Index, true);
                    _model.Invalidate();

                    var surface = br.Faces[sf.Index].Surface;
                    if (surface is PlanarSurf)
                    {
                        PlanarSurf ps = surface as PlanarSurf;
                        activatedPlane = ps.Plane;
                    }
                }
                return;
            }
        }
        static public Point3D GetPoint3DByMouseLocation(Model _model, System.Drawing.Point location)
        {
            Point3D point3D;
            if (activatedPlane != null)
            {
                if (_model.ScreenToPlane(location, activatedPlane, out point3D))
                    return point3D;
            }
            point3D = _model.ScreenToWorld(location);
            // null 이면 평면 기준으로 좌표를 리턴한다.
            if (point3D == null)
            {
                if (_model.ScreenToPlane(location, Plane.XZ, out point3D))
                    return point3D;
                else if (_model.ScreenToPlane(location, Plane.XY, out point3D))
                    return point3D;
                else if (_model.ScreenToPlane(location, Plane.YZ, out point3D))
                    return point3D;
            }

            return point3D;
        }

        // mouse click 이벤트 처리
        static public void MouseClickHandler(Model _model, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (userInputting[(int)UserInput.GettingPoint3D] == true)
                {
                    SetPoint3DByMouseEventArgs(_model, e);

                    userInputting[(int)UserInput.GettingPoint3D] = false;
                }
                if (userInputting[(int)UserInput.SelectionEntity] == true)
                {
                    SelectEntityByMouseEventArgs(_model, e);
                }

                if (userInputting[(int)UserInput.SelectingEntity] == true)
                {
                    _model.Entities.ClearSelection();
                    Model.SelectedItem item = _model.GetItemUnderMouseCursor(e.Location);
                    if (item != null)
                    {
                        Entity entityTmp = item.Item as Entity;
                        if (entityTmp != null)
                        {
                            selectedEntity = entityTmp;
                            userInputting[(int)UserInput.SelectingEntity] = false;
                        }
                    }
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (userInputting[(int)UserInput.SelectionEntity] == true)
                {
                    SelectEntityByMouseEventArgs(_model, e);
                }
            }
        }

        // mouse Down 이벤트 처리
        static public void MouseDownHandler(Model _model, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            { 

            }

            if (runningAction != null)
            {
                runningAction.OnMouseDown(e);
            }
        }

        // mouse up 이벤트 처리
        static public void MouseUpHandler(Model _model, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                
            }

            if (runningAction != null)
            {
                runningAction.OnMouseUp(e);
            }
        }

        static public void KeyUpHandler(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Canceled = true;
            }

            if (runningAction != null)
            {
                runningAction.OnKeyUp(e);
            }
        }

    }
}
