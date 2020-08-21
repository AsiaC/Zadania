using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bubble sort");
            int[] tab = { 7, 6, 5, 4, 3, 2, 1 };
            BubbleSortAlgoritm(tab);

            Console.ReadKey();
        }

        private static void BubbleSortAlgoritm(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                for (int k = 0; k < tab.Length - i - 1; k++)
                {
                    if (tab[k] > tab[k+1])
                    {
                        int hold = tab[k];
                        tab[k] = tab[k + 1];
                        tab[k + 1] = hold;
                    }
                }
            }
            Console.WriteLine("[{0}]", String.Join(",",tab));
            Console.WriteLine();
        }
    }
}
