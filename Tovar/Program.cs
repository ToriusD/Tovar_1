using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tovar
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------------ПЕРВЫЙ ОБЪЕКТ КЛАССА - ВВОД
            Console.WriteLine("=====================================================");
            Console.WriteLine("Информация о товаре_1");
            Console.WriteLine("-----------------------------------------------------");
            Tovar_Class Thing_1 = new Tovar_Class(); // Создание нового объекта Thing_1 (Штука №2)
            Thing_1.Input();

            Console.Clear();

            //---------------ВТОРОЙ ОБЪЕКТ КЛАССА - ВВОД
            Console.WriteLine("=====================================================");
            Console.WriteLine("Информация о товаре_2");
            Console.WriteLine("-----------------------------------------------------");
            Tovar_Class Thing_2 = new Tovar_Class(); // Создание нового объекта Thing_2 (Штука №2)
            Thing_2.Input();

            Console.Clear();

            //---------------ПЕРВЫЙ ОБЪЕКТ КЛАССА - ВЫВОД
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Информация о товаре_1");
            Console.WriteLine("-----------------------------------------------------");
            Thing_1.Print();  // Вывод объекта Thing_1

            //---------------ВТОРОЙ ОБЪЕКТ КЛАССА - ВЫВОД
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Информация о товаре_2");
            Console.WriteLine("-----------------------------------------------------");
            Thing_2.Print();  // Вывод объекта Thing_2


            Console.ReadKey();

        }
    }
}
