using devDept.Eyeshot;
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

namespace CAD_Modeler
{
    public partial class Form_Transformation : Form
    {
        Main_Form main_form;
        Translation_Type translation_Type;
        Rotation_Type rotation_Type;

        public enum Translation_Type
        {
            XYZ_Position,
            Delta_XYZ_Position,
            MouseDrag,
        }

        public enum Rotation_Type
        {
            Delta_XYZ_Degree,
            MouseDrag,
        }
        Model model
        {
            get
            {
                return main_form.GetModel();
            }
        }


        public Form_Transformation(Main_Form form)
        {
            InitializeComponent();
            this.main_form = form;
        }

        private void Form_Transformation_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            cbx_Rotate.SelectedIndex = 0;
            cbx_Translate.SelectedIndex = 0;
            if (cbx_Translate.SelectedIndex == 0)
                translation_Type = Translation_Type.Delta_XYZ_Position;
            else if (cbx_Translate.SelectedIndex == 1)
                translation_Type = Translation_Type.XYZ_Position;

            if (cbx_Rotate.SelectedIndex == 0)
                rotation_Type = Rotation_Type.Delta_XYZ_Degree;
        }


        private void cbx_Translate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Translate.SelectedIndex == 0)
                translation_Type = Translation_Type.Delta_XYZ_Position;
            else if (cbx_Translate.SelectedIndex == 1)
                translation_Type = Translation_Type.XYZ_Position;
            else if (cbx_Translate.SelectedIndex == 2)
                translation_Type = Translation_Type.MouseDrag;
        }

        private void cbx_Rotate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Rotate.SelectedIndex == 0)
                rotation_Type = Rotation_Type.Delta_XYZ_Degree;
            else if (cbx_Rotate.SelectedIndex == 1)
                rotation_Type = Rotation_Type.MouseDrag;
        }

        private void btn_Translate_Apply_Click(object sender, EventArgs e)
        {
            Entity selectedEntity = null;

            foreach(var ent in model.Entities)
            {
                if (ent.Selected && ent is Brep)
                {
                    selectedEntity = ent;
                }
            }
            Brep brep = selectedEntity as Brep;
            if (brep == null)
                return;

            double dX_trans = (double)nud_Translate_X.Value;
            double dY_trans = (double)nud_Translate_Y.Value;
            double dZ_trans = (double)nud_Translate_Z.Value;

            Transformation trans = new Transformation();

            //이동
            Translation tr = new Translation(dX_trans, dY_trans, dZ_trans);

            //이동정보 등록
            trans = tr;

            selectedEntity.TransformBy(trans);
            model.Entities.Regen();
            model.Invalidate();

            main_form.form_log.AddLog("파트 이동" + " 완료");
        }

        private void btn_Rotate_Apply_Click(object sender, EventArgs e)
        {
            Entity selectedEntity = null;

            foreach (var ent in model.Entities)
            {
                if (ent.Selected && ent is Brep)
                {
                    selectedEntity = ent;
                }
            }
            Brep brep = selectedEntity as Brep;
            if (brep == null)
                return;
            double dX_rot = (double)nud_Rotate_X.Value;
            double dY_rot = (double)nud_Rotate_Y.Value;
            double dZ_rot = (double)nud_Rotate_Z.Value;

            Transformation trans = new Transformation();

            //회전
            Rotation rot_X = new Rotation(Utility.DegToRad(dX_rot), Plane.XY.AxisX);
            Rotation rot_Y = new Rotation(Utility.DegToRad(dY_rot), Plane.XY.AxisY);
            Rotation rot_Z = new Rotation(Utility.DegToRad(dZ_rot), Plane.XY.AxisZ);

            //이동정보 등록
            trans = rot_X * rot_Y * rot_Z;

            selectedEntity.TransformBy(trans);
            model.Entities.Regen();
            model.Invalidate();

            main_form.form_log.AddLog("파트 회전" + " 완료");
        }
    }
}
