using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проверка_на_високосность_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое положительное число");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 4 == 0)
                    Console.WriteLine("Високосный");
            else
                Console.WriteLine("Не високосный");
            Console.ReadLine();
        }
    }
}