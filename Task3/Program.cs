using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите размерность массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < ((n/2) - 1); i++)
            {
                for (int j = i+1; j < n/2; j++)
                {
                    if (array[i]>array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            Console.WriteLine();
            for (int i = n/2; i < n - 1; i++)
            {
                for (int k = i + 1; k < n; k++)
                {
                    if (array[i] < array[k])
                    {
                        int m = array[i];
                        array[i] = array[k];
                        array[k] = m;
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i <n; i++)
            {
                Console.Write("{0} ", array[i]);
            }           
            Console.ReadKey();
        }
    }
}
