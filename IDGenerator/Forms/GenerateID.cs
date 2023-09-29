using IDGenerator.Dependencies;
using IDGenerator.Enums;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace IDGenerator.Forms
{

    public partial class GenerateID : Form
    {
        public GenerateID()
        {
            
            InitializeComponent();
            alphanum.Checked= true;
        }

        public int GetSelectedRadioButtonText()
        {
            int selectedValue =(int) IDType.Alphanumeric;
            if (alphanum.Checked)
            {
                selectedValue = (int)IDType.Alphanumeric;
            }
            else if (numeric.Checked)
            {
                selectedValue = (int)IDType.Numeric;
            }
            return selectedValue;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            var sizeofid=idsize.Text;
            IGuidGeneratorProxy Instanceidgen = new GuidGeneratorProxy();
            int selectedRadioButtonText = GetSelectedRadioButtonText();
            

            if (int.TryParse(sizeofid, out int desiredLength))
            {
                string instanceId = Instanceidgen.GenerateInstanceId(desiredLength, selectedRadioButtonText);
                generatedInstanceIdTextBox.Text = instanceId;
                Clipboard.SetText(instanceId);
                clipalert.Text = "Copied to Clipboard";
            }
            else
            {
                MessageBox.Show("Please enter a valid length for the instance ID.");
            }
        }

      }
    
}
