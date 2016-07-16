using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_tutorials
{

    class Mathfuncs
    {
        public static int Add(int num1, int num2)
        {

            return num1 + num2;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello");
            Console.WriteLine(Mathfuncs.Add(1, 2));
            Console.ReadKey();
            Console.WriteLine("Hello agrerain bitch!");
        }
    }
}
