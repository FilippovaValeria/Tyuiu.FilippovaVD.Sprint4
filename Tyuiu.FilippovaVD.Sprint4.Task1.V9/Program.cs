using Tyuiu.FilippovaVD.Sprint4.Task1.V9.Lib;

namespace Tyuiu.FilippovaVD.Sprint4.Task1.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Филиппова В. Д. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Филиппова В. Д. | АСОиУб-26-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 13 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 3 до 8. Подсчитать произведение  *");
            Console.WriteLine("* четных элементов массива.                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] array = new int[13];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите {i + 1}-й элемент массива (от 3 до 8): ");
                int input = Convert.ToInt32(Console.ReadLine());

                while (input < 3 || input > 8)
                {
                    Console.Write("Ошибка! Число должно быть от 3 до 8. Повторите ввод: ");
                    input = Convert.ToInt32(Console.ReadLine());
                }
                array[i] = input;
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введенный массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            int result = ds.Calculate(array);
            Console.WriteLine($"Произведение четных элементов = {result}");

            Console.ReadLine();
        }
    }
}
