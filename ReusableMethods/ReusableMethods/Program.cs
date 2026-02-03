namespace ReusableMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //TestRandomNumber();
            for (int i = 0; i < 10; i++)
            {
                RunningTotal(5, false);

            }

            Console.WriteLine(RunningTotal());
            RunningTotal(0, true);
            Console.WriteLine(RunningTotal());

            //pause
            Console.Read();
        }

        // [x] keep track of a running total
        // [x] optionally add the integer passed in as an argument to the total
        // [x] return the running total
        // [x] optionally clear the running total
        static private int _runningTotal = 0;

        static int RunningTotal(int currentValue = 0, bool clear = false)
        {
            _runningTotal += currentValue;
            if (clear)
            { 
                _runningTotal = 0;
            }
            return _runningTotal;
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
