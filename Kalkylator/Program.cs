using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkylator
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            //Random rnd = new Random();
            //int color = rnd.Next(0, 10);
            //Console.WriteLine(color);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Нажмите 1 если хотите выполнить сложение");
            Console.WriteLine("Нажмите 2 если хотите выполнить вычитание");
            Console.WriteLine("Нежмите 3 если хотите выполнить умножене");
            Console.WriteLine("Нажмите 4 если хотите выполнить деление");
            Console.WriteLine("Нажмите 5 если хотите найти остаток от деления");
            int Enter = int.Parse(Console.ReadLine());

            if (Enter == 1)
            {
                Console.WriteLine("Введите слагаемое 1:_");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите слагаемое 2:_");
                int num2 = int.Parse(Console.ReadLine());
                int otv = num1 + num2;
                Console.WriteLine("Сумма чисел = " + otv);
            }
            else if (Enter == 2)
            {
                Console.WriteLine("Введите уменьшаемое :_");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите вычитаемое :_");
                int num2 = int.Parse(Console.ReadLine());
                int otv = num1 - num2;
                Console.WriteLine("Разница чисел = " + otv);
            }
            else if (Enter == 3)
            {
                Console.WriteLine("Введите множитель 1:_");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите множитель 2:_");
                int num2 = int.Parse(Console.ReadLine());
                int otv = num1 * num2;
                Console.WriteLine("Произведение чисел = " + otv);
            }
            else if (Enter == 4)
            {
                Console.WriteLine("Введите делимое:_");
                double num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите делитель :_");
                double num2 = double.Parse(Console.ReadLine());
                    double otv = num1 / num2;
                    Console.WriteLine("Частное чисел = " + otv);
                

            }
            else if (Enter == 5)
            {
                Console.WriteLine("Введите делимое:_");
                double num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите делитель :_");
                double num2 = double.Parse(Console.ReadLine());
                double otv = num1 % num2;
                Console.WriteLine("Остаток от деления = " + otv);
            }
            else
            {
                Console.BackgroundColor= ConsoleColor.Red;
                Console.WriteLine("Значение некорректно");
            }
        }
    }
}
