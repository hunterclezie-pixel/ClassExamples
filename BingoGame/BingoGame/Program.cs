/*
* TODO:
* [x] Track bingo balls drawn in a two dimensional array
* [x] Display status of all balls on the console
* [x] Clear all drawn balls to start a new game
* [x] Let the user quit at any time
* [x] Draw a random ball
* [x] get a random number to determine ball letter
* [x] get a random number to determine ball number
* [x] check if ball has already been drawn. no: mark as drawn, yes: draw another
* [x] Usability
* [x] fix intro, wait to draw first ball
*/
using System.Net.NetworkInformation;

namespace BingoGame
{
    internal class Program
    {
        //make this global so it can be accessed by all methods
        static bool[,] drawnBalls = new bool[5, 15];
        static void Main(string[] args)
        {
            string userInput = "";
            int ballCount = 0;

            do 
            {
            Console.Clear();
                if (ballCount < 75)
                {
                    Console.WriteLine("Welcome to Bingo! please hit \"Enter\" to play");
                    Console.WriteLine("Press \"Q\" to quit anytime");
                    Console.WriteLine("Press \"C\" to clear for a new game any time");
                    DrawBall();
                    ballCount++;
                }

                else 
                { 
                    Console.WriteLine("All balls have been drawn!");
                    Console.WriteLine("Press \"Q\" to quit");
                    Console.WriteLine("Press \"C\" to clear for a new game!");
                }

                Console.WriteLine($"Ball count: {ballCount}");
                Display();
                userInput = Console.ReadLine(); //fix double draw
                if (userInput == "C" || userInput == "c")
                {
                    ClearDrawnBalls();
                    ballCount = 0;
                }

                } while (userInput != "Q" && userInput != "q");

            Console.Clear();
            Console.WriteLine("Thank you for playing Bingo, have a nice day!");

            //pause
            Console.Read();
        }

        static void Display()
        {
            int padding = 3;
            int prettyNumber = 0;
            string placeHolder = "";
            string columnSeperator = " |";
            string currentRow = "";
            //print heading row
            string[] heading = { "B", "I", "N", "G", "O" };
            foreach (string thing in heading)
            { 
                Console.Write(thing.PadLeft(padding) + columnSeperator);
            }
            Console.WriteLine();

            //print the rest of the rows
            for (int number = 1; number <= 15; number++)
            {

                //assemble the row
                for (int letter = 0; letter < 5; letter++)
                {
                    if (drawnBalls[letter, number - 1])
                    {
                        prettyNumber = number + (letter * 15);
                        currentRow += prettyNumber.ToString().PadLeft(padding) + columnSeperator;
                    }
                    else
                    { 
                        currentRow += placeHolder.PadLeft(padding) + columnSeperator;

                    }
                }
                Console.WriteLine(currentRow);
                currentRow = ""; //Resets the row for the next iteration    
            }
        
        }

        static void DrawBall()
        {
            int letter = 0, number = 0;

            do
            {
                letter = RandomNumberZeroTo(4);
                number = RandomNumberZeroTo(14);
            } while (drawnBalls[letter, number]);

            drawnBalls[letter, number] = true;
        }
        /// <summary>
        /// Get a random integer from 0 to max inclusive
        /// </summary>
        /// <param name="max"></param>
        /// <returns></returns>
        
        static void ClearDrawnBalls()
        {
            bool[,] emptyArray = new bool[5, 15];
            drawnBalls = emptyArray;
            drawnBalls = new bool[5, 15];

            //for (int letter = 0; letter < 5; letter++)
            //{
            //    for (int number = 0; number < 15; number++)
            //    {
            //        drawnBalls[letter, number] = false;
            //    }
            //}
        }   

        static private int RandomNumberZeroTo(int max)
        {
            int range = max + 1; //make max inclusive
            Random rand = new Random();
            return rand.Next(range);
        }
    }
}
