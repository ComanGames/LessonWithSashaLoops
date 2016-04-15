using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LessonWithSashaLoops
{
    class Program
    {
        static void Main(string[] args)
        {
//            FirstPartOfLesson();
//            SecondPartOfLesson();

            //String to char array  
            string word = "Hello Sasha";
            char[] c = word.ToCharArray();
            for (int i = 0; i < c.Length; i++)
                Console.WriteLine(c[i]);
            c[5] = 'x';

            //Char array to string
            word = new string(c);
            Console.WriteLine(word);

            Console.ReadKey();

        
        }

        private static void SecondPartOfLesson()
        {
            while (true)
            {
                int[] A = new int[3];
                Console.WriteLine(int.MaxValue);
                Console.WriteLine("Write A[0]");
                A[0] = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Write A[1]");
                A[1] = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Write A[2]");
                A[2] = Int32.Parse(Console.ReadLine());

                Console.WriteLine($"A[0] ={A[0]}");
                Console.WriteLine($"A[1] ={A[1]}");
                Console.WriteLine($"A[2] ={A[2]}");
                Console.WriteLine($"A[0]+A[1]+A[2]={A[0] + A[1] + A[2]}");

                Console.ReadKey();
                Console.Clear();
            }
        }

        private static void FirstPartOfLesson()
        {
//Array Initialization first way
            int[] A = new[] {5, 10, 25, 8};
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
        }
    }
}
