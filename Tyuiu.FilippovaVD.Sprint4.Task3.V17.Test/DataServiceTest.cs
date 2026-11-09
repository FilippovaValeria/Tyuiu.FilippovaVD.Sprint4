using Tyuiu.FilippovaVD.Sprint4.Task3.V17.Lib;

namespace Tyuiu.FilippovaVD.Sprint4.Task3.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] array = new int[,]
            {
                { 6, 4, 2, 2, 1 },
                { 3, 6, 5, 4, 1 },
                { 5, 2, 3, 1, 6 },
                { 8, 8, 4, 5, 3 },
                { 7, 4, 5, 1, 6 }
            };

            int wait = 13;

            int res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }
    }
}
