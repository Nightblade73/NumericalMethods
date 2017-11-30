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
        string s = "";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {


            if (rBrand.Checked)
            {
                for (int i = Convert.ToInt32(textBoxFrom.Text); i <= Convert.ToInt32(textBoxTo.Text); i = i + 5)
                {
                    textBox1.Text += cm.Randomize(i);
                    textBox1.Text += Environment.NewLine;
                    textBox1.Text += cm.Factorization() + Environment.NewLine;
                    textBox1.Text += ("detA = " + Environment.NewLine + cm.Determ(cm.ULGetter) + Environment.NewLine);
                    // textBox1.Text += ("Вектор b = " + cm.ResultX(cm.MatrixProduct(cm.AGetter, x)) + Environment.NewLine);
                    textBox1.Text += ("Вектор x до = " + cm.ResultX(cm.FindMatrixX(cm.L_Getter, cm.FindMatrixW(cm.UGetter, cm.MatrixProduct(cm.AGetter, cm.XGetter)))));
                    textBox1.Text += ("Вектор x после = " + cm.ResultX(cm.FindMatrixW(cm.UGetter, cm.MatrixProduct(cm.AGetter, cm.XGetter))));


                    // textBox1.Text += ("U = \r\n" + cm.Result(cm.UGetter) + Environment.NewLine + "L_ = \r\n" + cm.Result(cm.L_Getter));
                    textBox1.Text += ("Обратная матрица = " + Environment.NewLine + cm.Result(cm.Inversion(cm.L_Getter, cm.UGetter)) + Environment.NewLine);
                    // textBox1.Text += ("Проверка " + cm.Result(cm.MatrixProductS(cm.AGetter, cm.Inversion(cm.L_Getter, cm.UGetter))));
                    textBox1.Text += ("Погрешность " + cm.Delta(cm.AGetter, cm.AInverseGetter, cm.IGetter) + '\t');
                    textBox1.Text += ("Погрешность x = " + cm.DeltaX(cm.FindMatrixX(cm.L_Getter, cm.FindMatrixW(cm.UGetter, cm.MatrixProduct(cm.AGetter, cm.XGetter))), cm.XGetter) + Environment.NewLine);
                }
            }
            if (rBkeys.Checked)
            {


            }
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rBkeys_CheckedChanged(object sender, EventArgs e)
        {
            buttonCompute.Enabled = false;
            buttonInputMatrix.Enabled = true;
            textBoxFrom.Enabled = false;
            textBoxTo.Enabled = false;
        }

        private void rBrand_CheckedChanged(object sender, EventArgs e)
        {
            buttonCompute.Enabled = true;
            buttonInputMatrix.Enabled = false;
            textBoxFrom.Enabled = true;
            textBoxTo.Enabled = true;
        }

        private void buttonInputMatrix_Click(object sender, EventArgs e)
        {
            FormKeys fk = new FormKeys();
            fk.Show();
            fk.FormClosing += (sender1, e1) =>
            {
                s = fk.DataBuffer;
                buttonCompute.Enabled = true;
                textBox1.Text += s;

                textBox1.Text += Environment.NewLine;

                s = s.Replace("\r", "");
                //s = s.Replace(" ", "");
                String[] S = s.Split('\n');
               


                double[,] mas = new double[S.Length, S.Length];
                try
                {
                    for (int i = 0; i < S.Length; i++)
                    {
                        String [] str = S[i].Split(' ');
                        for (int j = 0; j < str.Length; j++)
                        {
                            mas[i, j] = Double.Parse(str[j]);
                            textBox1.Text += mas[i, j];
                        }
                        textBox1.Text += Environment.NewLine;
                    }
            }
                catch
            {
                MessageBox.Show("Матрица не квадратная");
            }

        };
        }

    }
}
