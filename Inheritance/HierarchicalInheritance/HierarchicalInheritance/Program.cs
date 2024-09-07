class A
{
    public void funA()
    {
        Console.WriteLine("funA method of class A");
    }
}
class B: A
{
    public void funB()
    {
        Console.WriteLine("funB method of class B");
        base.funA();
    }
}
class C: A
{
    public void funC()
    {
        Console.WriteLine("funC method of class C");
        base.funA();
    }
}
class Program
{
    public static void Main(string[] args)
    {
        B objB = new B();
        objB.funB();

        C objC = new C();
        objC.funC();
    }
}