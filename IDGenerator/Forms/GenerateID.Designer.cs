using IDGenerator.Enums;

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
            this.numeric = new System.Windows.Forms.RadioButton();
            this.alphanum = new System.Windows.Forms.RadioButton();
            this.idtype.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate and Copy to Clipboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // generatedInstanceIdTextBox
            // 
            this.generatedInstanceIdTextBox.Location = new System.Drawing.Point(117, 103);
            this.generatedInstanceIdTextBox.Name = "generatedInstanceIdTextBox";
            this.generatedInstanceIdTextBox.Size = new System.Drawing.Size(312, 22);
            this.generatedInstanceIdTextBox.TabIndex = 1;
            // 
            // idsize
            // 
            this.idsize.Location = new System.Drawing.Point(117, 47);
            this.idsize.Name = "idsize";
            this.idsize.Size = new System.Drawing.Size(86, 22);
            this.idsize.TabIndex = 2;
            // 
            // idtype
            // 
            this.idtype.Controls.Add(this.numeric);
            this.idtype.Controls.Add(this.alphanum);
            this.idtype.Location = new System.Drawing.Point(447, 28);
            this.idtype.Name = "idtype";
            this.idtype.Size = new System.Drawing.Size(257, 58);
            this.idtype.TabIndex = 3;
            this.idtype.TabStop = false;
            this.idtype.Text = "Type of ID";
            // 
            // numeric
            // 
            this.numeric.AutoSize = true;
            this.numeric.Location = new System.Drawing.Point(165, 21);
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
            this.alphanum.Location = new System.Drawing.Point(21, 21);
            this.alphanum.Name = "alphanum";
            this.alphanum.Size = new System.Drawing.Size(116, 20);
            this.alphanum.TabIndex = 0;
            this.alphanum.TabStop = true;
            this.alphanum.Text = "Alpha Numeric";
            this.alphanum.UseMnemonic = false;
            this.alphanum.UseVisualStyleBackColor = true;
            // 
            // GenerateID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 171);
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
    }
}