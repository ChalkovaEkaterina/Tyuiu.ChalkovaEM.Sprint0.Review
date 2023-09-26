using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int j = i++;
            int k = ++j;
            Console.Write("i=" + i + "\\");
            Console.Write("j=" + j);
            Console.Write("k=" + k);
            Console.ReadKey();
        }
    }
}
