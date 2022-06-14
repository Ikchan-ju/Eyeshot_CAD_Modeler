using devDept.Eyeshot;
using devDept.Eyeshot.Entities;
using devDept.Geometry;
using System;
using System.Collections.Generic;
using Color = System.Drawing.Color;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD_Modeler
{
    class GripManager
    {
        public List<Grip> grips { get; set; }
        Model model1;

        public GripManager(Model model)
        {
            grips = new List<Grip>();
            this.model1 = model;
        }

        // 객체 선택 동작
        public void SelectTargetEntity(Entity ent)
        {
            // 객체를 선택하면 grip 생성
            MakeGrips(ent);
        }

        void AddGrip(Point3D Pos, Grip.GripType gripType, Entity targetEntity)
        {
            Point3D firstPos = Pos.Clone() as Point3D;
            Point gripPoint = new Point(firstPos.Clone() as Point3D, 10);
            Grip grip = new Grip(firstPos, gripPoint, gripType, targetEntity);
            grips.Add(grip);
            model1.Entities.Add(gripPoint, Color.Blue);
        }
        // Grip 생성
        public void MakeGrips(Entity ent)
        {
            // ent가 gripPoint인 경우에는 그립을 선택한다
            if (IsGripPoint(ent))
            {
                // 그립 선택
                SelectGrip(ent);
            }
            else
            {
                // ent가 gripPoint가 아닌경우
                Line line = ent as Line;
                if (line != null)
                {
                    // 시작점
                    AddGrip(line.StartPoint, Grip.GripType.Line_StartPoint, ent);

                    // 끝점
                    AddGrip(line.EndPoint, Grip.GripType.Line_EndPoint, ent);

                    // 중간점
                    AddGrip(line.MidPoint, Grip.GripType.Line_MidPoint, ent);
                }

                Circle circle = ent as Circle;
                if (circle != null)
                {
                    // 중심
                    AddGrip(circle.Center, Grip.GripType.Circle_CenterPoint, ent);

                    // 반지름
                    AddGrip(circle.StartPoint, Grip.GripType.Circle_RadiusPoint, ent);
                }

                // todo : 객체 종류 추가 해야함
            }
        }

        // grip 선택
        private void SelectGrip(Entity ent)
        {
            foreach (var g in grips)
            {
                if (g.gripPoint == ent)
                {
                    model1.Entities.ClearSelection();
                    ent.Selected = true;
                }
            }
        }

        // entity가 grip point 인지 판단
        private bool IsGripPoint(Entity ent)
        {
            foreach (var g in grips)
            {
                if (g.gripPoint == ent)
                    return true;
            }
            return false;
        }

        public void MoveGrip(Point3D newPos)
        {
            var selectedGrip = GetSelectedGrip();
            if (selectedGrip == null)
                return;

            MoveGrip(selectedGrip, newPos);
        }

        public Grip GetSelectedGrip()
        {
            foreach (var g in grips)
            {
                if (g.gripPoint.Selected)
                {
                    return g;
                }
            }
            return null;
        }

        // Grip 이동
        public void MoveGrip(Grip grip, Point3D newPos)
        {
            var line = grip.targetEntity as Line;
            if (line != null)
            {
                if (grip.gripType == Grip.GripType.Line_StartPoint)
                {
                    line.StartPoint.Copy(newPos);
                }
                else if (grip.gripType == Grip.GripType.Line_EndPoint)
                {
                    line.EndPoint.Copy(newPos);
                }
                else if (grip.gripType == Grip.GripType.Line_MidPoint)
                {
                    Point3D diff = newPos - line.MidPoint;
                    line.StartPoint.Copy(line.StartPoint + diff);
                    line.EndPoint.Copy(line.EndPoint + diff);
                }
                grip.targetEntity.Regen(1);
                return;
            }
            var circle = grip.targetEntity as Circle;
            if (circle != null)
            {
                if (grip.gripType == Grip.GripType.Circle_CenterPoint)
                {
                    circle.Center.Copy(newPos);
                }
                else if (grip.gripType == Grip.GripType.Circle_RadiusPoint)
                {
                    circle.Radius = circle.Center.DistanceTo(newPos);
                    Vector3D vec1 = new Vector3D(circle.StartPoint, circle.Center);
                    Vector3D vec2 = new Vector3D(newPos, circle.Center);
                    circle.Rotate(vec2.Angle - vec1.Angle, new Vector3D(0, 0, 1), circle.Center);
                }
                grip.targetEntity.Regen(1);
                return;
            }

            throw new NotImplementedException();
        }

        public void Cancel()
        {
            foreach (var grip in grips)
            {
                model1.Entities.Remove(grip.gripPoint);
            }

            grips.Clear();
        }

        public void Finish()
        {
            var selectedGrip = GetSelectedGrip();
            if (selectedGrip == null)
                return;

            // 선택한 grip의 targetEntity에 대한 grip만 지움.
            var ent = selectedGrip.targetEntity;
            foreach (var grip in grips)
            {
                if (grip.targetEntity == ent)
                {
                    grip.targetEntity = null;
                    model1.Entities.Remove(grip.gripPoint);
                }
            }
            grips.RemoveAll(g => g.targetEntity == null);
            // TargetEntity의 Grip은 다시 만듦
            MakeGrips(ent);
        }

    }
}
