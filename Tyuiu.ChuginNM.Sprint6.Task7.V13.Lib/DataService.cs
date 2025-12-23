using Microsoft.VisualBasic.FileIO;
using System.Collections.Generic;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ChuginNM.Sprint6.Task7.V13.Lib
{
    public class DataService : ISprint6Task7V13
    {
        public int[,] GetMatrix(string path)
        {
            if (!File.Exists(path))
            {
                return null;
            }

            List<List<int>> rows = new List<List<int>>();
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                int lineNumber = 0;

                while ((line = reader.ReadLine()) != null)
                {
                    lineNumber++;

                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    List<int> currentRow = new List<int>();
                    string[] cells = line.Split(',');

                    foreach (string cell in cells)
                    {
                        string trimmedCell = cell.Trim();

                        // Проверяем, содержит ли ячейка несколько значений
                        if (trimmedCell.Contains(";"))
                        {
                            string[] values = trimmedCell.Split(';', StringSplitOptions.RemoveEmptyEntries);

                            foreach (string value in values)
                            {
                                string trimmedValue = value.Trim();
                                if (int.TryParse(trimmedValue, out int parsedValue))
                                {
                                    currentRow.Add(parsedValue);
                                }
                                else
                                {
                                    throw new FormatException($"Некорректное значение '{trimmedValue}' в строке {lineNumber}. Ожидается целое число.");
                                }
                            }
                        }
                        else
                        {
                            // Одиночное значение
                            if (string.IsNullOrWhiteSpace(trimmedCell))
                            {
                                currentRow.Add(0); // Пустая ячейка становится 0
                            }
                            else if (int.TryParse(trimmedCell, out int parsedValue))
                            {
                                currentRow.Add(parsedValue);
                            }
                            else
                            {
                                throw new FormatException($"Некорректное значение '{trimmedCell}' в строке {lineNumber}. Ожидается целое число.");
                            }
                        }
                    }

                    rows.Add(currentRow);
                }

                if (rows.Count == 0)
                {
                    return null;
                }
            }

            // Определяем размеры результирующей матрицы
            int rowCount = rows.Count;
            int maxColumns = 0;

            foreach (var row in rows)
            {
                if (row.Count > maxColumns)
                {
                    maxColumns = row.Count;
                }
            }

            // Создаем и заполняем результирующую матрицу
            int[,] result = new int[rowCount, maxColumns];

            for (int i = 0; i < rowCount; i++)
            {
                List<int> currentRow = rows[i];

                for (int j = 0; j < maxColumns; j++)
                {
                    if (j < currentRow.Count)
                    {
                        result[i, j] = currentRow[j];
                    }
                    else
                    {
                        result[i, j] = 0; // Заполняем оставшиеся ячейки нулями
                    }
                }
            }

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

            return result;
        }

    }
}
