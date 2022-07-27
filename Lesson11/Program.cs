using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Давайте решим линейное уравнение.");
            Console.WriteLine("Введите число k");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число b");
            double b = Convert.ToDouble(Console.ReadLine());
            Lineynoe lineynoe = new Lineynoe(k, b);
            Console.WriteLine(lineynoe.Root());
            Console.ReadKey();
        }
    }
}
