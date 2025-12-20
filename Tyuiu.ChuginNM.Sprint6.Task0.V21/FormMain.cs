using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ChuginNM.Sprint6.Task0.V21.Lib;
namespace Tyuiu.ChuginNM.Sprint6.Task0.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDONE_CNM_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();

            try
            {
                textBoxResult_CNM.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxAnswer_CNM.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void textBoxAnswer_CNM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 10 || e.KeyChar >= 70) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonHELP_CNM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы АСОиУб-25-1 Чугин Никита", "Сообщение");
        }
    }
}