namespace IDGenerator.Forms
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.kafakdata = new System.Windows.Forms.Button();
            this.cpy = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(61, 235);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(575, 82);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // kafakdata
            // 
            this.kafakdata.Location = new System.Drawing.Point(290, 335);
            this.kafakdata.Name = "kafakdata";
            this.kafakdata.Size = new System.Drawing.Size(135, 45);
            this.kafakdata.TabIndex = 6;
            this.kafakdata.Text = "Generate New";
            this.kafakdata.UseVisualStyleBackColor = true;
            this.kafakdata.Click += new System.EventHandler(this.kafakdata_Click);
            // 
            // cpy
            // 
            this.cpy.AutoSize = true;
            this.cpy.Location = new System.Drawing.Point(58, 320);
            this.cpy.Name = "cpy";
            this.cpy.Size = new System.Drawing.Size(0, 16);
            this.cpy.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "x-paymenthub-correlation-id for kafka";
            // 
            // GenerateGuid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 392);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cpy);
            this.Controls.Add(this.kafakdata);
            this.Controls.Add(this.richTextBox1);
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
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button kafakdata;
        private System.Windows.Forms.Label cpy;
        private System.Windows.Forms.Label label3;
    }
}