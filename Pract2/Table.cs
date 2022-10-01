using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract2
{
    internal class Table
    {
        public static void table()
        {
            List<int[]> l1st = new List<int[]>();

            for (int i = 1; i < 10; i++)
            {
                int[] ar = new int[9];
                for (int j = 1; j < 10; j++)
                {
                    ar[j - 1] = i * j;
                }
                l1st.Add(ar);
            }
            Console.WriteLine();
            Console.WriteLine();
            foreach (int[] vak in l1st)
            {
                List<int> l2 = new List<int>();
                foreach (int lak in vak)
                {
                    l2.Add(lak);
                }
                string temp = string.Join("\t", l2);
                Console.WriteLine(temp);
            }
        }
    }
}
