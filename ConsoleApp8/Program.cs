using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3
{

    struct Complex
    {
        public double re;
        public double im;



        public Complex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        public Complex Plus(Complex x)
        {
            Complex y;
            y.re = re + x.re;
            y.im = im + x.im;
            return y;
        }



        public Complex Minus(Complex u)
        {
            Complex h;
            h.re = re - u.re;
            h.im = im - u.im;
            return h;
        }

        public override string ToString()
        {
            return $"{re} + {im}i";
        }
    }
    class Lash
    {
        public double re;
        public double im;



        public Lash Plus(Lash l)

        {
            Lash s = new Lash();


            s.re = re + l.re;
            s.im = im + l.im;
            return s;
        }


        public Lash Minus(Lash w)

        {


            Lash j = new Lash();

            j.re = re - w.re;
            j.im = im - w.im;
            return j;
        }

        public override string ToString()
        {
            return $"{re} + {im}i";
        }
    }
    class Program

    {
        static void Main(string[] args)




        {
            Lash lash01 = new Lash();
            lash01.re = 5;
            lash01.im = 7;
            Lash lash02 = new Lash();
            lash02.re = 4;
            lash02.im = 2;
            Console.WriteLine("Введите название операции");
            string answer = Console.ReadLine();

            Lash lash03 = lash01.Plus(lash02);
            Lash lash04 = lash01.Minus(lash02);

            switch (answer);
            {
                case "+": 
                Console.WriteLine(lash03);
                break;
                case "-": 
                Console.WriteLine(lash04);
                break;


            }
        }
    }
    class Program1
    {l
        static void myMain(string[] args)
        {
            int a;
            int b = 0;


            do
            {
                Console.WriteLine("Выведите число на экран");

                int.TryParse(Console.ReadLine(), out a);

                if (a % 2 != 0)
                {
                    b = b + a;
                    Console.WriteLine(b);

                }
                else
                {
                    Console.WriteLine("Вы ввели четное число");

                }
            }
            while (a != 0);
        }
    }
}


                



            


        
    

