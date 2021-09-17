using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
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

        class Program
        {
            static void Sum(string[] args)
            {
                int i = 12;
                Complex complex01 = new Complex();
                complex01.re = 3;
                complex01.im = 2;

                Complex complex02 = new Complex();
                complex02.re = -2;
                complex02.im = 7;

                Complex complex03 = complex01.Plus(complex02);

                Console.WriteLine(complex03);
                Console.ReadLine();



            }
            static void Min()
            {

                Complex complex04 = new Complex();
                complex04.re = 3;
                complex04.im = 2;

                Complex complex05 = new Complex();
                complex05.re = -2;
                complex05.im = 7;

                Complex complex06 = complex04.Minus(complex05);
                Console.WriteLine(complex06);
                Console.ReadLine();

            }

            class Lash
            {
                public double rre;
                public double iim;
                public Lash(double rre, double iim);

          {
                this.rre = rre;
                this.iim = iim;
               
        }
            public Lash Plus(Lash l)

            {
                Lash s;
                s.rre = rre + l.rre;
                s.iim = iim + l.iim;
                return s;

            }

            public Lash Minus(Lash w)

            {
                Lash j;
                j.rre = rre - w.rre;
                j.iim = iim - w.iim;
                return j;

            }
            public override string ToString()
            {
                return $"{rre} + {iim}i";
            }
            class Program
            {
                static void Main()
                {


                    Lash lash01 = new Lash(3, 2);

                    int i = 12;
                    Lash lash01 = new Lash();
                    lash01.rre = 3;
                    lash01.iim = 2;

                    Lash lash02 = new Lash(-2, 7);
                    lash02.rre = -2;
                    lash02.iim = 7;
                    lash03 = lash01.Plus(lash02);

                    Console.WriteLine(lash03);
                    Console.ReadLine();

                }


                static void Minus(string[] args)
                {

                    Lash lash04 = new Lash(3, 2); ;
                    lash04.rre = 3;
                    lash04.iim = 2;

                    Lash lash05 = new Lash(-2, 7);
                    lash05.rre = -2;
                    lash05.iim = 7;

                    lash06 = lash04.Minus(lash05);

                    Console.WriteLine(lash06);
                    Console.ReadLine();



                }
            }
}
