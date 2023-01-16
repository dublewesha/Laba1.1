namespace lab1_task1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelerror = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxRed = new System.Windows.Forms.TextBox();
            this.textBoxGreen = new System.Windows.Forms.TextBox();
            this.textBoxBlue = new System.Windows.Forms.TextBox();
            this.radioButtonHex = new System.Windows.Forms.RadioButton();
            this.radioButtonDec = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelerror);
            this.panel1.Location = new System.Drawing.Point(239, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 155);
            this.panel1.TabIndex = 0;
            // 
            // labelerror
            // 
            this.labelerror.AutoSize = true;
            this.labelerror.Location = new System.Drawing.Point(11, 65);
            this.labelerror.Name = "labelerror";
            this.labelerror.Size = new System.Drawing.Size(182, 15);
            this.labelerror.TabIndex = 11;
            this.labelerror.Text = "Ошибка при вычислении цвета";
            this.labelerror.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Красный";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Зеленый";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Синий";
            // 
            // textboxRed
            // 
            this.textboxRed.Location = new System.Drawing.Point(132, 35);
            this.textboxRed.Name = "textboxRed";
            this.textboxRed.Size = new System.Drawing.Size(100, 23);
            this.textboxRed.TabIndex = 6;
            this.textboxRed.Text = "0";
            this.textboxRed.TextChanged += new System.EventHandler(this.textboxRed_TextChanged);
            this.textboxRed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxRed_KeyPress);
            // 
            // textBoxGreen
            // 
            this.textBoxGreen.Location = new System.Drawing.Point(132, 75);
            this.textBoxGreen.Name = "textBoxGreen";
            this.textBoxGreen.Size = new System.Drawing.Size(100, 23);
            this.textBoxGreen.TabIndex = 7;
            this.textBoxGreen.Text = "0";
            this.textBoxGreen.TextChanged += new System.EventHandler(this.textBoxGreen_TextChanged);
            this.textBoxGreen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGreen_KeyPress);
            // 
            // textBoxBlue
            // 
            this.textBoxBlue.Location = new System.Drawing.Point(132, 119);
            this.textBoxBlue.Name = "textBoxBlue";
            this.textBoxBlue.Size = new System.Drawing.Size(100, 23);
            this.textBoxBlue.TabIndex = 8;
            this.textBoxBlue.Text = "0";
            this.textBoxBlue.TextChanged += new System.EventHandler(this.textBoxBlue_TextChanged);
            this.textBoxBlue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBlue_KeyPress);
            // 
            // radioButtonHex
            // 
            this.radioButtonHex.AutoSize = true;
            this.radioButtonHex.Location = new System.Drawing.Point(147, 164);
            this.radioButtonHex.Name = "radioButtonHex";
            this.radioButtonHex.Size = new System.Drawing.Size(46, 19);
            this.radioButtonHex.TabIndex = 9;
            this.radioButtonHex.Text = "Hex";
            this.radioButtonHex.UseVisualStyleBackColor = true;
            // 
            // radioButtonDec
            // 
            this.radioButtonDec.AutoSize = true;
            this.radioButtonDec.Checked = true;
            this.radioButtonDec.Location = new System.Drawing.Point(81, 164);
            this.radioButtonDec.Name = "radioButtonDec";
            this.radioButtonDec.Size = new System.Drawing.Size(45, 19);
            this.radioButtonDec.TabIndex = 10;
            this.radioButtonDec.TabStop = true;
            this.radioButtonDec.Text = "Dec";
            this.radioButtonDec.UseVisualStyleBackColor = true;
            this.radioButtonDec.CheckedChanged += new System.EventHandler(this.radioButtonDec_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 265);
            this.Controls.Add(this.radioButtonDec);
            this.Controls.Add(this.radioButtonHex);
            this.Controls.Add(this.textBoxBlue);
            this.Controls.Add(this.textBoxGreen);
            this.Controls.Add(this.textboxRed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Лаба1.1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textboxRed;
        private TextBox textBoxGreen;
        private TextBox textBoxBlue;
        private RadioButton radioButtonHex;
        private RadioButton radioButtonDec;
        private Label labelerror;
    }
}