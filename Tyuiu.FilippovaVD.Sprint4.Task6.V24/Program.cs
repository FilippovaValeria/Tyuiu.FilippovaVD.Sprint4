using Tyuiu.FilippovaVD.Sprint4.Task6.V24.Lib;

namespace Tyuiu.FilippovaVD.Sprint4.Task6.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Филиппова В. Д. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Филиппова В. Д. | АСОиУб-26-1                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных. Используя класс Array, выведите элементы   *");
            Console.WriteLine("* массива, длина которых больше 7 символов.                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string[] array = { "Компьютер", "Телефон", "Планшет", "Принтер", "Сканер", "Монитор", "Клавиатура" };

            Console.WriteLine("Исходный массив:");
            foreach (string item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string[] result = ds.Calculate(array);

            Console.WriteLine("Элементы длиной больше 7 символов:");
            foreach (string item in result)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
