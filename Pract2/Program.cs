using System;


namespace Pract2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;

            while (!flag)
            {
                try
                {
                    Console.WriteLine("Выберете программу: 1 - игра 'Угадай число'; 2 - Таблица умножения; 3 - Делители числа; 4 - Выход");
                    int input = Convert.ToInt32(Console.ReadLine());

                    if (input == 1)
                    {
                        Chislo.chislo();
                    }

                    else if (input == 2)
                    {
                        Table.table();
                    }

                    else if (input == 3)
                    {
                        Delit.delitel();
                    }

                    else if (input == 4)
                    {
                        flag = true;
                    }
                    else
                    {
                        Console.WriteLine("Некоректный ввод");
                    }
                }catch (FormatException)
                {
                    Console.WriteLine("Такой ввод не предполагается");
                }
            }

        }
    }
}