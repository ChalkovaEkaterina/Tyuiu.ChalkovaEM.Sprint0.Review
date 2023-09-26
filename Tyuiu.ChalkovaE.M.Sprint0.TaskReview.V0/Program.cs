using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ChalkovaE.M.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.ChalkovaE.M.Sprint0.TaskReview.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите 1 число = ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите 2 число = ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите 3 число = ");
            int n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Значение выражения ({n1} + {n2} + {n3}) * 5 = " + DataService.Calc(n1, n2, n3));
            Console.ReadKey();
        }
    }
}
