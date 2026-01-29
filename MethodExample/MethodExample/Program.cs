namespace MethodExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 5;
            //SayHello();
            //AddNumbers();
            //AddNumbers();
            //SayHello();
            Console.WriteLine(count);
            count = SumNumber(5, 7);
            Console.WriteLine(count);
            //pause
            Console.Read();
        }

        static void SayHello()

        {
            Console.WriteLine("Hello, World!");
        }

        static void AddNumbers()

        {
            Console.WriteLine(1 + 1);
        }

        static void ShowCount()
        {
            int count = 7;
            Console.WriteLine(count);
        }

        static int SumNumber(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
