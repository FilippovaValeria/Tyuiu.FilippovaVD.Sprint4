using Tyuiu.FilippovaVD.Sprint4.Task4.V12.Lib;

namespace Tyuiu.FilippovaVD.Sprint4.Task4.V12.Test
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
                { 3, 6, 6, 8, 8 },
                { 2, 7, 2, 4, 6 },
                { 3, 6, 2, 6, 4 },
                { 8, 6, 2, 7, 3 },
                { 8, 7, 6, 6, 6 }
            };

            int[,] wait = new int[,]
            {
                { 3, 1, 1, 1, 1 },
                { 1, 7, 1, 1, 1 },
                { 3, 1, 1, 1, 1 },
                { 1, 1, 1, 7, 3 },
                { 1, 7, 1, 1, 1 }
            };

            int[,] res = ds.Calculate(array);

            for (int i = 0; i < wait.GetLength(0); i++)
            {
                for (int j = 0; j < wait.GetLength(1); j++)
                {
                    Assert.AreEqual(wait[i, j], res[i, j]);
                }
            }
        }
    }
}
