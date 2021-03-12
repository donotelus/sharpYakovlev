using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace lessonBaseYakovlev

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите фамилию ");
            var familia = Console.ReadLine();
            Console.Write("Введите имя ");
        
            var imya = Console.ReadLine();
            Console.Write("Возварст ");
         
            var age = Console.ReadLine();
            Console.Write("Введите вес ");
          
            var wes = Console.ReadLine();
            Console.Write("ВВедите рост ");
           
            var tall = Console.ReadLine();
            Console.WriteLine("Вы "+ familia + " " + imya + " Ваш Возраст " + age + " Вес " + wes + " Рост " + tall);

            Console.WriteLine(String.Format("Вы {0} {1} Ваш Возраст {2} Вес {3} Рост {4}", familia, imya, age, wes, tall));

            Console.WriteLine($"Вы {familia} {imya} Ваш возраст {age} вес {wes} рост {tall}");







        }
    }
}
