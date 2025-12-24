using Tyuiu.ChuginNM.Sprint6.Task5.V2.Lib;

namespace Tyuiu.ChuginNM.Sprint6.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string path = Path.Combine(Path.GetTempPath(), "input.txt");
            Assert.IsNotNull(ds);
        }
    }
}
