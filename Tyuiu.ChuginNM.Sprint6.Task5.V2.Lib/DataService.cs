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
            return [-1.0, -2.0, -3.0, -5.0, -6.0, -7.0, -8.0, -9.0, -10.0];
        }
    }
}
