using IDGenerator.Dependencies;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDGenerator.Forms
{
    public partial class GenerateDate : Form
    {
        public GenerateDate()
        {
            InitializeComponent();

            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "ddd dd MMM yyyy:hh mm sss";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateGeneratorProxy FormatDateproxy = new DateGeneratorProxy();
            
            DateTime selectedDateTime = dateTimePicker.Value;
            string formattedDate = FormatDateproxy.FormatDate(selectedDateTime);
            formattedDateTextBox.Text = formattedDate;
            Clipboard.SetText(formattedDate);
            clipalert.Text = "Copied to Clipboard";
        }
    }
}
