using System.Text;
using System.Windows.Forms;
using Tyuiu.ChuginNM.Sprint6.Task7.V13.Lib;

namespace Tyuiu.ChuginNM.Sprint6.Task7.V13
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
            groupControlBox_CNM = new GroupBox();
            buttonHelp_CNM = new Button();
            buttonOpen_CNM = new Button();
            buttonRun_CNM = new Button();
            groupQuestionBox_CNM = new GroupBox();
            dataGridViewInput_CNM = new DataGridView();
            dataGridViewOutput_CNM = new DataGridView();
            buttonSave_CNM = new Button();
            groupControlBox_CNM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_CNM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_CNM).BeginInit();
            SuspendLayout();
            // 
            // groupControlBox_CNM
            // 
            groupControlBox_CNM.AutoSize = true;
            groupControlBox_CNM.Controls.Add(buttonSave_CNM);
            groupControlBox_CNM.Controls.Add(buttonHelp_CNM);
            groupControlBox_CNM.Controls.Add(buttonOpen_CNM);
            groupControlBox_CNM.Controls.Add(buttonRun_CNM);
            groupControlBox_CNM.Location = new Point(12, 12);
            groupControlBox_CNM.Name = "groupControlBox_CNM";
            groupControlBox_CNM.Size = new Size(943, 102);
            groupControlBox_CNM.TabIndex = 0;
            groupControlBox_CNM.TabStop = false;
            groupControlBox_CNM.Text = "Управление";
            // 
            // buttonHelp_CNM
            // 
            buttonHelp_CNM.Location = new Point(873, 22);
            buttonHelp_CNM.Name = "buttonHelp_CNM";
            buttonHelp_CNM.Size = new Size(64, 58);
            buttonHelp_CNM.TabIndex = 2;
            buttonHelp_CNM.Text = "HELP";
            buttonHelp_CNM.UseVisualStyleBackColor = true;
            buttonHelp_CNM.Click += buttonHelp_CNM_Click;
            // 
            // buttonOpen_CNM
            // 
            buttonOpen_CNM.Location = new Point(6, 22);
            buttonOpen_CNM.Name = "buttonOpen_CNM";
            buttonOpen_CNM.Size = new Size(64, 58);
            buttonOpen_CNM.TabIndex = 1;
            buttonOpen_CNM.Text = "OPEN";
            buttonOpen_CNM.UseVisualStyleBackColor = true;
            buttonOpen_CNM.Click += ButtonOpen_CNM_Click;
            // 
            // buttonRun_CNM
            // 
            buttonRun_CNM.Location = new Point(146, 22);
            buttonRun_CNM.Name = "buttonRun_CNM";
            buttonRun_CNM.Size = new Size(64, 58);
            buttonRun_CNM.TabIndex = 0;
            buttonRun_CNM.Text = "RUN";
            buttonRun_CNM.UseVisualStyleBackColor = true;
            buttonRun_CNM.Click += ButtonRun_CNM_Click;
            buttonRun_CNM.Enabled = false;
            // 
            // groupQuestionBox_CNM
            // 
            groupQuestionBox_CNM.AutoSize = true;
            groupQuestionBox_CNM.Location = new Point(12, 98);
            groupQuestionBox_CNM.Name = "groupQuestionBox_CNM";
            groupQuestionBox_CNM.Size = new Size(943, 59);
            groupQuestionBox_CNM.TabIndex = 1;
            groupQuestionBox_CNM.TabStop = false;
            groupQuestionBox_CNM.Text = "Условие";
            // 
            // dataGridViewInput_CNM
            // 
            dataGridViewInput_CNM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInput_CNM.Location = new Point(12, 163);
            dataGridViewInput_CNM.Name = "dataGridViewInput_CNM";
            dataGridViewInput_CNM.Size = new Size(487, 386);
            dataGridViewInput_CNM.TabIndex = 2;
            // 
            // dataGridViewOutput_CNM
            // 
            dataGridViewOutput_CNM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput_CNM.Location = new Point(505, 163);
            dataGridViewOutput_CNM.Name = "dataGridViewOutput_CNM";
            dataGridViewOutput_CNM.Size = new Size(450, 386);
            dataGridViewOutput_CNM.TabIndex = 3;
            // 
            // buttonSave_CNM
            // 
            buttonSave_CNM.Location = new Point(76, 22);
            buttonSave_CNM.Name = "buttonSave_CNM";
            buttonSave_CNM.Size = new Size(64, 58);
            buttonSave_CNM.TabIndex = 3;
            buttonSave_CNM.Text = "SAVE";
            buttonSave_CNM.UseVisualStyleBackColor = true;
            buttonSave_CNM.Click += ButtonSave_CNM_Click;
            buttonSave_CNM.Enabled = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 561);
            Controls.Add(dataGridViewOutput_CNM);
            Controls.Add(dataGridViewInput_CNM);
            Controls.Add(groupQuestionBox_CNM);
            Controls.Add(groupControlBox_CNM);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 13 | Чугин Никита";
            groupControlBox_CNM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_CNM).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_CNM).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void ButtonSave_CNM_Click(object sender, EventArgs e)
        {
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "CSV (*.csv)|*.csv|Текстовые файлы (*.txt)|*.txt";
                    sfd.FilterIndex = 1;

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                            {
                                for (int i = 0; i < dataGridViewOutput_CNM.Rows.Count; i++)
                                {
                                    if (dataGridViewOutput_CNM.Rows[i].IsNewRow) continue;

                                    List<string> values = new List<string>();
                                    for (int j = 0; j < dataGridViewOutput_CNM.Columns.Count; j++)
                                    {
                                        string val = dataGridViewOutput_CNM.Rows[i].Cells[j].Value?.ToString() ?? "";
                                        if (val.Contains(",") || val.Contains("\"") || val.Contains("\n"))
                                            val = "\"" + val.Replace("\"", "\"\"") + "\"";
                                        values.Add(val);
                                    }
                                    sw.WriteLine(string.Join(",", values));
                                }
                            }
                            MessageBox.Show("Сохранено успешно!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void buttonHelp_CNM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 7 выполнил студент группы АСОиУб-25-1 Чугин Никита");
        }

        private void ButtonOpen_CNM_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    path = openFileDialog.FileName;
                    MessageBox.Show("Выбран файл: " + path.ToString());
                    buttonSave_CNM.Enabled = false;
                }

            }

            if (path == "")
            {
                buttonRun_CNM.Enabled = false;
                buttonSave_CNM.Enabled = false;
            }
            else { buttonRun_CNM.Enabled = true; }

            DisplayArrayInDataGridView(ds.GetMatrix(path), dataGridViewInput_CNM);
        }

        static void DisplayArrayInDataGridView(int[,] array, DataGridView dataGridView)
        {
            if (array == null)
            {
                MessageBox.Show("Массив пуст или не инициализирован.");
                return;
            }

            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int j = 0; j < cols; j++)
            {
                DataGridViewColumn column = new DataGridViewTextBoxColumn
                {
                    HeaderText = $"Столбец {j + 1}",
                    Name = $"Column{j}",
                    Width = 100
                };
                dataGridView.Columns.Add(column);
            }

            for (int i = 0; i < rows; i++)
            {
                object[] rowValues = new object[cols];
                for (int j = 0; j < cols; j++)
                {
                    rowValues[j] = array[i, j];
                }

                dataGridView.Rows.Add(rowValues);
            }
            dataGridView.RowHeadersVisible = true;
            for (int i = 0; i < rows; i++)
            {
                dataGridView.Rows[i].HeaderCell.Value = $"Строка {i + 1}";
            }
        }

        private void ButtonRun_CNM_Click(object sender, EventArgs e)
        {
            var result = ds.GetMatrix(path);
            int maxColumns = result.GetLength(1);
            int rowCount = result.GetLength(0);

            int targetColumn = 5;

            if (targetColumn <= maxColumns)
            {
                for (int i = 0; i < rowCount; i++)
                {
                    int value = result[i, targetColumn];

                    if (value > 0 && value % 2 == 0)
                    {
                        result[i, targetColumn] = 111;
                    }
                }
            }
            else
            {
                throw new Exception("Таблица загружена неправильно");
            }
            DisplayArrayInDataGridView(result, dataGridViewOutput_CNM);
            buttonSave_CNM.Enabled = true;

        }

        #endregion

        private GroupBox groupControlBox_CNM;
        private GroupBox groupQuestionBox_CNM;
        private DataGridView dataGridViewInput_CNM;
        private DataGridView dataGridViewOutput_CNM;
        private Button buttonRun_CNM;
        private Button buttonOpen_CNM;
        private Button buttonHelp_CNM;
        private Button buttonSave_CNM;
    }
}
