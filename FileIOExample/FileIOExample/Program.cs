namespace FileIOExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            FileToArray("..\\..\\..\\email.txt"); //TODO: add display array meathod
            //Commented out the method calls to prevent overwriting the file each time the program is run. Uncomment the method calls to test the functionality.
            //ReadEntireFile("..\\..\\..\\email.txt");
            //ReadFile();
            //WriteToFile();
            //AppendToFile();

            //Pause
            Console.Read();
        }

        static void WriteToFile()
        {
            using (StreamWriter testFile = File.CreateText("..\\..\\..\\TestFile.txt"))
            // The using statement ensures that the StreamWriter is properly disposed of after use, which means the file will be closed automatically.
            // The File.CreateText method creates a new file or overwrites an existing file at the specified path and returns a StreamWriter that can be used to write to the file.
            {
                testFile.WriteLine("Wake up Neo...");
            }

        }

        static void AppendToFile()
        {
            using (StreamWriter testFile = File.AppendText("..\\..\\..\\TestFile.txt"))
            // The File.AppendText method opens an existing file for appending text. If the file does not exist, it creates a new file. It returns a StreamWriter that can be used to write to the end of the file.
            // The using statement ensures that the StreamWriter is properly disposed of after use, which means the file will be closed automatically.
            {
                testFile.WriteLine("Follow the white ribbit...");
            }
        }

        static void ReadFile()
        {
            using (StreamReader testFile = new StreamReader("..\\..\\..\\TestFile.txt"))

            {
                //Console.Write(testFile.Peek());
                Console.WriteLine(testFile.ReadLine());
                Console.WriteLine(testFile.ReadLine());
            }
        }

        static void ReadEntireFile(string filePath)
        {
            using (StreamReader testFile = new StreamReader(filePath))

            {
                do
                {
                    Console.WriteLine(testFile.ReadLine());

                } while (!testFile.EndOfStream);
            }
        }

        static int CountOfLinesIn(string filePath)
        {
            int count = 0;
            using (StreamReader testFile = new StreamReader(filePath))

            {
                do
                {
                    testFile.ReadLine();
                    count++;
                } while (!testFile.EndOfStream);
            }

            return count;
        }

        static string[,] FileToArray(string filePath)
        {
            string[,] customerData = new string[4, CountOfLinesIn(filePath)];
            string[] temp;
            int counter = 0;
            
            using (StreamReader testFile = new StreamReader(filePath))
            {
                do
                {
                    temp = testFile.ReadLine().Split(",");
                    if (temp.Length == 5)
                    {
                        temp[0] = temp[0].Replace("\"$$", "");
                        temp[3] = temp[3].Replace("\"", "");
                        customerData[0, counter] = temp[0];
                        customerData[1, counter] = temp[1];
                        customerData[2, counter] = temp[2];
                        customerData[3, counter] = temp[3];
                    }
                    counter++;
                } while (!testFile.EndOfStream);
            }

            return customerData;
        }
    }
}
