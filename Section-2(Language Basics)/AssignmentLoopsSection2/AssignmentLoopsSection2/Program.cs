using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentLoopsSection2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Write a C# program to print the following output:

                1 2 3 4 7 8 9 10
                1 2 3 4 7 8 9 10
                1 2 3 4 7 8 9 10
                10 9 8 7 6 5 4 3 2 1
                10 9 8 7 6 5 4 3 2 1
                10 9 8 7 6 5 4 3
                10 9 8 7 6 5 4 3 2 1
                1 2 3 4 5 6 7 9 10
            */

            // 1.
            for(int i = 1; i <= 10; i++)
            {
                if (i == 5 || i == 6)
                    continue;
                Console.Write(i + " ");
            }

            Console.WriteLine();

            int whileI = 1;
            while(whileI <= 10)
            {
                if (whileI == 5 || whileI == 6)
                {
                    whileI++;
                    continue;
                }
                Console.Write(whileI + " ");
                whileI++;
            }

            Console.WriteLine();

            int doWhileI = 1;
            do
            {
                if (doWhileI == 5 || doWhileI == 6)
                {
                    doWhileI++;
                    continue;
                }
                Console.Write(doWhileI + " ");
                doWhileI++;
            } while (doWhileI <= 10);
            Console.WriteLine();

            // 2.
            for(int a = 10; a>=1; a--)
          {
                Console.Write(a + " ");
            }

            int i = 10;
            while(i >= 1)
            {
                Console.Write(i + " ");
                i--;
            }


            Console.ReadKey();
        }
    }
}
