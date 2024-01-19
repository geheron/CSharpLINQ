using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };

            var queryResult = from num in arr
                              where (num % 2 == 0)
                              select num;

            Console.WriteLine("Query syntax result:");
            foreach(var item in queryResult)
            {
                Console.WriteLine(item);
            }

            var methodResult1 = arr.Where(num => num % 2 == 0);
            var methodResult = methodResult1.Select(num => num);

            Console.WriteLine("Method syntax result:");
            foreach (var item in methodResult)
            {
                Console.WriteLine(item);
            }
        }
    }
}
