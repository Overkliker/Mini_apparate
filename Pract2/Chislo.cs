using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract2
{
    internal class Chislo
    {
        public static void chislo()
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 100);
            Console.WriteLine("Мы загадали число от 1 до 100");
            while (true)
            {
                try
                {
                    Console.WriteLine("Попробуйте угадать наше число, введите своё:");
                    int inp = Convert.ToInt32(Console.ReadLine());

                    if (inp < value )
                    {
                        Console.WriteLine("Загаданное число больше");
                    } 
                    else if (inp > value)
                    {
                        Console.WriteLine("Загаданное число меньше");
                    }
                    else if (inp == value)
                    {
                        Console.WriteLine("Вы угадали!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели что-то не то...");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Такой ввод не предполагается");
                }
                
                
            }
                
        }
    }
}
