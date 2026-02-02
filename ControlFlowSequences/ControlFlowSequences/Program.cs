/*
TODO
[x] User can quit at any time, skips remaining prompts
[x] get valid number - always runs once
[x] get valid number - runs if user didnt quit
[x] get a chilce - runs if user didnt quit
[x] repeat the whole thing if the user didnt quit
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

            do
            {
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
                } while (validResponse == false && userQuit == false);

                Console.WriteLine("end of first loop");

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

                Console.WriteLine("end of second loop");

                validResponse = false;
                //Operation Choice
                while (validResponse == false && userQuit == false)
                {
                    validResponse = true; //reset flag
                    Console.WriteLine("Please select a choice: \n 1. Option 1 \n 2. Option 2 \n 3. Option 3 \n 4. Option 4");
                    userinput = Console.ReadLine();

                    switch (userinput)
                    {
                        case "1":
                            Console.WriteLine($"{userinput} + {userinput} = {userinput + userinput}");
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

                Console.WriteLine("end of third loop");


            } while (userQuit == false);
            {
                Console.WriteLine("Have a great day!");
            }
                
                //pause
                Console.Read();
        }
    }
}
