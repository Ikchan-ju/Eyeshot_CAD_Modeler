using devDept.Eyeshot;
using devDept.Eyeshot.Entities;
using Color = System.Drawing.Color;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAD_Modeler.Action_Modeler;
using devDept.Geometry;

namespace CAD_Modeler
{
    public partial class Form_Modeler : Form
    {
        Main_Form main_form;
        Region region = null;
        Line guideLine = null;
        ICurve guideCurve = null;

        int direction = 1;
        bool actionFlag = true;
        Action_Extrude ac = null;
        TextBox selectedTbx = null;
        Type type;

        public enum Type
        {
            Extrude,
            ExtrudeCut,
            Revolve,
            RevolveCut,
            Sweep,
            SweepCut,

        }

        Model model
        {
            get
            {
                return main_form.GetModel();
            }
        }

        private void Form_Modeler_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            textBox_sketch.ReadOnly = true;
            textBox_ref.ReadOnly = true;
            checkBox_direction.Checked = false;
            nud_dValue.Text = (10).ToString("0.0");

            switch (type)
            {
                case Type.Extrude:
                    this.Text = "Extrude";
                    textBox_ref.Enabled = false;
                    label_dValue.Visible = true;
                    nud_dValue.Visible = true;
                    label_unit.Visible = true;
                    label_dValue.Text = "높이";
                    nud_dValue.Text = "100.0";
                    label_unit.Text = "mm";
                    break;
                case Type.ExtrudeCut:
                    this.Text = "Extrude Cut";
                    textBox_ref.Enabled = false;
                    label_dValue.Visible = true;
                    nud_dValue.Visible = true;
                    label_unit.Visible = true;
                    label_dValue.Text = "높이";
                    nud_dValue.Text = "100.0";
                    label_unit.Text = "mm";
                    break;

                case Type.Revolve:
                    this.Text = "Revolve";
                    textBox_ref.Enabled = true;
                    label_dValue.Visible = true;
                    nud_dValue.Visible = true;
                    label_unit.Visible = true;
                    label_dValue.Text = "각도";
                    nud_dValue.Text = "360.0";
                    label_unit.Text = "º";
                    break;
                case Type.RevolveCut:
                    this.Text = "Revolve Cut";
                    textBox_ref.Enabled = true;
                    label_dValue.Visible = true;
                    nud_dValue.Visible = true;
                    label_unit.Visible = true;
                    label_dValue.Text = "각도";
                    nud_dValue.Text = "360.0";
                    label_unit.Text = "º";
                    break;
                case Type.Sweep:
                    this.Text = "Sweep";
                    textBox_ref.Enabled = true;
                    label_dValue.Visible = false;
                    nud_dValue.Visible = false;
                    label_unit.Visible = false;
                    break;
                case Type.SweepCut:
                    this.Text = "Sweep Cut";
                    textBox_ref.Enabled = true;
                    label_dValue.Visible = false;
                    nud_dValue.Visible = false;
                    label_unit.Visible = false;
                    break;
            }
            if (selectedTbx == null)
            {
                textBox_sketch.BackColor = Color.LightBlue;
                nud_dValue.BackColor = System.Drawing.SystemColors.Window;
                selectedTbx = textBox_sketch;
            }
            model.Entities.ClearSelection();
            model.Invalidate();
        }

