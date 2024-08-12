// See https://aka.ms/new-console-template for more information
using System;
public class Account
{
    public int id;
    public String name;
    public static float rateOfInterest;

    //parameterized constructor
    public Account(int id, string name)    {
        this.id = id;
        this.name = name;
    } 

    //static constructor
    static Account()
    {
        rateOfInterest = 9.5f;
    }
    public void display()
    {
        Console.WriteLine(id+" "+name+" "+rateOfInterest);
    }
}
class Employee
{
    public static void Main(string[] args)
    {
        Account a1 = new Account(101, "Mahi");
        Account a2 = new Account(102, "Manya");
        a1.display();
        a2.display();
    }
}
