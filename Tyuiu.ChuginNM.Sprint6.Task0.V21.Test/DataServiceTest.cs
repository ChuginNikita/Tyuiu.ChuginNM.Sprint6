using Tyuiu.ChuginNM.Sprint6.Task0.V21.Lib;

namespace Tyuiu.ChuginNM.Sprint6.Task0.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(2);
            double wait = 13;
            Assert.AreEqual(wait, res);
        }
    }
}
