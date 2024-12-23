using ConsoleApp2;

internal class Program
{
    private static void Main(string[] args, Level Level)
    {
        switch (Level)
        {
            case Level.Junior:
                Console.WriteLine("let me get you through...");
                break;
            case Level.Beginner:
                Console.WriteLine("keep plough ahead");
                break;
            case Level.Senior:
                Console.WriteLine("move to next Level");
                break;
            default:
                Console.WriteLine("welcome");
                break;
        }
    }
}