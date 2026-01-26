namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userinput = "";
            int result = 0;
            bool isValid = false;
            string message = "";

            do
            {
                Console.WriteLine("Please Enter a Number");
                Console.WriteLine("Enter \"Q\" to exit");
                userinput = Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"You enter {userinput}");

                try
                {
                    // risky code
                result = int.Parse(userinput);
                isValid = true;
                message = $"Good job! {result} is a number!";

                }
                catch (Exception ex)
                {
                    if (userinput == "Q"|| userinput == "q")
                    {
                        message = "Have a nice day!";
                        isValid = true;
                    }

                    else
                    {
                        Console.WriteLine($"{userinput} is not a number");
                    }
                }

            }
            while (isValid == false);

            message= $"Good job! {result} is a number!";

            //pause
            Console.ReadLine();
        }
    }
}
