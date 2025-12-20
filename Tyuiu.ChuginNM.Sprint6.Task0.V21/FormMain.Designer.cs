
namespace Tyuiu.ChuginNM.Sprint6.Task0.V21
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonDONE_CNM = new Button();
            groupBoxOne_CNM = new GroupBox();
            pictureBoxOne_CNM = new PictureBox();
            groupBoxTwo_CNM = new GroupBox();
            textBoxAnswer_CNM = new TextBox();
            groupBoxThree_CNM = new GroupBox();
            textBoxResult_CNM = new TextBox();
            buttonHELP_CNM = new Button();
            groupBoxOne_CNM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOne_CNM).BeginInit();
            groupBoxTwo_CNM.SuspendLayout();
            groupBoxThree_CNM.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDONE_CNM
            // 
            buttonDONE_CNM.FlatStyle = FlatStyle.Flat;
            buttonDONE_CNM.Location = new Point(530, 355);
            buttonDONE_CNM.Name = "buttonDONE_CNM";
            buttonDONE_CNM.Size = new Size(150, 41);
            buttonDONE_CNM.TabIndex = 0;
            buttonDONE_CNM.Text = "Выполнить";
            buttonDONE_CNM.UseVisualStyleBackColor = true;
            buttonDONE_CNM.Click += buttonDONE_CNM_Click;
            // 
            // groupBoxOne_CNM
            // 
            groupBoxOne_CNM.Controls.Add(pictureBoxOne_CNM);
            groupBoxOne_CNM.Location = new Point(10, 11);
            groupBoxOne_CNM.Name = "groupBoxOne_CNM";
            groupBoxOne_CNM.Size = new Size(679, 194);
            groupBoxOne_CNM.TabIndex = 1;
            groupBoxOne_CNM.TabStop = false;
            groupBoxOne_CNM.Text = "Вычислить значение выражения при х = 2.";
            // 
            // pictureBoxOne_CNM
            // 
            pictureBoxOne_CNM.Image = (Image)resources.GetObject("pictureBoxOne_CNM.Image");
            pictureBoxOne_CNM.Location = new Point(36, 68);
            pictureBoxOne_CNM.Name = "pictureBoxOne_CNM";
            pictureBoxOne_CNM.Size = new Size(509, 96);
            pictureBoxOne_CNM.TabIndex = 2;
            pictureBoxOne_CNM.TabStop = false;
            // 
            // groupBoxTwo_CNM
            // 
            groupBoxTwo_CNM.Controls.Add(textBoxAnswer_CNM);
            groupBoxTwo_CNM.Location = new Point(10, 211);
            groupBoxTwo_CNM.Name = "groupBoxTwo_CNM";
            groupBoxTwo_CNM.Size = new Size(215, 150);
            groupBoxTwo_CNM.TabIndex = 0;
            groupBoxTwo_CNM.TabStop = false;
            groupBoxTwo_CNM.Text = "Ввод данных";
            // 
            // textBoxAnswer_CNM
            // 
            textBoxAnswer_CNM.Location = new Point(36, 86);
            textBoxAnswer_CNM.Name = "textBoxAnswer_CNM";
            textBoxAnswer_CNM.Size = new Size(135, 23);
            textBoxAnswer_CNM.TabIndex = 3;
            textBoxAnswer_CNM.KeyPress += textBoxAnswer_CNM_KeyPress;
            // 
            // groupBoxThree_CNM
            // 
            groupBoxThree_CNM.Controls.Add(textBoxResult_CNM);
            groupBoxThree_CNM.Location = new Point(242, 211);
            groupBoxThree_CNM.Name = "groupBoxThree_CNM";
            groupBoxThree_CNM.Size = new Size(206, 150);
            groupBoxThree_CNM.TabIndex = 0;
            groupBoxThree_CNM.TabStop = false;
            groupBoxThree_CNM.Text = "Вывод данных";
            // 
            // textBoxResult_CNM
            // 
            textBoxResult_CNM.BackColor = SystemColors.ButtonShadow;
            textBoxResult_CNM.Location = new Point(44, 86);
            textBoxResult_CNM.Name = "textBoxResult_CNM";
            textBoxResult_CNM.Size = new Size(118, 23);
            textBoxResult_CNM.TabIndex = 4;
            // 
            // buttonHELP_CNM
            // 
            buttonHELP_CNM.Location = new Point(468, 355);
            buttonHELP_CNM.Name = "buttonHELP_CNM";
            buttonHELP_CNM.Size = new Size(57, 41);
            buttonHELP_CNM.TabIndex = 5;
            buttonHELP_CNM.Text = "?";
            buttonHELP_CNM.UseVisualStyleBackColor = true;
            buttonHELP_CNM.Click += buttonHELP_CNM_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 422);
            Controls.Add(buttonHELP_CNM);
            Controls.Add(groupBoxThree_CNM);
            Controls.Add(groupBoxTwo_CNM);
            Controls.Add(groupBoxOne_CNM);
            Controls.Add(buttonDONE_CNM);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 21 | Чугин Н. М.";
            Load += FormMain_Load;
            groupBoxOne_CNM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxOne_CNM).EndInit();
            groupBoxTwo_CNM.ResumeLayout(false);
            groupBoxTwo_CNM.PerformLayout();
            groupBoxThree_CNM.ResumeLayout(false);
            groupBoxThree_CNM.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDONE_CNM;
        private System.Windows.Forms.GroupBox groupBoxOne_CNM;
        private System.Windows.Forms.PictureBox pictureBoxOne_CNM;
        private System.Windows.Forms.GroupBox groupBoxTwo_CNM;
        private System.Windows.Forms.TextBox textBoxAnswer_CNM;
        private System.Windows.Forms.GroupBox groupBoxThree_CNM;
        private System.Windows.Forms.TextBox textBoxResult_CNM;
        private System.Windows.Forms.Button buttonHELP_CNM;
    }
}