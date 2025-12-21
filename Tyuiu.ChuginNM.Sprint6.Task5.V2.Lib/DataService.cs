using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ChuginNM.Sprint6.Task5.V2.Lib
{

    public class DataService : ISprint6Task5V2
    {

        public double[] LoadFromDataFile(string path)
        {
               string res = String.Join(";", File.ReadAllLines(path));
               double[] values = res.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
               return values;
        }
    }
}
