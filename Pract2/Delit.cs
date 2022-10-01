using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract2
{
    internal class Delit
    {
        public static void delitel()
        {
            bool flag = false;

            while (!flag)
            {
                try
                {
                    List<int> l1 = new List<int> { };
                    Console.WriteLine("Введите число, делители которого хотите узнать");
                    int n = Convert.ToInt32(Console.ReadLine());
                    if (n == 0)
                    {
                        break;
                    }
                    for (int i = 1; i <= n; i++)
                    {
                        if (n % i == 0)
                        {
                            l1.Add(i);
                        }

                    }
                    string temp = string.Join(" ", l1);
                    Console.WriteLine(temp);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Такой ввод не предполагается");
                }
                
            }
        }
    }
}
