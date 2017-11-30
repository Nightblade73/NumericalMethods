using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class FormKeys : Form
    {
        public FormKeys()
        {
            InitializeComponent();
        }
        public String DataBuffer = String.Empty;
        private void buttonKeysInput_Click(object sender, EventArgs e)
        {
            DataBuffer = textBox1.Text;
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
