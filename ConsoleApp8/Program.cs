using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class MyArray

    {

        public static int[] a;
        public static Random random = new Random();
        public static int t = 0;

        public MyArray()
        {
            a = new int[20];
            for (int i = 0; i < 20; i++)
                a[i] = random.Next(-10000, 10001);

        }

        public static int Nymber2()
        {

            foreach (int i in a)
                if (a[i] % 3 == 0) t++;

            return t;

        }

        public static void Number()
        {
            Console.WriteLine(t / 2);

            Console.ReadLine();
        }
        class MyArray1

        {


            static void Summa()


            {


                int[] a = { 1, 3, 7, 7, 8, 9, 7, 6, 8, 9, 7 };
                int Sum = 0;
                for (int i = 0; i < 11; i = i + 2)
                {

                    Sum += a[i];
                }
                Console.WriteLine(Sum);
                Console.ReadLine();


            }
            static void Inverse()
            {
                int[] a = { 1, 3, 7, 7, 8, 9, 7, 6, 8, 9, 7 };
                for (int i = 0; i < 11; i++)

                    Console.WriteLine(-a[i]);
                Console.ReadLine();

            }
            static void Multi()
            {
                int[] a = { 1, 3, 7, 7, 8, 9, 7, 6, 8, 9, 7 };
                for (int i = 0; i < 11; i++)

                    Console.WriteLine(a[i] * 7);
                Console.ReadLine();
            }


            class Array2
            {
                public void Array()
                {
                    Random random1 = new Random();
                    int[,] arr = new int[3, 3];

                    for (int i = 0; i < 3; i++)

                    {
                        for (int j = 0; j < 3; j++)
                        {
                            arr[i, j] = random1.Next(-8, 8);
                        }


                    }
                }
                public static int Summa1()
                {
                    int[,] arr = new int[3, 3];
                    int Sum1 = 0;

                    for (int i = 0; i < 3; i++)

                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Sum1 += arr[i, j];

                        }


                    }
                    return Sum1;

                }

                class Program
                {

                    static void Main(string[] args)
                    {
                        Console.WriteLine("Напишите название метода: пары эллементов массива, сумма эллементов массива, умножение эллементов массива, отрицательное значение,сумма элементов двумерного массива ");
                        string answer = Console.ReadLine();
                        switch (answer)
                        {
                            case "пары эллементов массива":
                                Console.WriteLine(t / 2);
                                break;
                            case "сумма эллементов массива":
                                Console.WriteLine(Summa());
                                break;
                            case "умножение эллементов массива":
                                Console.WriteLine(Multi());
                                break;
                            case "отрицательное значение":
                                Console.WriteLine(Inverse());
                                break;
                            case "сумма элементов двумерного массива":
                                Console.WriteLine(Summa1());
                                break;

                        }

                    }
                }
            }


        }
    }
}
