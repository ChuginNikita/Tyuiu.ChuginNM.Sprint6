using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.ChuginNM.Sprint6.Task4.V1.Lib;

namespace Tyuiu.ChuginNM.Sprint6.Task4.V1
{
    partial class FormMain
    {
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            textGroupBox_CNM = new GroupBox();
            answerTextBox_CNM = new TextBox();
            questionGroupBox_CNM = new GroupBox();
            questionBox_CNM = new TextBox();
            funcChart_CNM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonGroupBox_CNM = new GroupBox();
            buttonHelp_CNM = new Button();
            buttonSave_CNM = new Button();
            buttonRun_CNM = new Button();
            startStepInputText_CNM = new TextBox();
            endStepInputText_CNM = new TextBox();
            endStepText_CNM = new TextBox();
            stepStartText_CNM = new TextBox();
            textGroupBox_CNM.SuspendLayout();
            questionGroupBox_CNM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)funcChart_CNM).BeginInit();
            buttonGroupBox_CNM.SuspendLayout();
            SuspendLayout();
            // 
            // textGroupBox_CNM
            // 
            textGroupBox_CNM.Controls.Add(answerTextBox_CNM);
            textGroupBox_CNM.Location = new Point(12, 91);
            textGroupBox_CNM.Name = "textGroupBox_CNM";
            textGroupBox_CNM.Size = new Size(225, 347);
            textGroupBox_CNM.TabIndex = 0;
            textGroupBox_CNM.TabStop = false;
            textGroupBox_CNM.Text = "Вывод";
            // 
            // answerTextBox_CNM
            // 
            answerTextBox_CNM.Location = new Point(6, 22);
            answerTextBox_CNM.Multiline = true;
            answerTextBox_CNM.Name = "answerTextBox_CNM";
            answerTextBox_CNM.Size = new Size(213, 319);
            answerTextBox_CNM.TabIndex = 0;
            // 
            // questionGroupBox_CNM
            // 
            questionGroupBox_CNM.Controls.Add(questionBox_CNM);
            questionGroupBox_CNM.Location = new Point(12, 12);
            questionGroupBox_CNM.Name = "questionGroupBox_CNM";
            questionGroupBox_CNM.Size = new Size(225, 73);
            questionGroupBox_CNM.TabIndex = 1;
            questionGroupBox_CNM.TabStop = false;
            questionGroupBox_CNM.Text = "Условие";
            // 
            // questionBox_CNM
            // 
            questionBox_CNM.BackColor = SystemColors.Control;
            questionBox_CNM.BorderStyle = BorderStyle.None;
            questionBox_CNM.Location = new Point(6, 22);
            questionBox_CNM.Multiline = true;
            questionBox_CNM.Name = "questionBox_CNM";
            questionBox_CNM.Size = new Size(213, 45);
            questionBox_CNM.TabIndex = 0;
            questionBox_CNM.Text = "Протабулировать функцию f(x) на заданном диапазоне, построить график и записать в файл.\r\n";
            // 
            // funcChart_CNM
            // 
            chartArea2.Name = "ChartArea1";
            funcChart_CNM.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            funcChart_CNM.Legends.Add(legend2);
            funcChart_CNM.Location = new Point(243, 91);
            funcChart_CNM.Name = "funcChart_CNM";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.ChartType = SeriesChartType.Line;
            funcChart_CNM.Series.Add(series2);
            funcChart_CNM.Size = new Size(495, 347);
            funcChart_CNM.TabIndex = 2;
            funcChart_CNM.Text = "chart1";
            // 
            // buttonGroupBox_CNM
            // 
            buttonGroupBox_CNM.Controls.Add(buttonHelp_CNM);
            buttonGroupBox_CNM.Controls.Add(buttonSave_CNM);
            buttonGroupBox_CNM.Controls.Add(buttonRun_CNM);
            buttonGroupBox_CNM.Controls.Add(startStepInputText_CNM);
            buttonGroupBox_CNM.Controls.Add(endStepInputText_CNM);
            buttonGroupBox_CNM.Controls.Add(endStepText_CNM);
            buttonGroupBox_CNM.Controls.Add(stepStartText_CNM);
            buttonGroupBox_CNM.Location = new Point(243, 12);
            buttonGroupBox_CNM.Name = "buttonGroupBox_CNM";
            buttonGroupBox_CNM.Size = new Size(495, 73);
            buttonGroupBox_CNM.TabIndex = 2;
            buttonGroupBox_CNM.TabStop = false;
            buttonGroupBox_CNM.Text = "Управление";
            // 
            // buttonHelp_CNM
            // 
            buttonHelp_CNM.BackColor = Color.FromArgb(128, 255, 255);
            buttonHelp_CNM.Location = new Point(420, 19);
            buttonHelp_CNM.Name = "buttonHelp_CNM";
            buttonHelp_CNM.Size = new Size(69, 45);
            buttonHelp_CNM.TabIndex = 6;
            buttonHelp_CNM.Text = "Справка";
            buttonHelp_CNM.UseVisualStyleBackColor = false;
            buttonHelp_CNM.Click += ButtonHelp_CNM_Click;
            // 
            // buttonSave_CNM
            // 
            buttonSave_CNM.BackColor = Color.Blue;
            buttonSave_CNM.Location = new Point(314, 19);
            buttonSave_CNM.Name = "buttonSave_CNM";
            buttonSave_CNM.Size = new Size(100, 45);
            buttonSave_CNM.TabIndex = 5;
            buttonSave_CNM.Text = "Сохранить";
            buttonSave_CNM.UseVisualStyleBackColor = false;
            buttonSave_CNM.Click += ButtonSave_CNM_Click;
            // 
            // buttonRun_CNM
            // 
            buttonRun_CNM.BackColor = Color.Lime;
            buttonRun_CNM.Location = new Point(203, 19);
            buttonRun_CNM.Name = "buttonRun_CNM";
            buttonRun_CNM.Size = new Size(105, 45);
            buttonRun_CNM.TabIndex = 4;
            buttonRun_CNM.Text = "Выполнить";
            buttonRun_CNM.UseVisualStyleBackColor = false;
            buttonRun_CNM.Click += ButtonRun_CNM_Click;
            // 
            // startStepInputText_CNM
            // 
            startStepInputText_CNM.Location = new Point(97, 19);
            startStepInputText_CNM.Name = "startStepInputText_CNM";
            startStepInputText_CNM.Size = new Size(100, 23);
            startStepInputText_CNM.TabIndex = 3;
            // 
            // endStepInputText_CNM
            // 
            endStepInputText_CNM.Location = new Point(97, 41);
            endStepInputText_CNM.Name = "endStepInputText_CNM";
            endStepInputText_CNM.Size = new Size(100, 23);
            endStepInputText_CNM.TabIndex = 2;
            // 
            // endStepText_CNM
            // 
            endStepText_CNM.BackColor = SystemColors.Control;
            endStepText_CNM.BorderStyle = BorderStyle.None;
            endStepText_CNM.Location = new Point(6, 44);
            endStepText_CNM.Name = "endStepText_CNM";
            endStepText_CNM.ReadOnly = true;
            endStepText_CNM.Size = new Size(85, 16);
            endStepText_CNM.TabIndex = 1;
            endStepText_CNM.Text = "Конец шага:";
            // 
            // stepStartText_CNM
            // 
            stepStartText_CNM.BackColor = SystemColors.Control;
            stepStartText_CNM.BorderStyle = BorderStyle.None;
            stepStartText_CNM.Location = new Point(6, 22);
            stepStartText_CNM.Name = "stepStartText_CNM";
            stepStartText_CNM.ReadOnly = true;
            stepStartText_CNM.Size = new Size(85, 16);
            stepStartText_CNM.TabIndex = 0;
            stepStartText_CNM.Text = "Начало шага:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 450);
            Controls.Add(buttonGroupBox_CNM);
            Controls.Add(funcChart_CNM);
            Controls.Add(questionGroupBox_CNM);
            Controls.Add(textGroupBox_CNM);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 4 | Вариант 1 | Чугин Н. М.";
            textGroupBox_CNM.ResumeLayout(false);
            textGroupBox_CNM.PerformLayout();
            questionGroupBox_CNM.ResumeLayout(false);
            questionGroupBox_CNM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)funcChart_CNM).EndInit();
            buttonGroupBox_CNM.ResumeLayout(false);
            buttonGroupBox_CNM.PerformLayout();
            ResumeLayout(false);
        }

        private void ButtonSave_CNM_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask4V1.txt");
            File.WriteAllText(path, answerTextBox_CNM.Text);

            MessageBox.Show("Файл сохранен в папке: " + path.ToString());
        }

        private void ButtonRun_CNM_Click(object sender, EventArgs e)
        {
            funcChart_CNM.Series[0].Points.Clear();
            int startValue = Convert.ToInt32(startStepInputText_CNM.Text.ToString());
            int stopValue = Convert.ToInt32(endStepInputText_CNM.Text.ToString());
            funcChart_CNM.Series[0].Points.Clear();

            for (int x = startValue; x <= stopValue; x++)
                if (x + 1.2 != 0)
                {
                    funcChart_CNM.Series[0].Points.AddXY(x, x + 1.2 != 0 ? Math.Round((Math.Sin(x)) / (x + 1.2) + Math.Cos(x) * 7 * x - 2, 2) : 0);
                }

            answerTextBox_CNM.Text = String.Join(Environment.NewLine, ds.GetMassFunction(startValue, stopValue));
        }

        private void ButtonHelp_CNM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы АСОиУб-25-1 Чугин Никита Максимович");
        }


        #endregion

        private GroupBox textGroupBox_CNM;
        private GroupBox questionGroupBox_CNM;
        private TextBox questionBox_CNM;
        private System.Windows.Forms.DataVisualization.Charting.Chart funcChart_CNM;
        private TextBox answerTextBox_CNM;
        private GroupBox buttonGroupBox_CNM;
        private TextBox startStepInputText_CNM;
        private TextBox endStepInputText_CNM;
        private TextBox endStepText_CNM;
        private TextBox stepStartText_CNM;
        private Button buttonHelp_CNM;
        private Button buttonSave_CNM;
        private Button buttonRun_CNM;
    }
}
