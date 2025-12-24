using Tyuiu.ChuginNM.Sprint6.Task1.V12.Lib;

namespace Tyuiu.ChuginNM.Sprint6.Task1.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[] 
            {
                -8.86, -7.19, -6.14, -4.76, -2.33, 1.00, 4.38, 0, 6.13, 7.07, 8.61
            };


            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
