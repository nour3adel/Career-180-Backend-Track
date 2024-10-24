namespace Day7
{
    public class Program
    {
        static void Main(string[] args)
        {
            _3DPoint p1 = new _3DPoint();
            _3DPoint p2 = new _3DPoint();

            Console.WriteLine("Enter the coordinates of the first 3D Point:");
            p1.X = GetCoordinate("X");
            p1.Y = GetCoordinate("Y");
            p1.Z = GetCoordinate("Z");


            Console.WriteLine("Enter the coordinates of the second 3D Point:");
            p2.X = GetCoordinate("X");
            p2.Y = GetCoordinate("Y");
            p2.Z = GetCoordinate("Z");

            Console.WriteLine($"First 3D Point: {p1}");
            Console.WriteLine($"Second 3D Point: {p2}");

            Console.WriteLine(p1 == p2 ? "The Two Points are equal." : "The Two Points are not equal.");

        }


        static int GetCoordinate(string name)
        {
            while (true)
            {
                Console.Write($"{name}: ");
                string input = Console.ReadLine();

                try
                {
                    return int.Parse(input);
                }
                catch (Exception ex)
                {
                    LogError("Invalid input. Please enter a number.", ex);
                }
            }
        }

        static void LogError(string message, Exception ex)
        {
            Console.WriteLine(message);

            StreamWriter stream = File.AppendText("logs.txt");
            stream.WriteLine($"{ex.Message} -{ex.Source}-{ex.TargetSite} -{DateTime.Now.ToString()}");
            stream.Close();
        }
    }
}
