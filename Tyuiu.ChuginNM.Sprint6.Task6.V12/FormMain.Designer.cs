using Tyuiu.ChuginNM.Sprint6.Task6.V12.Lib;

namespace Tyuiu.ChuginNM.Sprint6.Task6.V12
{
    partial class FormMain
    {
        DataService ds = new DataService();
        string path = "";

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            controlBox_CNM = new GroupBox();
            buttonHelp_CNM = new Button();
            buttonRun_CNM = new Button();
            buttonImport_CNM = new Button();
            questionGroupBox_CNM = new GroupBox();
            questionTextBox_CNM = new TextBox();
            inputTextBox_CNM = new TextBox();
            inputGroupBox_CNM = new GroupBox();
            outputGroupBox_CNM = new GroupBox();
            outputTextBox_CNM = new TextBox();
            controlBox_CNM.SuspendLayout();
            questionGroupBox_CNM.SuspendLayout();
            inputGroupBox_CNM.SuspendLayout();
            outputGroupBox_CNM.SuspendLayout();
            SuspendLayout();
            // 
            // controlBox_CNM
            // 
            controlBox_CNM.Controls.Add(buttonHelp_CNM);
            controlBox_CNM.Controls.Add(buttonRun_CNM);
            controlBox_CNM.Controls.Add(buttonImport_CNM);
            controlBox_CNM.Location = new Point(12, 12);
            controlBox_CNM.Name = "controlBox_CNM";
            controlBox_CNM.Size = new Size(776, 93);
            controlBox_CNM.TabIndex = 0;
            controlBox_CNM.TabStop = false;
            controlBox_CNM.Text = "Управление";
            // 
            // buttonHelp_CNM
            // 
            buttonHelp_CNM.Location = new Point(695, 22);
            buttonHelp_CNM.Name = "buttonHelp_CNM";
            buttonHelp_CNM.Size = new Size(75, 65);
            buttonHelp_CNM.TabIndex = 2;
            buttonHelp_CNM.Text = "СПРАВКА";
            buttonHelp_CNM.UseVisualStyleBackColor = true;
            buttonHelp_CNM.Click += ButtonHelp_CNM_Click;
            // 
            // buttonRun_CNM
            // 
            buttonRun_CNM.Enabled = false;
            buttonRun_CNM.Location = new Point(87, 22);
            buttonRun_CNM.Name = "buttonRun_CNM";
            buttonRun_CNM.Size = new Size(75, 65);
            buttonRun_CNM.TabIndex = 1;
            buttonRun_CNM.Text = "ЗАПУСК ФАЙЛА";
            buttonRun_CNM.UseVisualStyleBackColor = true;
            buttonRun_CNM.Click += ButtonRun_CNM_Click;
            // 
            // buttonImport_CNM
            // 
            buttonImport_CNM.Location = new Point(6, 22);
            buttonImport_CNM.Name = "buttonImport_CNM";
            buttonImport_CNM.Size = new Size(75, 65);
            buttonImport_CNM.TabIndex = 0;
            buttonImport_CNM.Text = "ИМПОРТ ФАЙЛА\r\n";
            buttonImport_CNM.UseVisualStyleBackColor = true;
            buttonImport_CNM.Click += ButtonImport_CNM_Click;
            // 
            // questionGroupBox_CNM
            // 
            questionGroupBox_CNM.Controls.Add(questionTextBox_CNM);
            questionGroupBox_CNM.Location = new Point(12, 111);
            questionGroupBox_CNM.Name = "questionGroupBox_CNM";
            questionGroupBox_CNM.Size = new Size(776, 66);
            questionGroupBox_CNM.TabIndex = 1;
            questionGroupBox_CNM.TabStop = false;
            questionGroupBox_CNM.Text = "Условие";
            // 
            // questionTextBox_CNM
            // 
            questionTextBox_CNM.BackColor = SystemColors.Control;
            questionTextBox_CNM.BorderStyle = BorderStyle.None;
            questionTextBox_CNM.Location = new Point(6, 22);
            questionTextBox_CNM.Multiline = true;
            questionTextBox_CNM.Name = "questionTextBox_CNM";
            questionTextBox_CNM.Size = new Size(764, 38);
            questionTextBox_CNM.TabIndex = 0;
            questionTextBox_CNM.Text = resources.GetString("questionTextBox_CNM.Text");
            // 
            // inputTextBox_CNM
            // 
            inputTextBox_CNM.Location = new Point(6, 22);
            inputTextBox_CNM.Multiline = true;
            inputTextBox_CNM.Name = "inputTextBox_CNM";
            inputTextBox_CNM.ReadOnly = true;
            inputTextBox_CNM.ScrollBars = ScrollBars.Vertical;
            inputTextBox_CNM.Size = new Size(374, 291);
            inputTextBox_CNM.TabIndex = 2;
            // 
            // inputGroupBox_CNM
            // 
            inputGroupBox_CNM.Controls.Add(inputTextBox_CNM);
            inputGroupBox_CNM.Location = new Point(12, 183);
            inputGroupBox_CNM.Name = "inputGroupBox_CNM";
            inputGroupBox_CNM.Size = new Size(386, 319);
            inputGroupBox_CNM.TabIndex = 4;
            inputGroupBox_CNM.TabStop = false;
            inputGroupBox_CNM.Text = "Ввод текста";
            // 
            // outputGroupBox_CNM
            // 
            outputGroupBox_CNM.Controls.Add(outputTextBox_CNM);
            outputGroupBox_CNM.Location = new Point(402, 183);
            outputGroupBox_CNM.Name = "outputGroupBox_CNM";
            outputGroupBox_CNM.Size = new Size(386, 319);
            outputGroupBox_CNM.TabIndex = 5;
            outputGroupBox_CNM.TabStop = false;
            outputGroupBox_CNM.Text = "Вывод текста";
            // 
            // outputTextBox_CNM
            // 
            outputTextBox_CNM.Location = new Point(6, 22);
            outputTextBox_CNM.Multiline = true;
            outputTextBox_CNM.Name = "outputTextBox_CNM";
            outputTextBox_CNM.ScrollBars = ScrollBars.Vertical;
            outputTextBox_CNM.Size = new Size(374, 291);
            outputTextBox_CNM.TabIndex = 2;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 514);
            Controls.Add(outputGroupBox_CNM);
            Controls.Add(inputGroupBox_CNM);
            Controls.Add(questionGroupBox_CNM);
            Controls.Add(controlBox_CNM);
            Name = "FormMain";
            Text = "Form1";
            controlBox_CNM.ResumeLayout(false);
            questionGroupBox_CNM.ResumeLayout(false);
            questionGroupBox_CNM.PerformLayout();
            inputGroupBox_CNM.ResumeLayout(false);
            inputGroupBox_CNM.PerformLayout();
            outputGroupBox_CNM.ResumeLayout(false);
            outputGroupBox_CNM.PerformLayout();
            ResumeLayout(false);

        }

        private void ButtonRun_CNM_Click(object sender, EventArgs e)
        {
            inputTextBox_CNM.Text = File.ReadAllText(path);
            outputTextBox_CNM.Text = ds.CollectTextFromFile(path).ToString();
        }

        private void ButtonImport_CNM_Click(object sender, EventArgs e)
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
                    path = openFileDialog.FileName;
                    MessageBox.Show("Выбран файл: " + path.ToString());
                }
            }

            if (path == "")
            {
                buttonRun_CNM.Enabled = false;
            } else { buttonRun_CNM.Enabled = true; }
        }

        private void ButtonHelp_CNM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 6 выполнил студент группы АСОиУб-25-1 Чугин Никита");
        }

        #endregion

        private GroupBox controlBox_CNM;
        private Button buttonImport_CNM;
        private GroupBox questionGroupBox_CNM;
        private TextBox inputTextBox_CNM;
        private GroupBox inputGroupBox_CNM;
        private GroupBox outputGroupBox_CNM;
        private TextBox outputTextBox_CNM;
        private Button buttonHelp_CNM;
        private Button buttonRun_CNM;
        private TextBox questionTextBox_CNM;
    }
}
