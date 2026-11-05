using Tyuiu.FilippovaVD.Sprint4.Task2.V8.Lib;

namespace Tyuiu.FilippovaVD.Sprint4.Task2.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 2, 3, 4, 5, 6, 7, 2, 3, 4, 6, 7 };

            int wait = 25;

            int res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }
    }
}
