using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic_progression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of cases: ");
            int n = int.Parse(Console.ReadLine());
            int[,] cases = new int[n,3];
            int[] result = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter first value of sequence: ");
                cases[i, 0] = int.Parse(Console.ReadLine());
                Console.Write("Enter step size for sequence: ");
                cases[i, 1] = int.Parse(Console.ReadLine());
                Console.Write("Enter number of progression members to calculate: ");
                cases[i, 2] = int.Parse(Console.ReadLine());
                for (int j = cases[i,2]-1; j >= 0; j--)
                {
                    result[i] += cases[i, 0] + j * cases[i, 1]; 
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(result[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
