using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest8._1_3
{
    internal class Program
    {
        ///////////////////////////////////////////  1  /////////////////////////////////////////


        static string Calculate(int a, int b, int c)
        {
            return $"Результат деления чисел {a}; {b}; {c} на 5: {a / 5}; {b / 5}; {c / 5}";
        }


        ///////////////////////////////////////////  2  /////////////////////////////////////////


        static string Credit(int sum_credit)
        {
            Console.WriteLine($"Сумма кредита: {sum_credit}");
            bool run = true;
            do
            {
                Console.WriteLine("Введите сумму платежа");
                int pay_credit = int.Parse(Console.ReadLine());
                sum_credit -= pay_credit;
                if (sum_credit <= 0) { run = false; }
                else { Console.WriteLine($"Вам осталось внести: {sum_credit}"); }
            }
            while (run);

            return "Кредит погашен";
        }


        ///////////////////////////////////////////  3  /////////////////////////////////////////


        static int Factorial(int a)
        {
            if (a == 0) return 1;
            return a * Factorial(a - 1);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("\nЗадание 1"); /////////////////////////  1  ///////////////////////////


            Console.WriteLine("Введите три числа:");
            Console.WriteLine(Calculate(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));


            Console.WriteLine("\nЗадание 2"); /////////////////////////  2  ///////////////////////////


            Console.WriteLine(Credit(700));


            Console.WriteLine("\nЗадание 3"); /////////////////////////  3  ///////////////////////////

            Console.WriteLine("Введите количество клиентов, ждущих доставку:");
            Console.WriteLine($"Количество возможных маршрутов доставки: {Factorial(int.Parse(Console.ReadLine()))}");


            Console.ReadKey();
        }
    }
}
