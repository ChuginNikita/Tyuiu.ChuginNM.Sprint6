using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint6;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.ChuginNM.Sprint6.Task6.V12.Lib
{
    public class DataService : ISprint6Task6V12
    {
        public string CollectTextFromFile(string path)
        {
            string res = File.ReadAllText(path);

            if (string.IsNullOrEmpty(res))
                return string.Empty;

            // Регулярное выражение для поиска слов
            // \b - граница слова, \w+ - одно или больше буквенно-цифровых символов
            MatchCollection matches = Regex.Matches(res, @"\b[\p{L}'-]+\b");

            // Фильтруем слова, содержащие 'w' (без учета регистра)
            var wordsWithW = matches
                .Cast<Match>()
                .Select(m => m.Value)
                .Where(word => word.IndexOf('w', StringComparison.Ordinal) >= 0);

            // Собираем результат в строку
            return string.Join(" ", wordsWithW);
        }
    }

}
