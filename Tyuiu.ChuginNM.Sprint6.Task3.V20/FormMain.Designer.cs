
namespace Tyuiu.ChuginNM.Sprint6.Task3.V20
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxCondition = new GroupBox();
            pictureBoxCondition = new PictureBox();
            textBoxCondition = new TextBox();
            buttonExecute = new Button();
            dataGridViewOutput = new DataGridView();
            buttonHelp = new Button();
            groupBoxCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCondition).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition
            // 
            groupBoxCondition.Controls.Add(pictureBoxCondition);
            groupBoxCondition.Controls.Add(textBoxCondition);
            groupBoxCondition.Location = new Point(14, 14);
            groupBoxCondition.Margin = new Padding(4, 3, 4, 3);
            groupBoxCondition.Name = "groupBoxCondition";
            groupBoxCondition.Padding = new Padding(4, 3, 4, 3);
            groupBoxCondition.Size = new Size(187, 278);
            groupBoxCondition.TabIndex = 0;
            groupBoxCondition.TabStop = false;
            groupBoxCondition.Text = "Условие";
            // 
            // pictureBoxCondition
            // 
            pictureBoxCondition.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxCondition.Location = new Point(20, 91);
            pictureBoxCondition.Margin = new Padding(4, 3, 4, 3);
            pictureBoxCondition.Name = "pictureBoxCondition";
            pictureBoxCondition.Size = new Size(149, 170);
            pictureBoxCondition.TabIndex = 1;
            pictureBoxCondition.TabStop = false;
            // 
            // textBoxCondition
            // 
            textBoxCondition.BackColor = SystemColors.Control;
            textBoxCondition.BorderStyle = BorderStyle.None;
            textBoxCondition.Location = new Point(20, 22);
            textBoxCondition.Margin = new Padding(4, 3, 4, 3);
            textBoxCondition.Multiline = true;
            textBoxCondition.Name = "textBoxCondition";
            textBoxCondition.ReadOnly = true;
            textBoxCondition.Size = new Size(149, 62);
            textBoxCondition.TabIndex = 0;
            textBoxCondition.Text = "Дан массив 5 на 5 элементов. Заменить четные значения в пятой строке на 0.";
            // 
            // buttonExecute
            // 
            buttonExecute.ForeColor = SystemColors.ActiveCaptionText;
            buttonExecute.Location = new Point(234, 170);
            buttonExecute.Margin = new Padding(4, 3, 4, 3);
            buttonExecute.Name = "buttonExecute";
            buttonExecute.Size = new Size(146, 58);
            buttonExecute.TabIndex = 1;
            buttonExecute.Text = "Выполнить";
            buttonExecute.UseVisualStyleBackColor = true;
            buttonExecute.Click += buttonExecute_Click;
            // 
            // dataGridViewOutput
            // 
            dataGridViewOutput.AllowUserToAddRows = false;
            dataGridViewOutput.AllowUserToDeleteRows = false;
            dataGridViewOutput.AllowUserToResizeColumns = false;
            dataGridViewOutput.AllowUserToResizeRows = false;
            dataGridViewOutput.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewOutput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewOutput.ColumnHeadersVisible = false;
            dataGridViewOutput.Location = new Point(234, 36);
            dataGridViewOutput.Margin = new Padding(4, 3, 4, 3);
            dataGridViewOutput.Name = "dataGridViewOutput";
            dataGridViewOutput.ReadOnly = true;
            dataGridViewOutput.RowHeadersVisible = false;
            dataGridViewOutput.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewOutput.ScrollBars = ScrollBars.None;
            dataGridViewOutput.Size = new Size(146, 127);
            dataGridViewOutput.TabIndex = 2;
            // 
            // buttonHelp
            // 
            buttonHelp.ForeColor = SystemColors.ActiveCaptionText;
            buttonHelp.Location = new Point(234, 234);
            buttonHelp.Margin = new Padding(4, 3, 4, 3);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(146, 58);
            buttonHelp.TabIndex = 3;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += button1_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 301);
            Controls.Add(buttonHelp);
            Controls.Add(dataGridViewOutput);
            Controls.Add(buttonExecute);
            Controls.Add(groupBoxCondition);
            ForeColor = SystemColors.ControlDarkDark;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 20 | Чугин Н. М.";
            Load += FormMain_Load;
            groupBoxCondition.ResumeLayout(false);
            groupBoxCondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCondition).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition;
        private System.Windows.Forms.TextBox textBoxCondition;
        private System.Windows.Forms.PictureBox pictureBoxCondition;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.DataGridView dataGridViewOutput;
        private System.Windows.Forms.Button buttonHelp;
    }
}
