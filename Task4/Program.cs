using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите размерность массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int k = 0;
            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, 50);
                Console.Write("{0} ", array[i]);
                if (i % 2 ==0 && (array[i] % 2 != 0))
                {
                    k++;
                }                
            }            
            Console.WriteLine("Количество элементов = {0}", k);         
            Console.ReadKey();
        }
    }
}
