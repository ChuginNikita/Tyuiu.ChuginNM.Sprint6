
namespace Tyuiu.ChuginNM.Sprint6.Task1.V12
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
            groupBoxTask_CNM = new GroupBox();
            textBoxTask_CNM = new TextBox();
            ButtonResult_CNM = new Button();
            groupBoxResult_CNM = new GroupBox();
            textBoxOutPut_CNM = new TextBox();
            textBoxResult_CNM = new TextBox();
            groupBoxInPut_CNM = new GroupBox();
            textBoxVarB_CNM = new TextBox();
            textBoxVarA_CNM = new TextBox();
            textBoxStartStep_CNM = new TextBox();
            textBoxEndStep_CNM = new TextBox();
            buttonHelp_CNM = new Button();
            groupBoxTask_CNM.SuspendLayout();
            groupBoxResult_CNM.SuspendLayout();
            groupBoxInPut_CNM.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_CNM
            // 
            groupBoxTask_CNM.Controls.Add(textBoxTask_CNM);
            groupBoxTask_CNM.Location = new Point(12, 12);
            groupBoxTask_CNM.Name = "groupBoxTask_CNM";
            groupBoxTask_CNM.Size = new Size(451, 186);
            groupBoxTask_CNM.TabIndex = 4;
            groupBoxTask_CNM.TabStop = false;
            groupBoxTask_CNM.Text = "Условие";
            // 
            // textBoxTask_CNM
            // 
            textBoxTask_CNM.BorderStyle = BorderStyle.None;
            textBoxTask_CNM.Location = new Point(0, 22);
            textBoxTask_CNM.Multiline = true;
            textBoxTask_CNM.Name = "textBoxTask_CNM";
            textBoxTask_CNM.ReadOnly = true;
            textBoxTask_CNM.Size = new Size(323, 53);
            textBoxTask_CNM.TabIndex = 0;
            textBoxTask_CNM.Text = "Протабулировать функцию f(x) на заданном диапазоне. Результат привести в виде таблицы.\r\n";
            // 
            // ButtonResult_CNM
            // 
            ButtonResult_CNM.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonResult_CNM.BackColor = Color.FromArgb(0, 192, 0);
            ButtonResult_CNM.Location = new Point(330, 210);
            ButtonResult_CNM.Name = "ButtonResult_CNM";
            ButtonResult_CNM.Size = new Size(133, 61);
            ButtonResult_CNM.TabIndex = 3;
            ButtonResult_CNM.Text = "Выполнить";
            ButtonResult_CNM.UseVisualStyleBackColor = false;
            ButtonResult_CNM.Click += ButtonResult_CNM_Click;
            // 
            // groupBoxResult_CNM
            // 
            groupBoxResult_CNM.Controls.Add(textBoxOutPut_CNM);
            groupBoxResult_CNM.Controls.Add(textBoxResult_CNM);
            groupBoxResult_CNM.Location = new Point(469, 12);
            groupBoxResult_CNM.Name = "groupBoxResult_CNM";
            groupBoxResult_CNM.Size = new Size(276, 259);
            groupBoxResult_CNM.TabIndex = 2;
            groupBoxResult_CNM.TabStop = false;
            groupBoxResult_CNM.Text = "Вывод данных";
            // 
            // textBoxOutPut_CNM
            // 
            textBoxOutPut_CNM.Location = new Point(6, 44);
            textBoxOutPut_CNM.Multiline = true;
            textBoxOutPut_CNM.Name = "textBoxOutPut_CNM";
            textBoxOutPut_CNM.ReadOnly = true;
            textBoxOutPut_CNM.ScrollBars = ScrollBars.Vertical;
            textBoxOutPut_CNM.Size = new Size(264, 209);
            textBoxOutPut_CNM.TabIndex = 1;
            // 
            // textBoxResult_CNM
            // 
            textBoxResult_CNM.BorderStyle = BorderStyle.None;
            textBoxResult_CNM.Location = new Point(6, 22);
            textBoxResult_CNM.Name = "textBoxResult_CNM";
            textBoxResult_CNM.ReadOnly = true;
            textBoxResult_CNM.ScrollBars = ScrollBars.Vertical;
            textBoxResult_CNM.Size = new Size(264, 16);
            textBoxResult_CNM.TabIndex = 0;
            textBoxResult_CNM.Text = "Результат:";
            // 
            // groupBoxInPut_CNM
            // 
            groupBoxInPut_CNM.Controls.Add(textBoxVarB_CNM);
            groupBoxInPut_CNM.Controls.Add(textBoxVarA_CNM);
            groupBoxInPut_CNM.Controls.Add(textBoxStartStep_CNM);
            groupBoxInPut_CNM.Controls.Add(textBoxEndStep_CNM);
            groupBoxInPut_CNM.Location = new Point(12, 204);
            groupBoxInPut_CNM.Name = "groupBoxInPut_CNM";
            groupBoxInPut_CNM.Size = new Size(218, 67);
            groupBoxInPut_CNM.TabIndex = 1;
            groupBoxInPut_CNM.TabStop = false;
            groupBoxInPut_CNM.Text = "Ввод данных";
            // 
            // textBoxVarB_CNM
            // 
            textBoxVarB_CNM.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxVarB_CNM.Location = new Point(112, 38);
            textBoxVarB_CNM.Name = "textBoxVarB_CNM";
            textBoxVarB_CNM.Size = new Size(100, 23);
            textBoxVarB_CNM.TabIndex = 0;
            // 
            // textBoxVarA_CNM
            // 
            textBoxVarA_CNM.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxVarA_CNM.Location = new Point(6, 38);
            textBoxVarA_CNM.Name = "textBoxVarA_CNM";
            textBoxVarA_CNM.Size = new Size(100, 23);
            textBoxVarA_CNM.TabIndex = 1;
            // 
            // textBoxStartStep_CNM
            // 
            textBoxStartStep_CNM.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxStartStep_CNM.BorderStyle = BorderStyle.None;
            textBoxStartStep_CNM.Location = new Point(6, 16);
            textBoxStartStep_CNM.Name = "textBoxStartStep_CNM";
            textBoxStartStep_CNM.ReadOnly = true;
            textBoxStartStep_CNM.Size = new Size(100, 16);
            textBoxStartStep_CNM.TabIndex = 3;
            textBoxStartStep_CNM.Text = "Старт шага:";
            // 
            // textBoxEndStep_CNM
            // 
            textBoxEndStep_CNM.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxEndStep_CNM.BorderStyle = BorderStyle.None;
            textBoxEndStep_CNM.Location = new Point(112, 16);
            textBoxEndStep_CNM.Name = "textBoxEndStep_CNM";
            textBoxEndStep_CNM.ReadOnly = true;
            textBoxEndStep_CNM.Size = new Size(100, 16);
            textBoxEndStep_CNM.TabIndex = 2;
            textBoxEndStep_CNM.Text = "Конец шага:";
            // 
            // buttonHelp_CNM
            // 
            buttonHelp_CNM.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonHelp_CNM.BackColor = SystemColors.HotTrack;
            buttonHelp_CNM.Location = new Point(242, 210);
            buttonHelp_CNM.Name = "buttonHelp_CNM";
            buttonHelp_CNM.Size = new Size(82, 61);
            buttonHelp_CNM.TabIndex = 0;
            buttonHelp_CNM.Text = "Справка";
            buttonHelp_CNM.UseVisualStyleBackColor = false;
            buttonHelp_CNM.Click += buttonHelp_CNM_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 285);
            Controls.Add(buttonHelp_CNM);
            Controls.Add(groupBoxInPut_CNM);
            Controls.Add(groupBoxResult_CNM);
            Controls.Add(ButtonResult_CNM);
            Controls.Add(groupBoxTask_CNM);
            Text = "Спринт 6 | Таск 1 | Вариант 12 | Чугин Н. М.";
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            groupBoxTask_CNM.ResumeLayout(false);
            groupBoxTask_CNM.PerformLayout();
            groupBoxResult_CNM.ResumeLayout(false);
            groupBoxResult_CNM.PerformLayout();
            groupBoxInPut_CNM.ResumeLayout(false);
            groupBoxInPut_CNM.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_CNM;
        private System.Windows.Forms.Button ButtonResult_CNM;
        private System.Windows.Forms.TextBox textBoxTask_CNM;
        private System.Windows.Forms.GroupBox groupBoxResult_CNM;
        private System.Windows.Forms.TextBox textBoxResult_CNM;
        private System.Windows.Forms.TextBox textBoxOutPut_CNM;
        private System.Windows.Forms.GroupBox groupBoxInPut_CNM;
        private System.Windows.Forms.TextBox textBoxVarB_CNM;
        private System.Windows.Forms.TextBox textBoxVarA_CNM;
        private System.Windows.Forms.TextBox textBoxEndStep_CNM;
        private System.Windows.Forms.TextBox textBoxStartStep_CNM;
        private System.Windows.Forms.Button buttonHelp_CNM;
    }
}
