using Tyuiu.ChuginNM.Sprint6.Task6.V12.Lib;

namespace Tyuiu.ChuginNM.Sprint6.Task6.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            string testString = "world vex sicilium West Wrong sorrow";
            Assert.AreEqual(ds.CollectTextFromFile(@"C:\Users\CDOOR\Downloads\trial.txt"), "world West Wrong sorrow");


        }
    }
}
