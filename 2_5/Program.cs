using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.Write("Введите число :");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите степень :");
            int power = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= num ;
            }
            Console.WriteLine("Результат = {0}", result);

            Console.ReadLine();

        }
    }
}
