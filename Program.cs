using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            const double a = 5; //объявляем константу - длина катета а
            const double b = 7; //объявляем константу - длина катета b
            double s, sum, g, gCos; // переменные для площади, суммы квадратов сторон,длины гипотенузы по двум разным формулам
            s = (a * b) / 2 * Math.Sin(90 * Math.PI / 180); //вычисляем площадь треугольника
            sum = Math.Pow(a, 2) + Math.Pow(b, 2); // вычисляем сумму квадратов двух сторон
            g = Math.Sqrt(sum); //вычисляем гипотенузу по теореме Пифагора
            gCos = Math.Sqrt(sum) - 2 * a * b * Math.Cos(90 * Math.PI / 180); // вычисляем гипотенузу по теореме косинусов
            //Выводим информацию в консоль:
            Console.WriteLine("Площадь треугольника равна " + s);
            Console.WriteLine("Длина гипотенузы согласно теореме Пифагора равна " + g);
            Console.WriteLine("Длина гипотенузы согласно теореме косинусов равна " + gCos);
            Console.ReadKey();
        }
    }
}
