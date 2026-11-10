using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.FilippovaVD.Sprint4.Task6.V24.Lib
{
    public class DataService : ISprint4Task6V24
    {
        public string[] Calculate(string[] array)
        {
            string[] result = Array.FindAll(array, word => word.Length > 7);

            return result;
        }
    }
}
