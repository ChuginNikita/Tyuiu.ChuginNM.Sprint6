using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ChuginNM.Sprint6.Task1.V12.Lib;

namespace Tyuiu.ChuginNM.Sprint6.Task1.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void ButtonResult_CNM_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                int startValue = Convert.ToInt32(textBoxVarA_CNM.Text);
                int stopValue = Convert.ToInt32(textBoxVarB_CNM.Text);

                string strLine;
                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startValue, stopValue);

                textBoxOutPut_CNM.Text = "";

                textBoxOutPut_CNM.AppendText("+---------+----------+" + Environment.NewLine);
                textBoxOutPut_CNM.AppendText("|    X    |     Y    |" + Environment.NewLine);
                textBoxOutPut_CNM.AppendText("+---------+----------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5}    |  {1, 6:f2}  |", startValue, valueArray[i]);
                    textBoxOutPut_CNM.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }
                textBoxOutPut_CNM.AppendText("+---------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_CNM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы АСОиУб-25-1 Чугин Никита Максимович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void groupBoxResult_CNM_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxInput_CNM(object sender, EventArgs e)
        {

        }

        private void groupBoxOutput_CNM(object sender, EventArgs e)
        {

        }
    }
}