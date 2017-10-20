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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ClassMatrix cm = new ClassMatrix();

        private void button1_Click(object sender, EventArgs e)
        {
            
          
            textBox1.Text = cm.Randomize(5);



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += Environment.NewLine;
            textBox1.Text += cm.Factorization();

        }
        double[] b = { 1, 2, 3, 4 };
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += ("detA = " + cm.Determ(cm.AGetter));
            textBox1.Text += (cm.HelperSolve(cm.ULGetter, b));
        }
    }
}
