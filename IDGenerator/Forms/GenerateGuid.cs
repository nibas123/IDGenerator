using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private void kafakdata_Click(object sender, EventArgs e)
        {
            Guid guidk = Guid.NewGuid();
            //var jsonObject = new
            //{
            //    "x-paymenthub-correlation-id" : "+ guidk.ToString();
            //};

            // Serialize the anonymous object to JSON
            string jsonString = System.Text.Json.JsonSerializer.Serialize(jsonObject, new JsonSerializerOptions
            {
                WriteIndented = true // Enable pretty printing
            }); 
            richTextBox1.Text = jsonString;
            Clipboard.SetText(jsonString);
            cpy.Text = "Copied to clipboard";
        }
    }
}
