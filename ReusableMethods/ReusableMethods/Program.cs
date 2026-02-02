namespace ReusableMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            TestRandomNumber();

            //pause
            Console.Read();
        }

        static void TestRandomNumber()
        {
            int[] counts = new int[12];
            int max = 11, min = 0, currentNumber = 0, padding = 5;

            for (int i = 0; i < 1000; i++)
            {
                //Console.WriteLine(RandomNumberBetween(10, 5).ToString().PadLeft(2));
                currentNumber = RandomNumberBetween(max, min);
                counts[currentNumber] += 1;

            }

            //make column headers
            for (int i = 0; i < counts.Length; i++)
            {
                Console.Write(i.ToString().PadLeft(padding) + "|");
            }
            Console.WriteLine();
            //display counts in nice columns
            foreach (int count in counts)
            {
                Console.Write(count.ToString().PadLeft(5) + "|");
            }
        
        }

        static int RandomNumberBetween(int max, int min)
        {

            Random rand = new Random();
            int range = max - min + 1; //This sets the range of randomly pulled numbers possible
            int randomNumber = rand.Next(range);
            randomNumber += min; //Shift value back up so it falls between min and max

            return randomNumber;
        
        }

    }
}
