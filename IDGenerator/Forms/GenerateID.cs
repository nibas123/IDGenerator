using IDGenerator.Dependencies;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDGenerator.Forms
{

    public partial class GenerateID : Form
    {
        public GenerateID()
        {
            
            InitializeComponent();
            
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            
            var sizeofid=idsize.Text;
            IGuidGeneratorProxy Instanceidgen = new GuidGeneratorProxy();

            if (int.TryParse(sizeofid, out int desiredLength))
            {
                string instanceId = Instanceidgen.GenerateInstanceId(desiredLength);
                generatedInstanceIdTextBox.Text = instanceId;
            }
            else
            {
                MessageBox.Show("Please enter a valid length for the instance ID.");
            }
        }
    }
    
}
