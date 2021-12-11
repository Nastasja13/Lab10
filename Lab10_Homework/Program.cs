using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Угол задан с помощью целочисленных значений gradus - градусов, min - угловых минут, sec - угловых секунд. 
             * Реализовать класс, в котором указанные значения представлены в виде свойств. 
             * Для свойств предусмотреть проверку корректности данных. 
             * Класс должен содержать конструктор для установки начальных значений, 
             * а также метод ToRadians для перевода угла в радианы. Создать объект на основе разработанного класса. 
             * Осуществить использование объекта в программе.*/

            Corner corner = new Corner();
            Corner corner2 = new Corner();
            Corner corner3 = new Corner();

            Console.WriteLine("Введите 3 любых положительных целых числа.");
            corner.Gradus = Convert.ToInt32(Console.ReadLine());
            corner.Min = Convert.ToInt32(Console.ReadLine());
            corner.Sec = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Градус угла = {0}, минута угла = {1}, секунда угла = {2}", corner.Gradus, corner.Min, corner.Sec);

            //Перевести угол в радианы
            double ToRadians = ((corner.Gradus + corner.Min / 60 + corner.Sec / 3600) * Math.PI / 180);
            Console.WriteLine("Радианы угла = {0:f2}", ToRadians);

            Console.ReadKey();
        }
        class Corner
        {
            int gradus;
            int min;
            int sec;

            /*открытый метод, который принимает градусы, которые мы хотим установить при использовании private и public
            public void SetGradus (int gradus)
            {
                //выполнение проверки
                if (gradus>0)
                {
                    //если все ок, присваивает
                                        this.gradus = gradus;
                }    
            }*/

            //Задаем градусы
            public int Gradus
            {
                //установка свойства
                set
                {
                    //выполнение проверки
                    if (value > 0)
                    {
                        //если все ок, присваивает
                        gradus = value;
                    }
                    else
                    {
                        Console.WriteLine("Число должно быть положительное");
                    }
                }
                get
                {
                    return gradus;
                }
            }

            //Задаем минуты
            public int Min
            {
                set
                {
                    if (value > 0)
                    {
                        min = value;
                    }
                    else
                    {
                        Console.WriteLine("Число должно быть положительное");
                    }
                }
                get
                {
                    return min;
                }
            }

            //Задаем секунды
            public int Sec
            {
                set
                {
                    if (value > 0)
                    {
                        sec = value;
                    }
                    else
                    {
                        Console.WriteLine("Число должно быть положительное");
                    }
                }
                get
                {
                    return sec;
                }
            }

            //открытый конструктор


            /*метод для получения значения свойства при использовании private и public
            public int GetGradus()
        {
            return gradus;
        }

        public Corner(int gradus, int min, int sec)
        {
            this.gradus = gradus;
            this.min = min;
            this.sec = sec;
        }*/

            //проверка корректности данных

        }
    }
}
