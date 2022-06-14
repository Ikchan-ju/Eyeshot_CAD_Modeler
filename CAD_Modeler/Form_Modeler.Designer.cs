
namespace CAD_Modeler
{
    partial class Form_Modeler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_sketch = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_dValue = new System.Windows.Forms.Label();
            this.checkBox_direction = new System.Windows.Forms.CheckBox();
            this.label_unit = new System.Windows.Forms.Label();
            this.button_Run = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.textBox_sketch = new System.Windows.Forms.TextBox();
            this.label_guideLIne = new System.Windows.Forms.Label();
            this.textBox_ref = new System.Windows.Forms.TextBox();
            this.nud_dValue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nud_dValue)).BeginInit();
            this.SuspendLayout();
            // 
            // label_sketch
            // 
            this.label_sketch.AutoSize = true;
            this.label_sketch.Location = new System.Drawing.Point(85, 34);
            this.label_sketch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_sketch.Name = "label_sketch";
            this.label_sketch.Size = new System.Drawing.Size(62, 18);
            this.label_sketch.TabIndex = 1;
            this.label_sketch.Text = "스케치";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "방향";
            // 
            // label_dValue
            // 
            this.label_dValue.AutoSize = true;
            this.label_dValue.Location = new System.Drawing.Point(85, 182);
            this.label_dValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_dValue.Name = "label_dValue";
            this.label_dValue.Size = new System.Drawing.Size(44, 18);
            this.label_dValue.TabIndex = 5;
            this.label_dValue.Text = "높이";
            // 
            // checkBox_direction
            // 
            this.checkBox_direction.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_direction.AutoSize = true;
            this.checkBox_direction.Location = new System.Drawing.Point(156, 124);
            this.checkBox_direction.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_direction.Name = "checkBox_direction";
            this.checkBox_direction.Size = new System.Drawing.Size(72, 28);
            this.checkBox_direction.TabIndex = 6;
            this.checkBox_direction.Text = "정방향";
            this.checkBox_direction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_direction.UseVisualStyleBackColor = true;
            this.checkBox_direction.CheckedChanged += new System.EventHandler(this.checkBox_direction_CheckedChanged);
            // 
            // label_unit
            // 
            this.label_unit.AutoSize = true;
            this.label_unit.Location = new System.Drawing.Point(424, 183);
            this.label_unit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_unit.Name = "label_unit";
            this.label_unit.Size = new System.Drawing.Size(38, 18);
            this.label_unit.TabIndex = 7;
            this.label_unit.Text = "mm";
            // 
            // button_Run
            // 
            this.button_Run.Location = new System.Drawing.Point(94, 234);
            this.button_Run.Margin = new System.Windows.Forms.Padding(4);
            this.button_Run.Name = "button_Run";
            this.button_Run.Size = new System.Drawing.Size(115, 44);
            this.button_Run.TabIndex = 8;
            this.button_Run.Text = "실행";
            this.button_Run.UseVisualStyleBackColor = true;
            this.button_Run.Click += new System.EventHandler(this.button_Run_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(241, 234);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(115, 44);
            this.button_Cancel.TabIndex = 9;
            this.button_Cancel.Text = "취소";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_Cancel_MouseClick);
            // 
            // textBox_sketch
            // 
            this.textBox_sketch.Location = new System.Drawing.Point(158, 30);
            this.textBox_sketch.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_sketch.Name = "textBox_sketch";
            this.textBox_sketch.Size = new System.Drawing.Size(250, 28);
            this.textBox_sketch.TabIndex = 10;
            this.textBox_sketch.Click += new System.EventHandler(this.textBox_sketch_Click);
            // 
            // label_guideLIne
            // 
            this.label_guideLIne.AutoSize = true;
            this.label_guideLIne.Location = new System.Drawing.Point(85, 82);
            this.label_guideLIne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_guideLIne.Name = "label_guideLIne";
            this.label_guideLIne.Size = new System.Drawing.Size(62, 18);
            this.label_guideLIne.TabIndex = 1;
            this.label_guideLIne.Text = "보조선";
            // 
            // textBox_ref
            // 
            this.textBox_ref.Location = new System.Drawing.Point(158, 78);
            this.textBox_ref.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ref.Name = "textBox_ref";
            this.textBox_ref.Size = new System.Drawing.Size(250, 28);
            this.textBox_ref.TabIndex = 10;
            this.textBox_ref.Click += new System.EventHandler(this.textBox_ref_Click);
            // 
            // nud_dValue
            // 
            this.nud_dValue.DecimalPlaces = 2;
            this.nud_dValue.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_dValue.Location = new System.Drawing.Point(158, 173);
            this.nud_dValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_dValue.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nud_dValue.Name = "nud_dValue";
            this.nud_dValue.Size = new System.Drawing.Size(250, 28);
            this.nud_dValue.TabIndex = 11;
            this.nud_dValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nud_dValue_KeyPress);
            // 
            // Form_Modeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 317);
            this.Controls.Add(this.nud_dValue);
            this.Controls.Add(this.textBox_ref);
            this.Controls.Add(this.textBox_sketch);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Run);
            this.Controls.Add(this.label_unit);
            this.Controls.Add(this.checkBox_direction);
            this.Controls.Add(this.label_dValue);
            this.Controls.Add(this.label_guideLIne);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_sketch);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Modeler";
            this.Text = "Form_Extrude";
            this.Load += new System.EventHandler(this.Form_Modeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_dValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_sketch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_dValue;
        private System.Windows.Forms.CheckBox checkBox_direction;
        private System.Windows.Forms.Label label_unit;
        private System.Windows.Forms.Button button_Run;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.TextBox textBox_sketch;
        private System.Windows.Forms.Label label_guideLIne;
        private System.Windows.Forms.TextBox textBox_ref;
        private System.Windows.Forms.NumericUpDown nud_dValue;
    }
}