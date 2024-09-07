class A
{
    public void helloA()
    {
        Console.WriteLine("helloA method of class A");
    }
}
class B : A
{
    public void helloB()
    {
        Console.WriteLine("helloB method of class B");
        base.helloA();
    }
}
class C: B
{
    public void helloC()
    {
        Console.WriteLine("helloC method of class C");
        base.helloB();
        base.helloA();
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\nMulti Level Inheritance");
        C obj = new C();
        obj.helloC();
    }
}