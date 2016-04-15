using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonWithSashaLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array Initialization first way
            int[] A = new[] {5, 10, 25,8};
            //Array Initialization second way
            int[] B = new int[3];
            //Array intialization last way
            int[] C;
            C = new int[5];

            //{5,10,25}
            Console.WriteLine("Array A");
            Console.WriteLine($"A[0] ={A[0]}");
            Console.WriteLine($"A[1] ={A[1]}");
            Console.WriteLine($"A[2] ={A[2]}");
            Console.WriteLine($"A[3] ={A[3]}");
            Console.WriteLine("");
            Console.WriteLine("Array B");
            Console.WriteLine($"B[0] ={B[0]}");
            Console.WriteLine($"B[1] ={B[1]}");
            Console.WriteLine($"B[2] ={B[2]}");
            Console.WriteLine("");
            Console.WriteLine("Legth of Arrays");
            Console.WriteLine($"A.Length ={A.Length}");
            Console.WriteLine($"B.Length ={B.Length}");


            Console.ReadKey();

        }
    }
}
