using System.Security.Cryptography.X509Certificates;

interface A
{
    public void inputA();
   
}
interface B
{
    public void inputB();
    
}
class C: A,B
{
    public void inputA()
    {
        Console.WriteLine("Input method of the class A");
    }
    public void inputB()
    {
        Console.WriteLine("Input method of the class B");
    }
    public void inputC()
    {
        Console.WriteLine("Input method of the class C");
    }
}
class Program
{
    public static void Main(string[] args)
    {
        C obj = new C();
        obj.inputA();
        obj.inputB();
        obj.inputC();
    }
}