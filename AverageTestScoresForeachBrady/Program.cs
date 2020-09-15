using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/***************************************************************
* Name        : Average Test Scores While
* Author      : Kabrina Brady
* Created     : 10/8/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work
* Description : Program asks user for 4 test scores and then outputs the average
*               Input:  Test scores, keyboard taps
*               Output: Average score
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or unmodified. I have not given other fellow student(s) access to my program.         
***************************************************************/

namespace averageTestScoresForBrady
{
    class Program
    {
        static void Main(string[] args)
        {
            int SIZE = 4;
            double[] NUM_SCORES = new double[SIZE]; //number of scores user will enter
            double average = 0; //initializes average to 0
            double score = 0; //initializes score to 0
            double sum = 0; //initializes sum to 0

            //FOREACH LOOP
            foreach (double value in NUM_SCORES)
            {
                sum += score; //adds each score to the running total
            }

            //FOR LOOP
            for (int i = 0; i < SIZE; i++) //i is set to 0, and as long as i is less than NUM_SCORES, it increments by one
            {
                try
                {
                    Console.WriteLine("Enter a score:"); //asks user to enter a score
                    score = double.Parse(Console.ReadLine()); //converts string to double
                        if (score >= 0 && score <= 100) //ensures score is between 0 and 100
                        {
                            Console.WriteLine("You entered " + score.ToString()); //prints
                            sum += score;
                        }
                        else
                        {
                            Console.WriteLine("Error: Enter a number between 0 and 100.");
                            i--; //lets user try again
                        }
                }
                catch
                {
                    Console.WriteLine("Please enter a valid number. Try again.");
                    i--; //lets user try again - if this is not here, the program counts this as one of the number of times it asks for user input (so gives one less chance to give input than it should)
                }
            }
            average = sum / NUM_SCORES.Length; //calculates average

            Console.WriteLine("The average score is " + Math.Round(average, 2)); //displays average score
            Console.WriteLine("Press enter to exit."); //tells user to press enter to exit (makes program wait to terminate until prompted)
            Console.ReadLine(); //reads user input (input is when Enter key is hit)
        }
    }
}