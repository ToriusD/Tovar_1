using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tovar
{
    class Tovar_Class
    {
        //---------------АТРИБУТЫ КЛАССА
        private string name;    // Наименование товара
        private int quantity;  // Количество данного товара
        private float price;  // Цена данного товара

        //---------------ГЕТТЕРЫ И СЕТТЕРЫ
        public string Name { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }



        //---------------МЕТОД ВЫВОДА
        public virtual void Print()
        {
            Console.WriteLine("Название:        " + "[" + name + "]");
            Console.WriteLine("Количество:      " + "[" + quantity + "]");
            Console.WriteLine("Цена:            " + "[" + price + "]");
        }

        //---------------МЕТОД ВВОДА
        public virtual void Input()
        {
            Console.Write("Название:        ");
            name = Console.ReadLine();
            Console.Write("Количество:      ");
            quantity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Цена:            ");
            price = Convert.ToInt64(Console.ReadLine());
        }

    }
}
