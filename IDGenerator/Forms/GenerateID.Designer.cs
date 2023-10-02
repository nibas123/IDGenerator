﻿using IDGenerator.Enums;

namespace IDGenerator.Forms
{
    partial class GenerateID
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
            this.button1 = new System.Windows.Forms.Button();
            this.generatedInstanceIdTextBox = new System.Windows.Forms.TextBox();
            this.idsize = new System.Windows.Forms.TextBox();
            this.idtype = new System.Windows.Forms.GroupBox();
            this.lcase = new System.Windows.Forms.RadioButton();
            this.Ucase = new System.Windows.Forms.RadioButton();
            this.mixed = new System.Windows.Forms.RadioButton();
            this.numeric = new System.Windows.Forms.RadioButton();
            this.alphanum = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.clipalert = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idtype.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate and Copy to Clipboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // generatedInstanceIdTextBox
            // 
            this.generatedInstanceIdTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatedInstanceIdTextBox.Location = new System.Drawing.Point(148, 177);
            this.generatedInstanceIdTextBox.Name = "generatedInstanceIdTextBox";
            this.generatedInstanceIdTextBox.Size = new System.Drawing.Size(312, 30);
            this.generatedInstanceIdTextBox.TabIndex = 1;
            // 
            // idsize
            // 
            this.idsize.Location = new System.Drawing.Point(117, 59);
            this.idsize.Name = "idsize";
            this.idsize.Size = new System.Drawing.Size(25, 22);
            this.idsize.TabIndex = 2;
            // 
            // idtype
            // 
            this.idtype.Controls.Add(this.lcase);
            this.idtype.Controls.Add(this.Ucase);
            this.idtype.Controls.Add(this.mixed);
            this.idtype.Controls.Add(this.numeric);
            this.idtype.Controls.Add(this.alphanum);
            this.idtype.Location = new System.Drawing.Point(15, 97);
            this.idtype.Name = "idtype";
            this.idtype.Size = new System.Drawing.Size(635, 58);
            this.idtype.TabIndex = 3;
            this.idtype.TabStop = false;
            this.idtype.Text = "Type of ID";
            // 
            // lcase
            // 
            this.lcase.AutoSize = true;
            this.lcase.Location = new System.Drawing.Point(378, 21);
            this.lcase.Name = "lcase";
            this.lcase.Size = new System.Drawing.Size(94, 20);
            this.lcase.TabIndex = 4;
            this.lcase.TabStop = true;
            this.lcase.Text = "Lowercase";
            this.lcase.UseVisualStyleBackColor = true;
            this.lcase.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // Ucase
            // 
            this.Ucase.AutoSize = true;
            this.Ucase.Location = new System.Drawing.Point(255, 21);
            this.Ucase.Name = "Ucase";
            this.Ucase.Size = new System.Drawing.Size(96, 20);
            this.Ucase.TabIndex = 3;
            this.Ucase.TabStop = true;
            this.Ucase.Text = "Uppercase";
            this.Ucase.UseVisualStyleBackColor = true;
            // 
            // mixed
            // 
            this.mixed.AutoSize = true;
            this.mixed.Location = new System.Drawing.Point(15, 21);
            this.mixed.Name = "mixed";
            this.mixed.Size = new System.Drawing.Size(117, 20);
            this.mixed.TabIndex = 2;
            this.mixed.TabStop = true;
            this.mixed.Text = "Alpha-Numeric";
            this.mixed.UseVisualStyleBackColor = true;
            // 
            // numeric
            // 
            this.numeric.AutoSize = true;
            this.numeric.Location = new System.Drawing.Point(147, 21);
            this.numeric.Name = "numeric";
            this.numeric.Size = new System.Drawing.Size(78, 20);
            this.numeric.TabIndex = 1;
            this.numeric.TabStop = true;
            this.numeric.Text = "Numeric";
            this.numeric.UseVisualStyleBackColor = true;
            // 
            // alphanum
            // 
            this.alphanum.AutoSize = true;
            this.alphanum.Location = new System.Drawing.Point(493, 21);
            this.alphanum.Name = "alphanum";
            this.alphanum.Size = new System.Drawing.Size(136, 20);
            this.alphanum.TabIndex = 0;
            this.alphanum.TabStop = true;
            this.alphanum.Text = "Mixed Alpahabets";
            this.alphanum.UseMnemonic = false;
            this.alphanum.UseVisualStyleBackColor = true;
            this.alphanum.CheckedChanged += new System.EventHandler(this.alphanum_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Size of the ID";
            // 
            // clipalert
            // 
            this.clipalert.AutoSize = true;
            this.clipalert.Location = new System.Drawing.Point(310, 158);
            this.clipalert.Name = "clipalert";
            this.clipalert.Size = new System.Drawing.Size(0, 16);
            this.clipalert.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Liberation Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID Generator";
            // 
            // GenerateID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 238);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clipalert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idtype);
            this.Controls.Add(this.idsize);
            this.Controls.Add(this.generatedInstanceIdTextBox);
            this.Controls.Add(this.button1);
            this.Name = "GenerateID";
            this.Text = "GenerateID";
            this.idtype.ResumeLayout(false);
            this.idtype.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox generatedInstanceIdTextBox;
        private System.Windows.Forms.TextBox idsize;
        private System.Windows.Forms.GroupBox idtype;
        private System.Windows.Forms.RadioButton numeric;
        private System.Windows.Forms.RadioButton alphanum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label clipalert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton lcase;
        private System.Windows.Forms.RadioButton Ucase;
        private System.Windows.Forms.RadioButton mixed;
    }
}