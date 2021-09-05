using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ЗАДАНИЕ 2
            Console.Clear();
            Console.WriteLine("Введите, Ваш рост");
            string h = Console.ReadLine();
            Console.WriteLine("Введите, Ваш вес");
            string m = Console.ReadLine();

            int heigh = int.Parse(h);
            int waist = int.Parse(m);
            Console.WriteLine("Ваш индекс массы тела: " + waist / Math.Pow(heigh, 2));
            Console.ReadLine();
            #endregion КОНЕЦ ЗАДАНИЯ 2

            #region ЗАДАНИЕ 3
            Console.Clear();
            Console.WriteLine("Введите имя первой координаты по горизонтали");
            string number1 = Console.ReadLine();
            Console.WriteLine("Введите имя первой координаты по вертикали");
            string number2 = Console.ReadLine();
            Console.WriteLine("Введите имя второй координаты по горизонтали");
            string number3 = Console.ReadLine();
            Console.WriteLine("Введите имя второй координаты по вертикали");
            string number4 = Console.ReadLine();
            int x1 = int.Parse(number1);
            int y1 = int.Parse(number2);
            int x2 = int.Parse(number3);
            int y2 = int.Parse(number4);
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"расстояние между точками{r:f2}");
            Console.ReadLine();
            #endregion КОНЕЦ ЗАДАНИЯ 3 

            #region ЗАДАНИЕ 4
            Console.Clear();
            Console.WriteLine("Введите первое значение");
            string a = Console.ReadLine();
            Console.WriteLine("Введите второе значение");
            string b = Console.ReadLine();

            int aa = Convert.ToInt32(a);
            int bb = Convert.ToInt32(b);
            aa = aa + bb;
            bb = aa - bb;
            aa = aa - bb;

            Console.WriteLine($"Первое значение равно второму значению {aa}");
            Console.WriteLine($"Второе значение равно первому значению {bb}");
            Console.ReadLine();
            #endregion

        }
    }
}
