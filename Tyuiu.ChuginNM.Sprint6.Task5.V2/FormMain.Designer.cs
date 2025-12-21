using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.ChuginNM.Sprint6.Task5.V2.Lib;

namespace Tyuiu.ChuginNM.Sprint6.Task5.V2
{
    partial class FormMain
    {
        string originPath = Path.Combine(Path.GetTempPath(), "InPutFileTask5V2.txt");
        DataGridViewTextBoxColumn x = new DataGridViewTextBoxColumn();

        DataService ds = new DataService();

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            dataGridView_CNM = new DataGridView();
            groupNameBox_CNM = new GroupBox();
            textQuestionBox_CNM = new TextBox();
            groupGridBox_CNM = new GroupBox();
            negValueChart_CNM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonGroupBox_CNM = new GroupBox();
            buttonHelp_CNM = new Button();
            buttonOpenFile_CNM = new Button();
            buttonRun_CNM = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_CNM).BeginInit();
            groupNameBox_CNM.SuspendLayout();
            groupGridBox_CNM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)negValueChart_CNM).BeginInit();
            buttonGroupBox_CNM.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView_CNM
            // 
            dataGridView_CNM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_CNM.Columns.AddRange(new DataGridViewColumn[] { x });
            dataGridView_CNM.Location = new Point(6, 22);
            dataGridView_CNM.Name = "dataGridView_CNM";
            dataGridView_CNM.ReadOnly = true;
            dataGridView_CNM.ScrollBars = ScrollBars.Horizontal;
            dataGridView_CNM.Size = new Size(135, 320);
            dataGridView_CNM.TabIndex = 0;
            // 
            // groupNameBox_CNM
            // 
            groupNameBox_CNM.Controls.Add(textQuestionBox_CNM);
            groupNameBox_CNM.Location = new Point(12, 12);
            groupNameBox_CNM.Name = "groupNameBox_CNM";
            groupNameBox_CNM.Size = new Size(317, 72);
            groupNameBox_CNM.TabIndex = 1;
            groupNameBox_CNM.TabStop = false;
            groupNameBox_CNM.Text = "Условие:";
            // 
            // textQuestionBox_CNM
            // 
            textQuestionBox_CNM.BackColor = SystemColors.Menu;
            textQuestionBox_CNM.BorderStyle = BorderStyle.None;
            textQuestionBox_CNM.Location = new Point(6, 22);
            textQuestionBox_CNM.Multiline = true;
            textQuestionBox_CNM.Name = "textQuestionBox_CNM";
            textQuestionBox_CNM.ReadOnly = true;
            textQuestionBox_CNM.Size = new Size(305, 44);
            textQuestionBox_CNM.TabIndex = 0;
            textQuestionBox_CNM.TabStop = false;
            textQuestionBox_CNM.Text = "Прочитать данные из файла InPutFileTask5V2.txt. Вывести в dataGridView. Вывести все отрицательные числа. Построить диаграмму по этим значениям.";
            // 
            // groupGridBox_CNM
            // 
            groupGridBox_CNM.Controls.Add(dataGridView_CNM);
            groupGridBox_CNM.Location = new Point(12, 90);
            groupGridBox_CNM.Name = "groupGridBox_CNM";
            groupGridBox_CNM.Size = new Size(147, 348);
            groupGridBox_CNM.TabIndex = 2;
            groupGridBox_CNM.TabStop = false;
            groupGridBox_CNM.Text = "Вывод данных:";
            // 
            // negValueChart_CNM
            // 
            chartArea1.Name = "ChartArea1";
            negValueChart_CNM.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            negValueChart_CNM.Legends.Add(legend1);
            negValueChart_CNM.Location = new Point(165, 90);
            negValueChart_CNM.Name = "negValueChart_CNM";
            negValueChart_CNM.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Отриц. числа";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            negValueChart_CNM.Series.Add(series1);
            negValueChart_CNM.Size = new Size(547, 348);
            negValueChart_CNM.TabIndex = 1;
            negValueChart_CNM.Text = "График";
            // 
            // buttonGroupBox_CNM
            // 
            buttonGroupBox_CNM.Controls.Add(buttonHelp_CNM);
            buttonGroupBox_CNM.Controls.Add(buttonOpenFile_CNM);
            buttonGroupBox_CNM.Controls.Add(buttonRun_CNM);
            buttonGroupBox_CNM.Location = new Point(339, 12);
            buttonGroupBox_CNM.Name = "buttonGroupBox_CNM";
            buttonGroupBox_CNM.Size = new Size(373, 72);
            buttonGroupBox_CNM.TabIndex = 4;
            buttonGroupBox_CNM.TabStop = false;
            buttonGroupBox_CNM.Text = "groupBox1";
            // 
            // buttonHelp_CNM
            // 
            buttonHelp_CNM.BackColor = SystemColors.InactiveCaption;
            buttonHelp_CNM.Location = new Point(293, 18);
            buttonHelp_CNM.Name = "buttonHelp_CNM";
            buttonHelp_CNM.Size = new Size(74, 48);
            buttonHelp_CNM.TabIndex = 2;
            buttonHelp_CNM.Text = "Справка";
            buttonHelp_CNM.UseVisualStyleBackColor = false;
            buttonHelp_CNM.Click += ButtonHelp_CNM_Click;
            // 
            // buttonOpenFile_CNM
            // 
            buttonOpenFile_CNM.BackColor = SystemColors.Highlight;
            buttonOpenFile_CNM.Location = new Point(104, 18);
            buttonOpenFile_CNM.Name = "buttonOpenFile_CNM";
            buttonOpenFile_CNM.Size = new Size(183, 48);
            buttonOpenFile_CNM.TabIndex = 1;
            buttonOpenFile_CNM.Text = "Открыть файл";
            buttonOpenFile_CNM.UseVisualStyleBackColor = false;
            buttonOpenFile_CNM.Click += ButtonOpenFile_CNM_Click;
            // 
            // buttonRun_CNM
            // 
            buttonRun_CNM.BackColor = Color.Green;
            buttonRun_CNM.Location = new Point(6, 18);
            buttonRun_CNM.Name = "buttonRun_CNM";
            buttonRun_CNM.Size = new Size(92, 48);
            buttonRun_CNM.TabIndex = 0;
            buttonRun_CNM.Text = "Выполнить";
            buttonRun_CNM.UseVisualStyleBackColor = false;
            buttonRun_CNM.Click += ButtonRun_CNM_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 450);
            Controls.Add(buttonGroupBox_CNM);
            Controls.Add(negValueChart_CNM);
            Controls.Add(groupGridBox_CNM);
            Controls.Add(groupNameBox_CNM);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 2 | Чугин Н. М.";
            ((System.ComponentModel.ISupportInitialize)dataGridView_CNM).EndInit();
            groupNameBox_CNM.ResumeLayout(false);
            groupNameBox_CNM.PerformLayout();
            groupGridBox_CNM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)negValueChart_CNM).EndInit();
            buttonGroupBox_CNM.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void ButtonOpenFile_CNM_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    originPath = openFileDialog.FileName;
                    MessageBox.Show("Выбран файл: " + originPath.ToString());
                }
            }
        }

        private void ButtonHelp_CNM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы АСОиУб-25-1 Чугин Никита");
        }

        private void ButtonRun_CNM_Click(object sender, EventArgs e)
        {
            var data = ds.LoadFromDataFile(originPath);
            dataGridView_CNM.Rows.Clear();
            foreach (double number in data)
            {
                if (number < 0) { dataGridView_CNM.Rows.Add(number); } 
            }
            negValueChart_CNM.Series.Clear();
            Series series = new Series
            {
                Name = "Отрицательные числа",
                IsVisibleInLegend = false,
                ChartType = SeriesChartType.Column
            };

            foreach (double number in data)
            {
                if (number < 0)
                {
                    series.Points.Add(number);
                }
            }

            negValueChart_CNM.Series.Add(series);
        }

        #endregion
        private DataGridView dataGridView_CNM;
        private GroupBox groupNameBox_CNM;
        private TextBox textQuestionBox_CNM;
        private GroupBox groupGridBox_CNM;
        private System.Windows.Forms.DataVisualization.Charting.Chart negValueChart_CNM;
        private GroupBox buttonGroupBox_CNM;
        private Button buttonHelp_CNM;
        private Button buttonOpenFile_CNM;
        private Button buttonRun_CNM;
    }
}
