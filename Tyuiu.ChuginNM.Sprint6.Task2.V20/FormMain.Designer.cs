
namespace Tyuiu.ChuginNM.Sprint6.Task2.V20
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxCondition_CNM = new GroupBox();
            pictureBoxCondition = new PictureBox();
            labelCondition_CNM = new Label();
            groupBoxOutPut_CNM = new GroupBox();
            chartResult_CNM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewResult_CNM = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            groupBoxInPut_CNM = new GroupBox();
            labelEnd_CNM = new Label();
            labelStart_CNM = new Label();
            textBoxEnd_CNM = new TextBox();
            textBoxStart_CNM = new TextBox();
            buttonDone = new Button();
            buttonHelp_CNM = new Button();
            groupBoxCondition_CNM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCondition).BeginInit();
            groupBoxOutPut_CNM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartResult_CNM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_CNM).BeginInit();
            groupBoxInPut_CNM.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_CNM
            // 
            groupBoxCondition_CNM.Controls.Add(pictureBoxCondition);
            groupBoxCondition_CNM.Controls.Add(labelCondition_CNM);
            groupBoxCondition_CNM.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxCondition_CNM.Location = new Point(18, 22);
            groupBoxCondition_CNM.Margin = new Padding(4, 3, 4, 3);
            groupBoxCondition_CNM.Name = "groupBoxCondition_CNM";
            groupBoxCondition_CNM.Padding = new Padding(4, 3, 4, 3);
            groupBoxCondition_CNM.Size = new Size(520, 302);
            groupBoxCondition_CNM.TabIndex = 0;
            groupBoxCondition_CNM.TabStop = false;
            groupBoxCondition_CNM.Text = "Условие";
            // 
            // pictureBoxCondition
            // 
            pictureBoxCondition.Location = new Point(12, 132);
            pictureBoxCondition.Margin = new Padding(4, 3, 4, 3);
            pictureBoxCondition.Name = "pictureBoxCondition";
            pictureBoxCondition.Size = new Size(303, 38);
            pictureBoxCondition.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxCondition.TabIndex = 1;
            pictureBoxCondition.TabStop = false;
            // 
            // labelCondition_CNM
            // 
            labelCondition_CNM.AutoSize = true;
            labelCondition_CNM.Location = new Point(7, 25);
            labelCondition_CNM.Margin = new Padding(4, 0, 4, 0);
            labelCondition_CNM.Name = "labelCondition_CNM";
            labelCondition_CNM.Size = new Size(0, 21);
            labelCondition_CNM.TabIndex = 0;
            labelCondition_CNM.Click += label1_Click;
            // 
            // groupBoxOutPut_CNM
            // 
            groupBoxOutPut_CNM.Controls.Add(chartResult_CNM);
            groupBoxOutPut_CNM.Controls.Add(dataGridViewResult_CNM);
            groupBoxOutPut_CNM.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxOutPut_CNM.Location = new Point(567, 22);
            groupBoxOutPut_CNM.Margin = new Padding(4, 3, 4, 3);
            groupBoxOutPut_CNM.Name = "groupBoxOutPut_CNM";
            groupBoxOutPut_CNM.Padding = new Padding(4, 3, 4, 3);
            groupBoxOutPut_CNM.Size = new Size(757, 419);
            groupBoxOutPut_CNM.TabIndex = 0;
            groupBoxOutPut_CNM.TabStop = false;
            groupBoxOutPut_CNM.Text = "Результат";
            // 
            // chartResult_CNM
            // 
            chartArea2.Name = "ChartArea1";
            chartResult_CNM.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartResult_CNM.Legends.Add(legend2);
            chartResult_CNM.Location = new Point(190, 29);
            chartResult_CNM.Margin = new Padding(4, 3, 4, 3);
            chartResult_CNM.Name = "chartResult_CNM";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartResult_CNM.Series.Add(series2);
            chartResult_CNM.Size = new Size(448, 300);
            chartResult_CNM.TabIndex = 1;
            chartResult_CNM.Text = "chart1";
            // 
            // dataGridViewResult_CNM
            // 
            dataGridViewResult_CNM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_CNM.Columns.AddRange(new DataGridViewColumn[] { X, Y });
            dataGridViewResult_CNM.Location = new Point(8, 29);
            dataGridViewResult_CNM.Margin = new Padding(4, 3, 4, 3);
            dataGridViewResult_CNM.Name = "dataGridViewResult_CNM";
            dataGridViewResult_CNM.RowHeadersVisible = false;
            dataGridViewResult_CNM.Size = new Size(135, 390);
            dataGridViewResult_CNM.TabIndex = 0;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.Width = 50;
            // 
            // Y
            // 
            Y.HeaderText = "F(X)";
            Y.Name = "Y";
            Y.Width = 70;
            // 
            // groupBoxInPut_CNM
            // 
            groupBoxInPut_CNM.Controls.Add(labelEnd_CNM);
            groupBoxInPut_CNM.Controls.Add(labelStart_CNM);
            groupBoxInPut_CNM.Controls.Add(textBoxEnd_CNM);
            groupBoxInPut_CNM.Controls.Add(textBoxStart_CNM);
            groupBoxInPut_CNM.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxInPut_CNM.Location = new Point(18, 331);
            groupBoxInPut_CNM.Margin = new Padding(4, 3, 4, 3);
            groupBoxInPut_CNM.Name = "groupBoxInPut_CNM";
            groupBoxInPut_CNM.Padding = new Padding(4, 3, 4, 3);
            groupBoxInPut_CNM.Size = new Size(304, 110);
            groupBoxInPut_CNM.TabIndex = 0;
            groupBoxInPut_CNM.TabStop = false;
            groupBoxInPut_CNM.Text = "Ввод данных";
            // 
            // labelEnd_CNM
            // 
            labelEnd_CNM.AutoSize = true;
            labelEnd_CNM.Location = new Point(7, 69);
            labelEnd_CNM.Margin = new Padding(4, 0, 4, 0);
            labelEnd_CNM.Name = "labelEnd_CNM";
            labelEnd_CNM.Size = new Size(97, 21);
            labelEnd_CNM.TabIndex = 1;
            labelEnd_CNM.Text = "Конец шага:";
            // 
            // labelStart_CNM
            // 
            labelStart_CNM.AutoSize = true;
            labelStart_CNM.Location = new Point(7, 36);
            labelStart_CNM.Margin = new Padding(4, 0, 4, 0);
            labelStart_CNM.Name = "labelStart_CNM";
            labelStart_CNM.Size = new Size(93, 21);
            labelStart_CNM.TabIndex = 1;
            labelStart_CNM.Text = "Старт шага:";
            // 
            // textBoxEnd_CNM
            // 
            textBoxEnd_CNM.Location = new Point(133, 66);
            textBoxEnd_CNM.Margin = new Padding(4, 3, 4, 3);
            textBoxEnd_CNM.Name = "textBoxEnd_CNM";
            textBoxEnd_CNM.Size = new Size(150, 29);
            textBoxEnd_CNM.TabIndex = 0;
            // 
            // textBoxStart_CNM
            // 
            textBoxStart_CNM.Location = new Point(133, 32);
            textBoxStart_CNM.Margin = new Padding(4, 3, 4, 3);
            textBoxStart_CNM.Name = "textBoxStart_CNM";
            textBoxStart_CNM.Size = new Size(150, 29);
            textBoxStart_CNM.TabIndex = 0;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.FromArgb(0, 192, 0);
            buttonDone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDone.Location = new Point(330, 343);
            buttonDone.Margin = new Padding(4, 3, 4, 3);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(112, 98);
            buttonDone.TabIndex = 1;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            buttonDone.MouseDown += buttonDone_Down;
            buttonDone.MouseEnter += buttonDone_Enter;
            buttonDone.MouseLeave += buttonDone_Leave;
            // 
            // buttonHelp_CNM
            // 
            buttonHelp_CNM.BackColor = Color.Blue;
            buttonHelp_CNM.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonHelp_CNM.Location = new Point(450, 345);
            buttonHelp_CNM.Margin = new Padding(4, 3, 4, 3);
            buttonHelp_CNM.Name = "buttonHelp_CNM";
            buttonHelp_CNM.Size = new Size(88, 95);
            buttonHelp_CNM.TabIndex = 1;
            buttonHelp_CNM.Text = "?";
            buttonHelp_CNM.UseVisualStyleBackColor = false;
            buttonHelp_CNM.Click += buttonHelp_CNM_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1217, 450);
            Controls.Add(buttonHelp_CNM);
            Controls.Add(buttonDone);
            Controls.Add(groupBoxOutPut_CNM);
            Controls.Add(groupBoxInPut_CNM);
            Controls.Add(groupBoxCondition_CNM);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 20 | Пьянзина М.А.";
            groupBoxCondition_CNM.ResumeLayout(false);
            groupBoxCondition_CNM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCondition).EndInit();
            groupBoxOutPut_CNM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartResult_CNM).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_CNM).EndInit();
            groupBoxInPut_CNM.ResumeLayout(false);
            groupBoxInPut_CNM.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_CNM;
        private System.Windows.Forms.Label labelCondition_CNM;
        private System.Windows.Forms.GroupBox groupBoxOutPut_CNM;
        private System.Windows.Forms.GroupBox groupBoxInPut_CNM;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonHelp_CNM;
        private System.Windows.Forms.PictureBox pictureBoxCondition;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_CNM;
        private System.Windows.Forms.DataGridView dataGridViewResult_CNM;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.Label labelEnd_CNM;
        private System.Windows.Forms.Label labelStart_CNM;
        private System.Windows.Forms.TextBox textBoxEnd_CNM;
        private System.Windows.Forms.TextBox textBoxStart_CNM;
    }
}
