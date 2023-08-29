using System.Reflection.Metadata.Ecma335;
using static System.Console;

/**************************************
 * Author:      Scott Cordle
 * Date:        08/29/2023
 * Project:     Loops (for CSC105)
 * Resources:   
 *************************************/

namespace CSC150_1001_Loops_wsc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            char response = 'y';                                // start value

            while (response == 'y')                             // stop value
            {
                Write("Enter a number: ");
                num = Convert.ToInt32(ReadLine());

                for (int x = 1; x <= num; x++)                  // (start, stop, change) values
                {
                    Write("*");
                }
                WriteLine();

                Write("Do you want to continue (y/n)? ");       // change value
                response = Convert.ToChar(ReadLine());
            }

            WriteLine("Program Ended");

        }
    }
}