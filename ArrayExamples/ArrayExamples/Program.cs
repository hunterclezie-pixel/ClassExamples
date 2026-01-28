namespace ArrayExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int thing = 0;
            string[] fruits = new string[7];
            fruits[0] = "apple";
            fruits[1] = "banana";
            fruits[2] = "Kiwi";
            fruits[3] = "tomato";
            fruits[4] = "Pineapple";
            fruits[5] = "Dragon Fruit";
            fruits[6] = "Watermelon";
            //fruits[7] = "Tangerine"; //this will crash. index out of range

            Console.WriteLine(fruits[3]);


            for (int i = 0; i < 7; i++)
            { 
                Console.WriteLine(fruits[i]);
            }

            // Same with no index or need for known length
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine($"The length of the fruits is: {fruits.Length}");

            //Pause
            Console.Read();
        }
    }
}
