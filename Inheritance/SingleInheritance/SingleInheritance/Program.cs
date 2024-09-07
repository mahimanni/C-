class A
{
    int a, b, c;
    public void input(){
        a = 10;
        b = 20;
        c = 30;
        Console.WriteLine("Input method of the A class");
    }
    public void output()
    {
        Console.WriteLine("Output method of the A class");
        Console.WriteLine($"a={a}, b={b}, c={c}");
    }
}
class B : A
{
    string x="hello", y="world";
    public void get()
    {
        base.input();
    }
    public void put()
    {
        base.output();
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Single Inheritance\n");
        B obj = new B();
        obj.get();
        obj.put();
    }
}
