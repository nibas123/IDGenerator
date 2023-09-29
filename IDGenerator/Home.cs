using IDGenerator.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDGenerator
{
    public partial class Home : Form
    {

        public Home()
        {
            InitializeComponent();
            
        }

        private void genGuid_Click(object sender, EventArgs e)
        {
            var guidfrom = new GenerateGuid();
            guidfrom.Show();
            
        }

        private void genID_Click(object sender, EventArgs e)
        {
            var guidfrom = new GenerateID();
            guidfrom.Show();
        }

        private void GenDate_Click(object sender, EventArgs e)
        {
            var guidfrom = new GenerateDate();
            guidfrom.Show();
        }
    }
}
