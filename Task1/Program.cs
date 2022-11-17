using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите размерность массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            int S = 0;
            for (int i = 0; i <n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                S += array[i];
            }
            Console.WriteLine("Среднее значение = {0}", ((double)S)/n);
            Console.ReadKey();
        }
    }
}
