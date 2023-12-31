﻿namespace IDGenerator.Forms
{
    partial class GenerateGuid
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
            this.generatedGuidTextBox = new System.Windows.Forms.TextBox();
            this.gGuid = new System.Windows.Forms.Button();
            this.clipboardconf = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // generatedGuidTextBox
            // 
            this.generatedGuidTextBox.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatedGuidTextBox.Location = new System.Drawing.Point(24, 88);
            this.generatedGuidTextBox.Name = "generatedGuidTextBox";
            this.generatedGuidTextBox.Size = new System.Drawing.Size(651, 39);
            this.generatedGuidTextBox.TabIndex = 0;
            // 
            // gGuid
            // 
            this.gGuid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gGuid.Location = new System.Drawing.Point(147, 150);
            this.gGuid.Name = "gGuid";
            this.gGuid.Size = new System.Drawing.Size(383, 45);
            this.gGuid.TabIndex = 1;
            this.gGuid.Text = "Generate and Copy to clipboard";
            this.gGuid.UseVisualStyleBackColor = true;
            this.gGuid.Click += new System.EventHandler(this.gGuid_Click);
            // 
            // clipboardconf
            // 
            this.clipboardconf.AutoSize = true;
            this.clipboardconf.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clipboardconf.Location = new System.Drawing.Point(21, 70);
            this.clipboardconf.Name = "clipboardconf";
            this.clipboardconf.Size = new System.Drawing.Size(0, 16);
            this.clipboardconf.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "GUID Generator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "HOME";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // GenerateGuid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 220);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clipboardconf);
            this.Controls.Add(this.gGuid);
            this.Controls.Add(this.generatedGuidTextBox);
            this.Name = "GenerateGuid";
            this.Text = "GenerateGuid";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox generatedGuidTextBox;
        private System.Windows.Forms.Button gGuid;
        private System.Windows.Forms.Label clipboardconf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}