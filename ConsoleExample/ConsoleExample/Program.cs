/* 
Hunter Clezie 
Spring 2026
RCET2265
Console Practice program
github url: https://github.com/hunterclezie-pixel/ClassExamples.git
*/
namespace ConsoleExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Console.Beep(1000,500);

            string userinput = "Hello";

            Console.WriteLine("Please Type Some Text");
            userinput = Console.ReadLine();

            Console.WriteLine($"You entered:\"{userinput}\""); //Scaping is using the backslashes, formatted 
            Console.WriteLine("You entered: " + "\"" + userinput + "\""); //Concatnated String

            Console.Read();
        }
    }
}
