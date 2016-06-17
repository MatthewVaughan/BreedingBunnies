using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
// File/Project Prolog
// Name: Matthew Vaughan
// CS 1400 Section 003
// Project: Project 07
// Date: 03/11/2016 09:15:19 am
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------
namespace Proj07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare a constant
            const int 
                CAGES = 500;
            
            //Declare some variables
            int 
                month = 1,
                adults = 1,
                babies = 0,
                total = 1,
                prevTotal = 0,
                prevAdults = 1;

            //Display the student information
            WriteLine("Matthew Vaughan");
            WriteLine("Project 07 Section 003");
            WriteLine("");

            //Inform user what our table represents
            WriteLine("Table of rabbit population in pairs");

            //Display a space
            WriteLine("");
            
            //Display the labels of the columns
            WriteLine("Month   Adults  Babies  Total");

            //Create do while loop to create the rows
            do
            {
                //Display each variables value 
                WriteLine($"{month}\t{adults}\t{babies}\t{total}");

                //prevTotal Gets the previous total
                prevTotal = total;

                //prevAdults gets the previous number of adults
                prevAdults = adults;

                //Increment the month by 1
                month += 1;

                //The new adults get the previous total
                adults = prevTotal;

                //The new babies get the value from the previous adults
                babies = prevAdults;

                //Add the babies and adults to find the total of rabbits
                total = babies + adults;

            } while (total <= CAGES);

            //Display Space
            WriteLine("");

            //Display the month that they will run out of cages in
            WriteLine($"On Month #{month} we will not have enough cages");

            //Hault the program
            ReadLine();

        }
    }
}
