using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        double[,] mas;
        List<double> xDeltaList = new List<double>();
        List<double> matrixDeltaList = new List<double>();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {


            if (rBrand.Checked)
            {
                textBox1.Clear();
                xDeltaList.Clear();
                matrixDeltaList.Clear();
                if (textBoxFrom.Text == "" || textBoxTo.Text == "") { MessageBox.Show("Поля не заполнены"); return; }
                for (int i = Convert.ToInt32(textBoxFrom.Text); i <= Convert.ToInt32(textBoxTo.Text); i = i + 5)
                {
                    //textBox1.Text += "Матрица А: " + Environment.NewLine;

                     cm.Randomize(i);
                    showResults();
                    
                    //textBox1.Text += Environment.NewLine;
                    //textBox1.Text += "Разложение UL:" + Environment.NewLine + cm.Factorization() + Environment.NewLine;
                    //textBox1.Text += ("detA = " + cm.Determ(cm.ULGetter) + Environment.NewLine);
                    //textBox1.Text += ("Вектор x до = " + cm.ResultX(cm.XGetter) + Environment.NewLine);
                    //cm.XDefined = cm.FindMatrixX(cm.L_Getter, cm.FindMatrixW(cm.UGetter, cm.MatrixProduct(cm.AGetter, cm.XGetter)));
                    //textBox1.Text += ("Вектор x после = " + cm.ResultX(cm.XDefined) + Environment.NewLine);
                    //textBox1.Text += ("Обратная матрица: " + Environment.NewLine + cm.Result(cm.Inversion(cm.L_Getter, cm.UGetter)) + Environment.NewLine);
                    //cm.XDelta = cm.DeltaX(cm.XDefined, cm.XGetter);
                    //cm.MatrixDelta = cm.Delta(cm.AGetter, cm.AInverseGetter, cm.IGetter);
                    //xDeltaList.Add(cm.XDelta);
                    //matrixDeltaList.Add(cm.MatrixDelta);
                    //textBox1.Text += ("Погрешность " + cm.MatrixDelta + '\t');
                    //textBox1.Text += ("Погрешность x = " + cm.XDelta + Environment.NewLine);
                    //textBox1.Text += Environment.NewLine;
                }
            }
            if (rBkeys.Checked)
            {

                cm.FromKeys(mas);
                showResultsSimple();
               

            }
            if (radioButtonBadMatrix.Checked)
            {
                textBox1.Clear();
                xDeltaList.Clear();
                matrixDeltaList.Clear();
                IllConditionedMatrix icm = new IllConditionedMatrix();
                switch (comboBoxBadMatrix.SelectedIndex)
                {

                    case 0:
                        if (textBoxFrom.Text == "" || textBoxTo.Text == "") { MessageBox.Show("Поля не заполнены"); return; }
                        for (int i = Convert.ToInt32(textBoxFrom.Text); i <= Convert.ToInt32(textBoxTo.Text); i = i + 5)
                        {
                            cm.FromKeys(icm.Gilbert(i));
                            showResults();
                        }
                        break;
                    case 1:
                        //строгозабитая
                        cm.FromKeys(icm.Matrix1());
                        showResultsSimple();
                        break;
                    case 2:
                        //строгозабитая
                        cm.FromKeys(icm.Matrix2());
                        showResultsSimple();
                        break;
                    case 3:
                        if (textBoxFrom.Text == "" || textBoxTo.Text == "") { MessageBox.Show("Поля не заполнены"); return; }
                        for (int i = Convert.ToInt32(textBoxFrom.Text); i <= Convert.ToInt32(textBoxTo.Text); i = i + 5)
                        {

                            cm.FromKeys(icm.Matrix3(i));
                            showResults();
                        }
                        break;
                    case 4:
                        if (textBoxFrom.Text == "" || textBoxTo.Text == "") { MessageBox.Show("Поля не заполнены"); return; }

                        for (int i = Convert.ToInt32(textBoxFrom.Text); i <= Convert.ToInt32(textBoxTo.Text); i = i + 5)
                        {

                            cm.FromKeys(icm.Matrix4(i));
                            showResults();
                        }

                        break;
                    case 5:
                        //строгозабитая размер = 8
                        if (textBoxArg.Text == "") { MessageBox.Show("Введите аргумент"); return; }
                        cm.FromKeys(icm.Matrix5(Double.Parse(textBoxArg.Text)));
                        showResultsSimple();
                        break;
                    case 6:
                        if (textBoxFrom.Text == "" || textBoxTo.Text == "") { MessageBox.Show("Поля не заполнены"); return; }
                        if (textBoxArg.Text == "") { MessageBox.Show("Введите аргумент"); return; }
                        for (int i = Convert.ToInt32(textBoxFrom.Text); i <= Convert.ToInt32(textBoxTo.Text); i = i + 5)
                        {

                            cm.FromKeys(icm.Matrix6(i, Double.Parse(textBoxArg.Text)));
                            showResults();
                        }
                        break;
                    case 7:
                        if (textBoxFrom.Text == "" || textBoxTo.Text == "") { MessageBox.Show("Поля не заполнены"); return; }
                        if (textBoxArg.Text == "") { MessageBox.Show("Введите аргумент"); return; }
                        for (int i = Convert.ToInt32(textBoxFrom.Text); i <= Convert.ToInt32(textBoxTo.Text); i = i + 5)
                        {

                            cm.FromKeys(icm.Matrix7(i, Double.Parse(textBoxArg.Text)));
                            showResults();
                        }
                        break;
                    case 8:
                        if (textBoxFrom.Text == "" || textBoxTo.Text == "") { MessageBox.Show("Поля не заполнены"); return; }
                        if (textBoxArg.Text == "") { MessageBox.Show("Введите аргумент"); return; }

                        for (int i = Convert.ToInt32(textBoxFrom.Text); i <= Convert.ToInt32(textBoxTo.Text); i = i + 5)
                        {

                            cm.FromKeys(icm.Matrix8(i, Double.Parse(textBoxArg.Text)));
                            showResults();
                        }
                        break;
                    case 9:
                        //строгозабитая

                        cm.FromKeys(icm.Matrix9());
                        showResultsSimple();
                        break;


                }


            }
        }

        public void showResults()
        {

            textBox1.Text += "Матрица А: " + Environment.NewLine;
            textBox1.Text += cm.Result(cm.AGetter);
            textBox1.Text += "Разложение UL:" + Environment.NewLine + cm.Factorization() + Environment.NewLine;
            textBox1.Text += ("detA = " + cm.Determ(cm.ULGetter) + Environment.NewLine);
            textBox1.Text += ("Вектор x до = " + cm.ResultX(cm.XGetter) + Environment.NewLine);
            cm.XDefined = cm.FindMatrixX(cm.L_Getter, cm.FindMatrixW(cm.UGetter, cm.MatrixProduct(cm.AGetter, cm.XGetter)));
            textBox1.Text += ("Вектор x после = " + cm.ResultX(cm.XDefined) + Environment.NewLine);
            textBox1.Text += ("Обратная матрица: " + Environment.NewLine + cm.Result(cm.Inversion(cm.L_Getter, cm.UGetter)) + Environment.NewLine);
            cm.XDelta = cm.DeltaX(cm.XDefined, cm.XGetter);
            cm.MatrixDelta = cm.Delta(cm.AGetter, cm.AInverseGetter, cm.IGetter);
            xDeltaList.Add(cm.XDelta);
            matrixDeltaList.Add(cm.MatrixDelta);
            textBox1.Text += ("Погрешность " + cm.MatrixDelta + '\t');
            textBox1.Text += ("Погрешность x = " + cm.XDelta + Environment.NewLine);
            textBox1.Text += Environment.NewLine;
            textBox1.Text += ("Количество операций = " + cm.Count + Environment.NewLine);
            textBox1.Text += Environment.NewLine;

        }
        public void showResultsSimple()
        {
            textBox1.Text += "Матрица А: " + Environment.NewLine;
            textBox1.Text += cm.Result(cm.AGetter);
            textBox1.Text += "Разложение UL:" + Environment.NewLine + cm.Factorization() + Environment.NewLine;
            textBox1.Text += ("detA = " + cm.Determ(cm.ULGetter) + Environment.NewLine);
            textBox1.Text += ("Вектор x до = " + cm.ResultX(cm.XGetter) + Environment.NewLine);
            cm.XDefined = cm.FindMatrixX(cm.L_Getter, cm.FindMatrixW(cm.UGetter, cm.MatrixProduct(cm.AGetter, cm.XGetter)));
            textBox1.Text += ("Вектор x после = " + cm.ResultX(cm.XDefined) + Environment.NewLine);
            textBox1.Text += ("Обратная матрица: " + Environment.NewLine + cm.Result(cm.Inversion(cm.L_Getter, cm.UGetter)) + Environment.NewLine);
            cm.XDelta = cm.DeltaX(cm.XDefined, cm.XGetter);
            cm.MatrixDelta = cm.Delta(cm.AGetter, cm.AInverseGetter, cm.IGetter);
            textBox1.Text += ("Погрешность " + cm.MatrixDelta + '\t');
            textBox1.Text += ("Погрешность x = " + cm.XDelta + Environment.NewLine);
            textBox1.Text += Environment.NewLine;
            textBox1.Text += ("Количество операций = " + cm.Count + Environment.NewLine) ;
            textBox1.Text += Environment.NewLine;

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
            comboBoxBadMatrix.Enabled = false;
            buttonGraphics.Enabled = false;
        }

        private void rBrand_CheckedChanged(object sender, EventArgs e)
        {
            buttonCompute.Enabled = true;
            buttonInputMatrix.Enabled = false;
            textBoxFrom.Enabled = true;
            textBoxTo.Enabled = true;
            comboBoxBadMatrix.Enabled = false;
            buttonGraphics.Enabled = true;
        }

        private void buttonInputMatrix_Click(object sender, EventArgs e)
        {
            FormKeys fk = new FormKeys();
            textBox1.Clear();
            fk.Show();
            fk.FormClosing += (sender1, e1) =>
            {
                s = fk.DataBuffer;
                buttonCompute.Enabled = true;
                textBox1.Text += "Вы ввели: " + Environment.NewLine;
                textBox1.Text += s;
                textBox1.Text += Environment.NewLine;
                s = s.Replace("\r", "");
                String[] S = s.Split('\n');



                mas = new double[S.Length, S.Length];
                try
                {
                    for (int i = 0; i < S.Length; i++)
                    {
                        String[] str = S[i].Split(' ');
                        for (int j = 0; j < str.Length; j++)
                        {
                            mas[i, j] = Double.Parse(str[j]);

                        }

                    }
                }
                catch
                {
                    MessageBox.Show("Ошибка! Проверьте правильность ввода данных");
                }

            };
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {

                    sw.Write(textBox1.Text);
                    MessageBox.Show("Файл успешно сохранен");
                }
            }
        }

        private void buttonGraphics_Click(object sender, EventArgs e)
        {
            FormGraphics fg = new FormGraphics(xDeltaList, matrixDeltaList, Convert.ToInt32(textBoxFrom.Text));
            fg.Show();
        }

        private void radioButtonBadMatrix_CheckedChanged(object sender, EventArgs e)
        {
            buttonCompute.Enabled = true;
            textBoxFrom.Enabled = true;
            textBoxTo.Enabled = true;
            comboBoxBadMatrix.Enabled = true;
            buttonGraphics.Enabled = true;
            buttonInputMatrix.Enabled = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxBadMatrix_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBadMatrix.SelectedIndex == 5 || comboBoxBadMatrix.SelectedIndex == 6 || comboBoxBadMatrix.SelectedIndex == 7 || comboBoxBadMatrix.SelectedIndex == 8)
                textBoxArg.Enabled = true;
            else
            {
                textBoxArg.Enabled = false;
            }
            if (comboBoxBadMatrix.SelectedIndex == 1 || comboBoxBadMatrix.SelectedIndex == 2 || comboBoxBadMatrix.SelectedIndex == 5 || comboBoxBadMatrix.SelectedIndex == 9)
            {
                buttonGraphics.Enabled = false;
                textBoxFrom.Enabled = false;
                textBoxTo.Enabled = false;
            }
            else
            {
                textBoxFrom.Enabled = true;
                textBoxTo.Enabled = true;
                buttonGraphics.Enabled = true;
            }
        }
    }
}
