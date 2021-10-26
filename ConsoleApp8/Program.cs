using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    #region первое задание
    class ax
    {
        public delegate double Fun(double a, double x);


        public static void Table(Fun F, double a, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,08:0.000} | {1,08:0.000} |", x, F(a, x));
                x += 1;


            }
            Console.WriteLine("---------------------");
        }

        public static double MyFunc(double a, double x)
        {
            return a * x * x;
        }

        public static void function1()
        {

            Console.WriteLine("Таблица функции MyFunc:");
            Table(new Fun(MyFunc), 2, -2, 2);
            Console.WriteLine("Еще раз та же таблица, но вызов организован по новому");
            Console.ReadLine();
        }
    }


    class sin
    {
        public delegate double Fun(double a, double t);


        public static void Table(Fun F, double a, double t, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (t <= b)
            {
                Console.WriteLine("| {0,08:0.000} | {1,08:0.000000000000000} |", t, F(a, t));
                t += 1;


            }
            Console.WriteLine("---------------------");
        }


        public static double MyFunc(double a, double t)
        {
            double x = t * Math.PI / 180;
            return a * Math.Sin(x);
        }

        public static void function()
        {

            Console.WriteLine("Таблица функции MyFunc:");
            Table(new Fun(MyFunc), 2, -2, 2);
            Console.WriteLine("Еще раз та же таблица, но вызов организован по новому");
            Console.ReadLine();
        }
    }
    #endregion
    #region второе задание
    class zad2
    {
        public delegate double F(double x);

        public static double F1(double x)
        {
            return x * x - 50 * x + 10;
        }
        public static double F2(double x)
        {
            return x * 5;
        }
        public static double F3(double x)
        {
            return 5 * x + 2;
        }
        public static void SaveFunc(string fileName, F del, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(del(x));
                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }
        public static double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {

                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }
        public static void result()
        {




            string g = Console.ReadLine();

            /*switch (g)
            {
                case string F1:
                    zad2.F1();
                    break;
                case string F2:
                    zad2.F2();
                    break;
                case string F3:
                    zad2.F3();
                    break;

            }

            */


            F del;
            if (g == "F1")
            {
                del = F1;
            }
            else if (g == "F2")
            {
                del = F2;
            }
            else
            {
                del = F3;
            }

            SaveFunc("data.bin", del, -100, 100, 0.5);
            Console.WriteLine(Load("data.bin"));


            Console.ReadKey();
        }
    }
    #endregion
    #region третье задание
    class zad3
    {
        public static void course()
        {

            int course = 0;


            ArrayList list = new ArrayList();

            DateTime dt = DateTime.Now;
            StreamReader sr = new StreamReader("students_1.txt");
            while (!sr.EndOfStream)
            {
                string[] s = sr.ReadLine().Split(';');

                if (int.Parse(s[6]) >= 5) course++;
            }


            sr.Close();
            list.Sort();

            Console.WriteLine("Количество студентов, учащихся на 5,6 курсах:{0}", course);
            foreach (var v in list) Console.WriteLine(v);

            Console.ReadKey();
        }
        public static void age()
        {


            int course = 0;

            ArrayList list = new ArrayList();

            DateTime dt = DateTime.Now;
            StreamReader sr = new StreamReader("students_1.txt");
            while (!sr.EndOfStream)
            {
                string[] s = sr.ReadLine().Split(';');

                string name = s[1];
                string surame = s[2];
                string age = s[5];
                course = int.Parse(s[6]);

                if (int.Parse(s[5]) >= 18 && int.Parse(s[5]) <= 20)
                {
                    list.Add(s[1] + " " + s[0] + " " + course);

                }


            }


            sr.Close();
            list.Sort();
            Console.WriteLine("Количество студентов в возрасте от 18 до 20 лет:{0}", list);
            foreach (var v in list) Console.WriteLine(v);

            Console.ReadKey();

        }

        public static void Sort()
        {

            ArrayList list = new ArrayList();

            DateTime dt = DateTime.Now;
            StreamReader sr = new StreamReader("TextFile1.txt");
            while (!sr.EndOfStream)
            {
                string[] s = sr.ReadLine().Split(';');

                string name = s[0];
                string surame = s[1];
                string age = s[5];

                list.Add(s[5] + " " + s[0] + " " + s[1]);

            }
            list.Sort();

            sr.Close();

            Console.WriteLine($"{list}");


            foreach (var v in list) Console.WriteLine(v);

            Console.ReadKey();

        }
    }

    #endregion
    class Program
    {

        static void Main(string args)
        {
            
          ax.function1();
          sin.function();            
            zad2.result();
            zad3.course();
            zad3.age();
            zad3.Sort();
          

        }
    }
}



