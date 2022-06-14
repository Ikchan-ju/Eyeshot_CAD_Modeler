
namespace CAD_Modeler
{
    partial class Form_Transformation
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_Translate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Translate_Apply = new System.Windows.Forms.Button();
            this.nud_Translate_X = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_Translate_Y = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nud_Translate_Z = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_Rotate = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Rotate_Apply = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.nud_Rotate_X = new System.Windows.Forms.NumericUpDown();
            this.nud_Rotate_Y = new System.Windows.Forms.NumericUpDown();
            this.nud_Rotate_Z = new System.Windows.Forms.NumericUpDown();
            this.label_unit = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Translate_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Translate_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Translate_Z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Rotate_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Rotate_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Rotate_Z)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "이동방식 :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbx_Translate
            // 
            this.cbx_Translate.FormattingEnabled = true;
            this.cbx_Translate.Items.AddRange(new object[] {
            "델타 XYZ에 의해",
            "XYZ 위치로"});
            this.cbx_Translate.Location = new System.Drawing.Point(134, 16);
            this.cbx_Translate.Name = "cbx_Translate";
            this.cbx_Translate.Size = new System.Drawing.Size(336, 26);
            this.cbx_Translate.TabIndex = 1;
            this.cbx_Translate.SelectedIndexChanged += new System.EventHandler(this.cbx_Translate_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "X :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_Translate_Apply
            // 
            this.btn_Translate_Apply.Location = new System.Drawing.Point(395, 159);
            this.btn_Translate_Apply.Name = "btn_Translate_Apply";
            this.btn_Translate_Apply.Size = new System.Drawing.Size(75, 37);
            this.btn_Translate_Apply.TabIndex = 2;
            this.btn_Translate_Apply.Text = "적용";
            this.btn_Translate_Apply.UseVisualStyleBackColor = true;
            this.btn_Translate_Apply.Click += new System.EventHandler(this.btn_Translate_Apply_Click);
            // 
            // nud_Translate_X
            // 
            this.nud_Translate_X.DecimalPlaces = 2;
            this.nud_Translate_X.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_Translate_X.Location = new System.Drawing.Point(134, 57);
            this.nud_Translate_X.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_Translate_X.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nud_Translate_X.Name = "nud_Translate_X";
            this.nud_Translate_X.Size = new System.Drawing.Size(336, 28);
            this.nud_Translate_X.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Y :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nud_Translate_Y
            // 
            this.nud_Translate_Y.DecimalPlaces = 2;
            this.nud_Translate_Y.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_Translate_Y.Location = new System.Drawing.Point(134, 91);
            this.nud_Translate_Y.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_Translate_Y.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nud_Translate_Y.Name = "nud_Translate_Y";
            this.nud_Translate_Y.Size = new System.Drawing.Size(336, 28);
            this.nud_Translate_Y.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Z :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nud_Translate_Z
            // 
            this.nud_Translate_Z.DecimalPlaces = 2;
            this.nud_Translate_Z.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_Translate_Z.Location = new System.Drawing.Point(134, 125);
            this.nud_Translate_Z.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_Translate_Z.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nud_Translate_Z.Name = "nud_Translate_Z";
            this.nud_Translate_Z.Size = new System.Drawing.Size(336, 28);
            this.nud_Translate_Z.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "회전방식 :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "X :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbx_Rotate
            // 
            this.cbx_Rotate.FormattingEnabled = true;
            this.cbx_Rotate.Items.AddRange(new object[] {
            "델타 XYZ에 의해"});
            this.cbx_Rotate.Location = new System.Drawing.Point(134, 229);
            this.cbx_Rotate.Name = "cbx_Rotate";
            this.cbx_Rotate.Size = new System.Drawing.Size(336, 26);
            this.cbx_Rotate.TabIndex = 1;
            this.cbx_Rotate.SelectedIndexChanged += new System.EventHandler(this.cbx_Rotate_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Y :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_Rotate_Apply
            // 
            this.btn_Rotate_Apply.Location = new System.Drawing.Point(395, 372);
            this.btn_Rotate_Apply.Name = "btn_Rotate_Apply";
            this.btn_Rotate_Apply.Size = new System.Drawing.Size(75, 37);
            this.btn_Rotate_Apply.TabIndex = 2;
            this.btn_Rotate_Apply.Text = "적용";
            this.btn_Rotate_Apply.UseVisualStyleBackColor = true;
            this.btn_Rotate_Apply.Click += new System.EventHandler(this.btn_Rotate_Apply_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(92, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Z :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nud_Rotate_X
            // 
            this.nud_Rotate_X.DecimalPlaces = 2;
            this.nud_Rotate_X.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_Rotate_X.Location = new System.Drawing.Point(134, 270);
            this.nud_Rotate_X.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nud_Rotate_X.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.nud_Rotate_X.Name = "nud_Rotate_X";
            this.nud_Rotate_X.Size = new System.Drawing.Size(336, 28);
            this.nud_Rotate_X.TabIndex = 3;
            // 
            // nud_Rotate_Y
            // 
            this.nud_Rotate_Y.DecimalPlaces = 2;
            this.nud_Rotate_Y.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_Rotate_Y.Location = new System.Drawing.Point(134, 304);
            this.nud_Rotate_Y.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nud_Rotate_Y.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.nud_Rotate_Y.Name = "nud_Rotate_Y";
            this.nud_Rotate_Y.Size = new System.Drawing.Size(336, 28);
            this.nud_Rotate_Y.TabIndex = 3;
            // 
            // nud_Rotate_Z
            // 
            this.nud_Rotate_Z.DecimalPlaces = 2;
            this.nud_Rotate_Z.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_Rotate_Z.Location = new System.Drawing.Point(134, 338);
            this.nud_Rotate_Z.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nud_Rotate_Z.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.nud_Rotate_Z.Name = "nud_Rotate_Z";
            this.nud_Rotate_Z.Size = new System.Drawing.Size(336, 28);
            this.nud_Rotate_Z.TabIndex = 3;
            // 
            // label_unit
            // 
            this.label_unit.AutoSize = true;
            this.label_unit.Location = new System.Drawing.Point(477, 59);
            this.label_unit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_unit.Name = "label_unit";
            this.label_unit.Size = new System.Drawing.Size(38, 18);
            this.label_unit.TabIndex = 8;
            this.label_unit.Text = "mm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(477, 93);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "mm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(477, 127);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 18);
            this.label10.TabIndex = 8;
            this.label10.Text = "mm";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(477, 272);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 18);
            this.label11.TabIndex = 8;
            this.label11.Text = "deg";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(477, 306);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 18);
            this.label12.TabIndex = 8;
            this.label12.Text = "deg";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(477, 340);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 18);
            this.label13.TabIndex = 8;
            this.label13.Text = "deg";
            // 
            // Form_Transformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 421);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label_unit);
            this.Controls.Add(this.nud_Rotate_Z);
            this.Controls.Add(this.nud_Rotate_Y);
            this.Controls.Add(this.nud_Translate_Z);
            this.Controls.Add(this.nud_Rotate_X);
            this.Controls.Add(this.nud_Translate_Y);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nud_Translate_X);
            this.Controls.Add(this.btn_Rotate_Apply);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Translate_Apply);
            this.Controls.Add(this.cbx_Rotate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbx_Translate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Transformation";
            this.Text = "Form_Transformation";
            this.Load += new System.EventHandler(this.Form_Transformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Translate_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Translate_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Translate_Z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Rotate_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Rotate_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Rotate_Z)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_Translate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Translate_Apply;
        private System.Windows.Forms.NumericUpDown nud_Translate_X;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_Translate_Y;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nud_Translate_Z;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_Rotate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Rotate_Apply;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nud_Rotate_X;
        private System.Windows.Forms.NumericUpDown nud_Rotate_Y;
        private System.Windows.Forms.NumericUpDown nud_Rotate_Z;
        private System.Windows.Forms.Label label_unit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}