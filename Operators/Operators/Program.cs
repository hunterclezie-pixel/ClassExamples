namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(5 + 5);
            Console.WriteLine(5 - 3);
            Console.WriteLine(5 * 2);
            Console.WriteLine(13 / 5); //integer
            Console.WriteLine(13 % 5); //remainder
            Console.WriteLine(13d / 5d); //floating point decimal
            Console.WriteLine(13.0 / 5.0); //floating point decimal

            Console.WriteLine(5 > 4);
            Console.WriteLine(3 < 5);
            Console.WriteLine(5 == 2); //Tests if equal
            Console.WriteLine(13 != 5); //Tests if NOT equal
            Console.WriteLine(5 >= 3);
            Console.WriteLine(2 <= 4);

            //Compound operators
            int a = 5; //assign 5 to variable a
            a = a + 9;
            //a += 9; compound assignment of a + 9
            Console.WriteLine(a);

            Console.WriteLine(++a); //incriment then print
            Console.WriteLine(a);
            Console.WriteLine(a++); //print then increment
            Console.WriteLine(a);

            int firstnumber = 5;
            int secondnumber = 10;
            Console.WriteLine($"{firstnumber} + {secondnumber} = {firstnumber + secondnumber}");
            Console.WriteLine($"{firstnumber} - {secondnumber} = {firstnumber - secondnumber}");
            Console.WriteLine($"{firstnumber} * {secondnumber} = {firstnumber * secondnumber}");
            Console.WriteLine($"{firstnumber} / {secondnumber} = {firstnumber / secondnumber}");
            Console.WriteLine($"{firstnumber} % {secondnumber} = {firstnumber % secondnumber}");
            /*Console.WriteLine(5 - 3);
            Console.WriteLine(5 * 2);
            Console.WriteLine(13 / 5); //integer
            Console.WriteLine(13 % 5); //remainder*/

            //pause
            Console.Read();
        }
    }
}
