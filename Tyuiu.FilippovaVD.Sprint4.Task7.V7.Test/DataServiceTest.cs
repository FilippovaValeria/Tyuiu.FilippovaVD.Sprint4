using Tyuiu.FilippovaVD.Sprint4.Task7.V7.Lib;

namespace Tyuiu.FilippovaVD.Sprint4.Task7.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string value = "31415926";
            int n = 4;
            int m = 2;

            int wait = 5;

            int res = ds.Calculate(n, m, value);

            Assert.AreEqual(wait, res);
        }
    }
}