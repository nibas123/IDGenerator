namespace IDGenerator.Forms
{
    partial class GenerateDate
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.formattedDateTextBox = new System.Windows.Forms.TextBox();
            this.clipalert = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Checked = false;
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(16, 27);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(618, 53);
            this.dateTimePicker.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generate and copy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // formattedDateTextBox
            // 
            this.formattedDateTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formattedDateTextBox.Location = new System.Drawing.Point(16, 157);
            this.formattedDateTextBox.Name = "formattedDateTextBox";
            this.formattedDateTextBox.Size = new System.Drawing.Size(618, 34);
            this.formattedDateTextBox.TabIndex = 2;
            // 
            // clipalert
            // 
            this.clipalert.AutoSize = true;
            this.clipalert.Location = new System.Drawing.Point(38, 272);
            this.clipalert.Name = "clipalert";
            this.clipalert.Size = new System.Drawing.Size(0, 16);
            this.clipalert.TabIndex = 3;
            // 
            // GenerateDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 308);
            this.Controls.Add(this.clipalert);
            this.Controls.Add(this.formattedDateTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker);
            this.Name = "GenerateDate";
            this.Text = "GenerateDate";
            this.Load += new System.EventHandler(this.GenerateDate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox formattedDateTextBox;
        private System.Windows.Forms.Label clipalert;
    }
}