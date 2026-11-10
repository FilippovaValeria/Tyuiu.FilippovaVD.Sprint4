using Tyuiu.FilippovaVD.Sprint4.Task5.V24.Lib;

namespace Tyuiu.FilippovaVD.Sprint4.Task5.V24.Test
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
                { -1, 2, -3, 4, -5 },
                { 6, -7, 8, -9, 1 }, 
                { 2, 3, -4, 5, -6 },
                { 7, -8, 2, -1, 4 },
                { 6, 3, -1, 2, -7 }
            };

            int wait = 14;

            int res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }
    }
}
