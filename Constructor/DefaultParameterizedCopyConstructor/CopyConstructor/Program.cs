// See https://aka.ms/new-console-template for more information
class Sum
{
    int a, b, c;
    public Sum()
    {
        Console.WriteLine("Default Constructor");
        a = 10;
        b = 20;
        c = 30;
    }
    public Sum(int x,int y,int z)
    {
        Console.WriteLine("Parameterized Constructor");
        a = x;
        b = y;
        c = z;
    }
    public Sum(Sum obj)
    {
        Console.WriteLine("Copy Constructor");
        a = obj.a;
        b = obj.b;
        c = obj.c;
    }
    public void show()
    {
        Console.WriteLine(a+" "+b+" "+c);
    }
}
class Program
{
    static void Main(string[] args)
    {
        //for calling default constructor
        Sum s = new Sum();
        //Sum s; // use of unassigned local variable 's'
        s.show();

        //for calling parameterized constructor
        Sum s1 = new Sum(100, 200, 300);
        s1.show();

        //for calling copy constructor
        Sum s2 = new Sum(s);
        s2.show();
        Sum s3 = new Sum(s1);
        s3.show();
    }
}
