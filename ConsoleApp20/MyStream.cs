namespace ConsoleApp20
{
    class MyStream
    {
        public void Process()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            StreamWriter writer = new StreamWriter(@"D:\G19.txt");
            writer.WriteLine("Nika");
            writer.WriteLine("Elene");
            writer.WriteLine("Gio");
            writer.WriteLine("Gela");
            writer.WriteLine("Dgnachvi");
            writer.Close();

            StreamReader reader = new StreamReader(@"D:\G19.txt");
            StreamWriter writer2 = new StreamWriter(@"D:\G19_2.txt");

            int i = 1;
            string? line = reader.ReadLine();

            while (line != null)
            {
                line = $"{i++}.{line}";
                writer2.WriteLine(line);
                Console.WriteLine(line);
                line = reader.ReadLine();
            }
            
            reader.Close();
            writer2.Close();
            Console.ResetColor();
        }
    }
}


