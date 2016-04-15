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
            //            ThirdPartOfLesson();
//            WhileAndDoWhile();
//            ForAndForeach();
//For
            int x=0;
            for (int i = 0; i < 180; i++)
            {
                if (i%5 == 0)
                {
                    Console.WriteLine($"x={x} i={i}");
                    x += i;
                }
            }
            Console.WriteLine($"Your result is {x}");

            Console.ReadKey();
        }

        private static void ForAndForeach()
        {
            Console.WriteLine("First for");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Second fro");
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Third For");
            int[] A = new[] {1, 3, 5, 7, 9, 11, 13, 15};
            for (int i = 0; i < A.Length; i++)
            {
                A[i]++;
                Console.WriteLine($"A[{i}] = {A[i]}");
            }
            Console.WriteLine("Reverse For");
            for (int i = A.Length - 1; i >= 0; i--)
            {
                A[i]--;
                Console.WriteLine($"A[{i}] = {A[i]}");
            }
            Console.WriteLine("foreach");
            foreach (int number in A)
                Console.WriteLine(number);
        }

        private static void WhileAndDoWhile()
        {
            string password = "yura";
            while (true)
            {
                Console.WriteLine("Write your password");
                string tempPassword = Console.ReadLine();
                if (tempPassword == password)
                    break;
                else
                    Console.Clear();
            }
            // do while
            int x = 0;
            do
            {
                Console.WriteLine(++x);
            } while (x < 1);
            Console.WriteLine("");
            Console.WriteLine("for");
        }

        private static void ThirdPartOfLesson()
        {
            string word = "Hello Sasha";
            char[] c = word.ToCharArray();
            for (int i = 0; i < c.Length; i++)
                Console.WriteLine(c[i]);
            c[5] = 'x';

            //Char array to string
            word = new string(c);
            Console.WriteLine(word);
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
