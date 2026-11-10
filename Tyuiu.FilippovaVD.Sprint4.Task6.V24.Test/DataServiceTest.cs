using Tyuiu.FilippovaVD.Sprint4.Task6.V24.Lib;

namespace Tyuiu.FilippovaVD.Sprint4.Task6.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string[] array = { "Компьютер", "Телефон", "Планшет", "Принтер", "Сканер", "Монитор", "Клавиатура" };
            string[] wait = { "Компьютер", "Клавиатура" };

            string[] res = ds.Calculate(array);

            Assert.HasCount(wait.Length, res);

            for (int i = 0; i < wait.Length; i++)
            {
                Assert.AreEqual(wait[i], res[i]);
            }
        }
    }
}
