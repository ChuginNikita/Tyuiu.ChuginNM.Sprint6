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

            List<string[]> rows = new List<string[]>();
            int maxColumns = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                int lineNumber = 0;

                while ((line = reader.ReadLine()) != null)
                {
                    lineNumber++;

                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    string[] elements = line.Split(',');

                    if (elements.Length > maxColumns)
                        maxColumns = elements.Length;

                    rows.Add(elements);
                }

                if (rows.Count == 0)
                {
                    return null;
                }
            }

            int rowCount = rows.Count;
            int[,] result = new int[rowCount, maxColumns];

            for (int i = 0; i < rowCount; i++)
            {
                string[] elements = rows[i];

                for (int j = 0; j < maxColumns; j++)
                {
                    if (j < elements.Length)
                    {
                        string element = elements[j].Trim();
                        if (int.TryParse(element, out int value))
                        {
                            result[i, j] = value;
                        }
                        else
                        {
                            throw new FormatException($"Некорректное значение '{element}' в строке {i + 1}, столбце {j + 1}. Ожидается целое число.");
                        }
                    }
                    else
                    {
                        result[i, j] = 0; 
                    }
                }
            }

            int targetColumn = 5;

            if (targetColumn < maxColumns)
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
                Console.WriteLine($"Предупреждение: В массиве только {maxColumns} столбцов, шестой столбец не существует.");
            }

            return result;
        }

    }
}
