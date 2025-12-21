using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ChuginNM.Sprint6.Task4.V1.Lib
{
    public class DataService : ISprint6Task4V1
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] massFunction = new double[Math.Abs(stopValue - startValue + 1)];
            for (int i = 0; i < massFunction.Length; i++)
            {
                var x = i + startValue;
                massFunction[i] = x + 1.2 != 0 ? Math.Round((Math.Sin(x))/(x + 1.2) + Math.Cos(x) * 7 * x - 2, 2): 0;
            }
            return massFunction;
        }
    }
}
