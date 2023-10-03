using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConcepts12B2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Use, understand and know how the following
            //statement types can be combined in programs:

            //variable declaration
            int intIdentifier;
            string stringIdentifier = "This is a string";
            //constant declaration
            const int answer = 42;
            const string neverChangeMe= "Hello World";

            //assignment
            intIdentifier = 42;
            stringIdentifier = Console.ReadLine();
            Console.WriteLine(stringIdentifier);

            //iteration
            for(int i=1;i<10;i++)
            {
                Console.WriteLine(i);
            }
            int[] nums = { 1, 2, 6, 5, 1, 7, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            
            for(int i = 0;i<nums.Length;i++)
            {
                Console.WriteLine(nums[i]);
            }
            foreach(int num in nums)
            {
                Console.WriteLine(num);
            }
            foreach(char c in stringIdentifier)
            {
                Console.WriteLine(c);
            }
            for(int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            int n = 1;
            while(n< 10)
            {
                n++;
            }
            Console.WriteLine(n);
            n = 1;
            //while (n >= 1)
            //{
            //    n++;
            //}
            //Console.WriteLine(n);

            n = 10;
            while(n< 10)
            {
                n++;
            }
            Console.WriteLine(n); // n is 10 as it never loops

            n = 10;
            do
            {
                n++;
            }while(n< 10);
            Console.WriteLine(n); // n is 11 as it loops once




            //selection
            //subroutine(procedure / function).
    

        }
    }
}
