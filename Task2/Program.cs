using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
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
                array[i] = random.Next(0,50);
                Console.Write("{0} ", array[i]);                
            }
            Console.WriteLine();
            int max = array[0];
            foreach (int a in array)
            {
                if (a > max)
                    max = a;
            }
            int min = array[0];
            foreach (int b in array)
            {
                if (b < min)
                    min = b;
            }
            Console.WriteLine("Максимальное значение max = {0}", max);
            Console.WriteLine("Минимальное значение min = {0}", min);
            Console.WriteLine("Сумма min и max = {0}", (min + max));
            Console.ReadKey();
        }
    }
}
