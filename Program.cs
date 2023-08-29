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
            char response = 'y';

            while (response == 'y')
            {
                Write("Enter a number: ");
                num = Convert.ToInt32(ReadLine());

                for (int x = 1; x <= num; x++)
                {
                    Write("*");
                }
                WriteLine();

                Write("Do you want to continue (y/n)? ");
                response = Convert.ToChar(ReadLine());
            }

            WriteLine("Program Ended");

        }
    }
}