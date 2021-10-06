using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp8
{
    class Program
    {
              

        static bool symbol(string login)
        {
            return (login.Length > 2) && (login.Length < 10);
        }

        public static void login()
        {
            Console.Write("Введите логин");
            string login = Console.ReadLine();

            string letter = "abcdefghijklmnopqrstuvwxyz";
            string numeric = "1234567890";
            string symbol = letter + numeric;

            bool logincorrect = true;
            for (int i = 0; i < login.Length; i++)
            {
                if (symbol.Contains(login[i]) == false)
                {
                    logincorrect = false;
                }
            }

            if (logincorrect)
            {
                Console.WriteLine("Логин содержит корректные символы");

            }

            else
            {
                Console.WriteLine("Логин содержит не корректные символы");

            }
            if (numeric.Contains(login[0]) == false)
            {
                Console.WriteLine("Первый символ логина корректный");
            }

            else
            {
                Console.WriteLine("Первый символ логина НЕ корректный");
            }
            Console.ReadLine();
        }
    }






    class Message
    {




        public static string message()

        {
            //Вводим текст сообщения
            Console.WriteLine("Введите текст сообщения");
            string message1 = Console.ReadLine();
            return message1;

        }

        public static string[] mes()
        {
            //Разделяем сообщение на массив слов при помощи метода Split
            string[] separators = { ".", ", ", " ", " ?", "!", ";" };
            string message2 = message();

            string[] words = message2.Split(separators, System.StringSplitOptions.RemoveEmptyEntries);

            return words;

        }

        static void quantity(string[] words)
        {
            //Вводим количество максимальное символов 
            Console.WriteLine("Введите количество символов");
            int N = int.Parse(Console.ReadLine());


            for (int i = 0; i < words.Length; i++) //Перебираем массив
            {
                if (words[i].Length <= N)
                {

                    Console.WriteLine(words[i]); //Выводим каждый эллемент массива, если он соответсвует условию
                }
            }
            Console.ReadLine();
        }




        public static void mes5()
        {
            string[] f = mes();


            quantity(f);
        }

        public static void symbhol()
        {
            string[] j = mes(); //инициализируем массив из слов из метода mes() переменной j
            Console.WriteLine("Введите последний символ");
            char u = char.Parse(Console.ReadLine()); //задаем символ
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < j.Length; i++)
            {
                string d = j[i];
                char last = d[d.Length - 1]; //определяем последний символ
                if (u != last)
                {
                    string p = j[i]; //выводим массив из слов, не заканчивающихся на заданный символ
                }
                else
                {
                    j[i] = " ";
                }




                stringBuilder.Append(" " + j[i]); //добавляем слова, которые должны остаться в предложении

                Console.WriteLine(stringBuilder.ToString()); //выводим сообщение 
            }
            Console.ReadLine();
        }



        static void Main(string[] args)

        {
            Console.WriteLine("Введите номер задания");
            int w = int.Parse(Console.ReadLine());
            switch (w)
            {
                case 1:

                    Program.login();
                    break;
                case 2:
                    Message.mes5();
                    break;
                case 3:
                    Message.symbhol();
                    break;

            }
            Console.ReadLine();
        }

    }
}