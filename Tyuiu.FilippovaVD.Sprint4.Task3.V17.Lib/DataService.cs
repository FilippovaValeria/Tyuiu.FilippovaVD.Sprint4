using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.FilippovaVD.Sprint4.Task3.V17.Lib
{
    public class DataService : ISprint4Task3V17
    {
        public int Calculate(int[,] array)
        {
            int sum = 0;
            int columnIndex = 3; 

            for (int i = 0; i < array.GetLength(0); i++)
            {
                sum += array[i, columnIndex];
            }

            return sum;
        }
    }
}
