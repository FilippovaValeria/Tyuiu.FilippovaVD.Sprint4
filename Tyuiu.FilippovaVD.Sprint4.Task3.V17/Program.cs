using Tyuiu.FilippovaVD.Sprint4.Task3.V17.Lib;

namespace Tyuiu.FilippovaVD.Sprint4.Task3.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Филиппова В. Д. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                              *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Филиппова В. Д. | АСОиУб-26-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов. Найти сумму        *");
            Console.WriteLine("* элементов в четвертом столбце массива.                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] array = new int[,]
            {
                { 6, 4, 2, 2, 1 },
                { 3, 6, 5, 4, 1 },
                { 5, 2, 3, 1, 6 },
                { 8, 8, 4, 5, 3 },
                { 7, 4, 5, 1, 6 }
            };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.Calculate(array);
            Console.WriteLine($"Сумма элементов в 4-м столбце = {result}");

            Console.ReadLine();
        }
    }
}
