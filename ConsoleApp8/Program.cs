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
                Console.WriteLine("1 - Task1");
                Console.WriteLine("2 - Task2");
                Console.WriteLine("3 - Task3");
                Console.WriteLine("4 - Task4");
                Console.WriteLine("5 - Task5");
                Console.Write("Введите номер задачи");
                int tasknumber = int.Parse(Console.ReadLine());

                switch (tasknumber)
                {
                    case 1:
                        Task1();
                        break;
                    case 2:
                        Task2();
                        break;
                    case 3:
                        Task3();
                        break;
                    case 4:
                        Task4();
                        break;
                    case 5:
                        Task5();
                        break;
                }
                Console.ReadLine();
            }
            static void Task1()
            {



                Console.WriteLine("Введите первое число");
                int g = int.Parse(Console.ReadLine());
                Console.WriteLine("Введиите второе число");
                int f = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите третье число");
                int k = int.Parse(Console.ReadLine());
                int min = minnumber(g, f, k);
                Console.WriteLine($"Наименьшее из чисел {min}");
                Console.ReadLine();
            }


            static int minnumber(int g, int f, int k)
            {
                int min = g;
                if (f < g && f < k) min = f;
                if (k < f && k < g) min = k;

                return min;





            }


            static void Task2()
            {
                Console.WriteLine("Введите число для подсчета количества цифр");
                int a = int.Parse(Console.ReadLine());
                int counter = qwantity(a);
                Console.WriteLine("Количество цифр: " + (counter));
                Console.ReadLine();
            }
            static int qwantity(int a)
            {
                int counter = 0;
                while (a != 0)
                {
                    a = a / 10;
                    counter++;

                }
                return counter;
            }





            static void Task3()
            {
            
                string data;

                int i = 0;

                string[] separators = { " " };
                Console.WriteLine("Вводите нечетные числа");
                data = Console.ReadLine();


                Array.ConvertAll(data.Split(separators, StringSplitOptions.RemoveEmptyEntries), int.Parse);
                foreach (int j in data)
                {


                    if ((j % 2 != 0) && (j != 0))
                    {
                        i++;
                    }
                }

                Console.WriteLine($"Вы ввели {i} нечетных чисел");
                Console.ReadLine();
            }

            static void Task4()
            {

                string login = "root";
                string password = "GeekBrains";
                string reglogin;
                string regpassword;
                int z = 0;


                {


                    do
                    {

                        Console.WriteLine("Введите Ваш логин");
                        reglogin = Console.ReadLine();
                        Console.WriteLine("Введите Ваш пароль");
                        regpassword = Console.ReadLine();
                        z++;
                    }
                    while (z < 3 && reglogin != login && regpassword != password);
                    Console.WriteLine("Вы неправильно ввели пароль и логин");

                    Console.ReadLine();

                }
            }

            static void Task5()
            {
                Console.WriteLine("Введите Ваш вес");
                int m = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите Ваш рост");
                int h = int.Parse(Console.ReadLine());
                double I = m / (h * h);
                if (I <= 19.5)
                {
                    Console.WriteLine("Вам необходимо поправиться");
                }
                else if (I > 19.5 && I < 27)
                {
                    Console.WriteLine("У Вас нормальный вес");
                }
                else
                {
                    Console.WriteLine("Вам необходимо похудеть");
                }
                Console.ReadLine();
            }
        }
    }

