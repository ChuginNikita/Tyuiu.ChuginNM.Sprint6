using Tyuiu.ChuginNM.Sprint6.Task4.V1.Lib;

namespace Tyuiu.ChuginNM.Sprint6.Task4.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double[] doubles = new double[] { -2 };
            CollectionAssert.AreEqual(ds.GetMassFunction(0, 0), doubles);
        }
    }
}
