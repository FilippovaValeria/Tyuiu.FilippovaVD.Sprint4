using Tyuiu.FilippovaVD.Sprint4.Task1.V9.Lib;

namespace Tyuiu.FilippovaVD.Sprint4.Task1.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 6, 3, 3, 7, 7, 7, 3, 3, 6, 4, 4, 8, 4 };

            int wait = 18432;

            int res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }
    }
}
