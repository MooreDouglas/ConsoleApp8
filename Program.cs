namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string red;
                string line;
                StreamReader reader = new StreamReader("../../../TextFile2.txt");
                StreamWriter writer = new StreamWriter("../../../TextFile1.txt");
                line = reader.ReadLine();
                Console.WriteLine(line);
                red = Convert.ToString(Console.ReadLine());
                writer.WriteLine(red);

                writer.Close();
                reader.Close();
                reader = new StreamReader("../../../TextFile1.txt");
                writer = new StreamWriter("../../../TextFile2.txt");
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    writer.WriteLine(line);
                }
                writer.Close();
                reader.Close();
            }
        }
    }
}
