using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Strings_Loops
{
    class Program
    {

        public static string[] S;
        public static int counter = 0;
        static void Main(String[] args)
        {
            int T = Int32.Parse(Console.ReadLine());
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            S = new string[T];


            for ( int i = 0; i < T; i++)
            {
                S[i] = Console.ReadLine();
                
            }
           
            for (int j = 0; j < S.Length; j++)
            {
                    char[] myCharArray = S[j].ToCharArray();

                for (int k = 0; k < myCharArray.Length; k++)
                {
                    if (k % 2 == 0 || k == 0)
                    {
                        Console.Write(myCharArray[k]);
                    }
                }
                     Console.Write(" ");
                for (int i = 0; i < myCharArray.Length; i++)
                {
                    if (i % 2 == 1)
                    {
                        Console.Write(myCharArray[i]);
                    }
                }
                Console.WriteLine();

            }
               
            

            Console.ReadLine();
        }
    }
}