        public Form_Modeler(Main_Form form, Type type, Region region = null)
        {
            InitializeComponent();
            this.main_form = form;
            this.type = type;
            if(region != null)
            {
                if(selectedTbx == null)
                {
                    textBox_sketch.BackColor = Color.LightBlue;
                    textBox_ref.BackColor = System.Drawing.SystemColors.Window;
                    selectedTbx = textBox_sketch;
                }
                this.region = region;
                Sketch sketch = this.region.EntityData as Sketch;
                selectedTbx.Text = sketch.name.ToString();
            }
            SelectSketch_Async();
        }
        private async void SelectSketch_Async()
        {
            ac = new Action_Extrude(model);
            while (actionFlag)
            {
                Entity tempEntity = await ac.RunAsync();
                if (tempEntity == null)
                    continue;
                if(selectedTbx == textBox_sketch)
                {
                    if (!(tempEntity is Region))
                        continue;
                    region = tempEntity as Region;
                    Sketch sketch = region.EntityData as Sketch;
                    selectedTbx.Text = sketch.name.ToString();
                }
                else if(selectedTbx == textBox_ref)
                {
                    Sketch sketch = null;
                    switch (type)
                    {
                        case Type.Revolve:
                        case Type.RevolveCut:
                            if (!(tempEntity is Line))
                                continue;
                            guideLine = tempEntity as Line;
                            sketch = guideLine.EntityData as Sketch;
                            break;
                        case Type.Sweep:
                        case Type.SweepCut:
                            if(tempEntity is Curve)
                                guideCurve = tempEntity as Curve;
                            if (tempEntity is Line)
                                guideCurve = tempEntity as Line;
                            if (!((tempEntity is Curve)||(tempEntity is Line)))
                            {
                                guideCurve = null;
                                selectedTbx.Text = "";
                                continue;
                            }

                            sketch = tempEntity.EntityData as Sketch;
                            break;
                    }
                    if (sketch == null)
                        continue;
                    selectedTbx.Text = sketch.name.ToString();
                }
            }
        }

        private void checkBox_direction_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_direction.Checked)
            {
                checkBox_direction.Text = "역방향";
                direction = -1;
            }
            else
            {
                checkBox_direction.Text = "정방향";
                direction = 1;
            }
        }
        private void button_Cancel_MouseClick(object sender, MouseEventArgs e)
        {
            actionFlag = false;
            ac.Stop();
            main_form.form_log.AddLog(this.Text + " 취소");
            this.Close();
        }

        private void button_Run_Click(object sender, EventArgs e)
        {
            if (region == null) return;
            ac.Stop();

            Entity ent = MakeEntity();
            if(ent != null)
            {
                model.Entities.Add(ent, Color.Aqua);
                model.Entities.Remove(region);
            }
            model.Entities.Regen();
            model.Invalidate();
            actionFlag = false;

            main_form.form_log.AddLog(this.Text + " 완료");
            this.Close();
        }

        Entity MakeEntity()
        {
            Brep brep = null;

            try
            {
                double dValue = Convert.ToDouble(nud_dValue.Text);
                if (dValue != double.NaN)
                {
                    switch (type)
                    {
                        case Type.Extrude:
                            region.Plane = (region.EntityData as Sketch).plane;
                            brep = region.ExtrudeAsBrep(direction * dValue);
                            break;
                        case Type.ExtrudeCut:
                            foreach (var ent in model.Entities)
                            {
                                Brep temp_brep = ent as Brep;
                                if (temp_brep == null)
                                    continue;
                                region.Plane = (region.EntityData as Sketch).plane;
                                var bl = temp_brep.ExtrudeRemove(region, direction * dValue);
                            }

                            break;

                        case Type.Revolve:
                            brep = region.RevolveAsBrep(Utility.DegToRad(dValue), guideLine.Direction, guideLine.StartPoint);

                            break;
                        case Type.RevolveCut:
                            foreach (var ent in model.Entities)
                            {
                                Brep temp_brep = ent as Brep;
                                if (temp_brep == null)
                                    continue;
                                var bl = temp_brep.RevolveRemove(region, Utility.DegToRad(dValue), guideLine.Direction, guideLine.StartPoint);
                            }

                            break;
                        case Type.Sweep:
                            guideCurve.StartPoint.ConvertToPoint3D(region.Plane, new Point2D(0, 0));
                            brep = region.SweepAsBrep(guideCurve, 0.1);

                            break;
                        case Type.SweepCut:

                            break;
                    }
                }
            }
            catch
            {

            }

            return brep;
        }

        private void textBox_sketch_Click(object sender, EventArgs e)
        {
            textBox_sketch.BackColor = Color.LightBlue;
            textBox_ref.BackColor = System.Drawing.SystemColors.Window;
            selectedTbx = textBox_sketch;
        }

        private void textBox_ref_Click(object sender, EventArgs e)
        {
            textBox_sketch.BackColor = System.Drawing.SystemColors.Window;
            textBox_ref.BackColor = Color.LightBlue;
            selectedTbx = textBox_ref;
        }

        private void nud_dValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
