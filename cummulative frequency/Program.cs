using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cummulative_frequency
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("To Enter the Number & Find the Cummulative Frequency ");
            Console.WriteLine("---------------------------------------------------- ");
            int max, min;
            Console.WriteLine("Enter the Minium Number of Frequency");
            min = int.Parse(Console.ReadLine());
            Console.WriteLine("Maximum Number of Frequency");
            max = int.Parse(Console.ReadLine());
            int n;
            int[] a = new int[10]; //{1,1,1,2,4,5,6,7,8};
            Console.WriteLine("Enter value");
            for (int i = min; i <= max; i++)
            {
                n = int.Parse(Console.ReadLine());
                a[i] = n;
            }
            int a1 = 1, b = 0;
            for (int j = min; j <= max; j++)
            {

                for (int i = 1; i <= 9; i++)
                {

                    if (a1 == a[i])
                    {
                        b = ++b;
                    }


                }
                ++a1;

                Console.WriteLine("No of {0}'s = {1} ", j, b);
                b = 0;

            }
        }
    }
}
