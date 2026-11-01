using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.FilippovaVD.Sprint4.Task1.V9.Lib
{
    public class DataService : ISprint4Task1V9
    {
        public int Calculate(int[] array)
        {
            int mult = 1; 
            bool hasEven = false; 

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    mult *= array[i]; 
                    hasEven = true;
                }
            }

            if (!hasEven) return 0;

            return mult;
        }
    }
}
