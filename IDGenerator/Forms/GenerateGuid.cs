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
    public partial class GenerateGuid : Form
    {
        public GenerateGuid()
        {
            InitializeComponent();
        }

        private void gGuid_Click(object sender, EventArgs e)
        {
            Guid guid = Guid.NewGuid();
            generatedGuidTextBox.Text = guid.ToString();
            Clipboard.SetText(generatedGuidTextBox.Text);
            clipboardconf.Text = "Copied to clipboard";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            var homeform = new Home();
            var guidform = new GenerateGuid();
            guidform.Dispose();
            homeform.Show();
        }
    }
}
