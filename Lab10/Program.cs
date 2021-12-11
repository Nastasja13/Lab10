using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.name = "Мурка";
            cat.color = "Черный";
            cat.age = 1;

            /* Cat cat = new Cat("Мурка", "черный", 1);
              Cat cat2 = new Cat("Мурка");
             Cat cat3 = new Cat("Мурка", "черный", 1);*/

            //попросить помяукать
            Console.WriteLine("Кошечка говорит:");
            cat.Say();

            //обратиться к полю класса, например - какой цвет
            Console.WriteLine("Цвет кошечки - {0}", cat.color);
            Console.ReadKey();
        }

    }
    class Cat
    {
        //поля
        public string name;
        public string color;
        public int age;

        /*конструктор (тоже метод) - для начальной инициализации полей
        public Cat (string n, string c, int a)
        {
            name = n;
            color = c;
            age = a;
        }

        или 

        public Cat(string n)
        {
            name = n;
            color = "Серый";
            age = 1;
        }

         или

        public Cat(string name, string color = "Серый", int age = 1)
        {
            this.name = name;
            this.color = color;
            this.age = age;
        }*/

        //метод
        public void Say()
        {
            Console.WriteLine("Мяу! Меня зовут {0}", name);
        }
    }
}

