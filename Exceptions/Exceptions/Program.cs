namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userinput = "";
            int result = 0;

            Console.WriteLine("Please Enter a Number");
            userinput = Console.ReadLine();
            Console.WriteLine($"You enter {userinput}");

            try
            {
                // risky code
            result = int.Parse(userinput);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong: " + ex.StackTrace);
            }

            //pause
            Console.ReadLine();
        }
    }
}
