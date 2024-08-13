// See https://aka.ms/new-console-template for more information
class xyz
{
    public int a, b;
    static xyz()//static constructor
    {
        Console.WriteLine("Static Constructor");
    }
    public xyz()//default constructor
    {
        Console.WriteLine("Default Constructor");
        a = 10;
        b = 20;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("First time instance created");
        xyz obj = new xyz();//1st time instance is created so static as well as default will be called
        Console.WriteLine(obj.a + " " + obj.b);

        Console.WriteLine("\nSecond instance created");
        xyz obj2 = new xyz();//only default constructor will be called
        Console.WriteLine(obj2.a + " " + obj2.b);
    }
}
