using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ChuginNM.Sprint6.Task1.V12.Lib
{
    public class DataService : ISprint6Task1V12
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int count = 0;
            double y;

            int len = (stopValue - startValue) + 1;
            double[] func = new double[len];

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 2)
                {
                    y = 0;
                    func[count] = y;
                    count++;
                }
                else
                {
                    y = Math.Round((Math.Sin(x) + ((Math.Cos(x) + 1) / (2 - x)) + 2 * x), 2);
                    func[count] = y;
                    count++;
                }

            }

            return func;

        }
    }
}
