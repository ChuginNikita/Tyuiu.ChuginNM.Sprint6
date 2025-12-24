using Tyuiu.ChuginNM.Sprint6.Task3.V20.Lib;

namespace Tyuiu.ChuginNM.Sprint6.Task3.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int[,] data1 = new int[,] 
            { 
                { 0, 0, 0, 0, 0 }, 
                { 1, 1, 1, 1, 1 }, 
                { 2, 2, 2, 2, 2 }, 
                { 3, 3, 3, 3, 3 }, 
                { 4, 4, 4, 4, 4 }, 
                { 5, 5, 5, 5, 5 }, 
                { 6, 6, 6, 6, 6 } 
            };

            int[,] data2 = new int[,]
            {
                { 0, 0, 0, 0, 0 },
                { 1, 1, 1, 1, 1 },
                { 2, 2, 2, 2, 2 },
                { 3, 3, 3, 3, 3 },
                { 0, 0, 0, 0, 0 },
                { 5, 5, 5, 5, 5 },
                { 6, 6, 6, 6, 6 }
            };

            CollectionAssert.AreEqual(ds.Calculate(data1), data2);

        }
    }
}
