using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Lab 1
Create a program to ask the user for 5 numbers, store them in an array and show them in reverse order.
*/
namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArr = new int[5];


            Console.WriteLine("Enter 5 Numbers to be Reversed");
            //loops in order to fill our array and let user know how many more numbers to input.
            for (int i = 4; i >= 0; i--)
            {
                numArr[i] = readNumber();
                Console.WriteLine("Enter " + i + "  more numbers to be Reversed");
            }

            Console.WriteLine("");
            //Writes user's numbers to console in reverse order
            Console.WriteLine("The numbers in reverse are:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(numArr[i]+" ");
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Enter any value to exit...");
            Console.Read();

        }

        //Readline only takes in strings so I created a method to convert into an integer.
        public static int readNumber()
        {
           return Convert.ToInt32(Console.ReadLine());
        }
    }
}
