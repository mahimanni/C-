// See https://aka.ms/new-console-template for more information
public class Counter
{
    private Counter()
    {
        Console.WriteLine("Private constructor of the Counter class");
    }
    public static int currentCount;
    public static int incrementCount()
    {
        return ++currentCount; 
    }
}
class TestCounter
{
    static void Main()
    {
        //Counter obj = new Counter();
        Counter.currentCount = 11;
        Counter.incrementCount();
        Console.WriteLine("New count: {0}", Counter.currentCount);

        //To keep the console window open in debug mode
        Console.WriteLine("Press any key to exit..");
        Console.ReadKey();
    }
}
