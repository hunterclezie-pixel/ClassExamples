namespace RandomNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random(); //Constructor
            int n = rand.Next(1, 7); // Random number between 1 and 6
            Console.WriteLine(n); 

            //pause
            Console.Read();
        }
    }
}
