namespace IDGenerator
{
    partial class Home
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
            this.genguid = new System.Windows.Forms.Button();
            this.genID = new System.Windows.Forms.Button();
            this.GenDate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // genguid
            // 
            this.genguid.Location = new System.Drawing.Point(297, 79);
            this.genguid.Name = "genguid";
            this.genguid.Size = new System.Drawing.Size(185, 55);
            this.genguid.TabIndex = 0;
            this.genguid.Text = "Generate GUID ";
            this.genguid.UseVisualStyleBackColor = true;
            this.genguid.Click += new System.EventHandler(this.genGuid_Click);
            // 
            // genID
            // 
            this.genID.Location = new System.Drawing.Point(297, 170);
            this.genID.Name = "genID";
            this.genID.Size = new System.Drawing.Size(194, 64);
            this.genID.TabIndex = 1;
            this.genID.Text = "Generate ID";
            this.genID.UseVisualStyleBackColor = true;
            this.genID.Click += new System.EventHandler(this.genID_Click);
            // 
            // GenDate
            // 
            this.GenDate.Location = new System.Drawing.Point(297, 271);
            this.GenDate.Name = "GenDate";
            this.GenDate.Size = new System.Drawing.Size(194, 64);
            this.GenDate.TabIndex = 2;
            this.GenDate.Text = "Generate Date";
            this.GenDate.UseVisualStyleBackColor = true;
            this.GenDate.Click += new System.EventHandler(this.GenDate_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GenDate);
            this.Controls.Add(this.genID);
            this.Controls.Add(this.genguid);
            this.Name = "Home";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button genguid;
        private System.Windows.Forms.Button genID;
        private System.Windows.Forms.Button GenDate;
    }
}

