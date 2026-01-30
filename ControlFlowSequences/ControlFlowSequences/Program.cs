/*
TODO
[ ] User can quit at any time, skips remaining prompts
[ ] get valid number - always runs once
[ ] get valid number - runs if user didnt quit
[ ] get a chilce - runs if user didnt quit
[ ] repeat the whole thing if the user didnt quit
*/
namespace ControlFlowSequences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber, thirdNumber;
            bool userQuit = false, validResponse = false;
            string userinput = "";

            //First Number
            do
            {
                Console.WriteLine("Please enter a number");
                userinput = Console.ReadLine();
                try
                {
                    Console.WriteLine($"you entered {int.Parse(userinput)}");
                    validResponse = true;
                }
                catch (Exception)
                {
                    if (userinput == "Q" || userinput == "q")
                    {
                        userQuit = true;
                    }

                    else
                    {
                        Console.WriteLine($"{userinput} is not a number");
                    }
                    
                }
            } while (validResponse == false || userQuit == false);
            
            validResponse = false; //reset flag
            //Second number
            while (validResponse == false && userQuit == false)
            {
                Console.WriteLine("Please enter a number");
                userinput = Console.ReadLine();
                try
                {
                    Console.WriteLine($"you entered {int.Parse(userinput)}");
                    validResponse = true;
                }
                catch (Exception)
                {
                    if (userinput == "Q" || userinput == "q")
                    {
                        userQuit = true;
                    }

                    else
                    {
                        Console.WriteLine($"{userinput} is not a number");
                    }

                }
            }

            //Operation Choice
            while (validResponse == false && userQuit == false)
            {
                validResponse = true; //reset flag
                Console.WriteLine("Please select a choice: \n 1. Option 1 \n 2. Option 2 \n 3. Option 3 \n 4. Option 4");
                userinput = Console.ReadLine();

                switch (userinput)
                {
                    case "1":
                        Console.WriteLine("You have chosen wiseley");
                        break;

                    case "2":
                        Console.WriteLine("You have chosen wiseley");
                        break;

                    case "3":
                        Console.WriteLine("You have chosen wiseley");
                        break;

                    case "4":
                        Console.WriteLine("You have chosen wiseley");
                        break;

                    case "Q":
                        userQuit = true;
                        break;

                    case "q":
                        userQuit = true;
                        break;

                    default:
                        Console.WriteLine("You have chosen Poorly");
                        validResponse = false;
                        break;
                }
            }

            //pause
            Console.Read();
        }
    }
}
