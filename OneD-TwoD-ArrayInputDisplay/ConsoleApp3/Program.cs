// See https://aka.ms/new-console-template for more information
Console.WriteLine("Single Dimensional Array");
int[] a = new int[5];
//a =[2,3,4,5,6];
Console.WriteLine("Enter 5 numbers:");
for(int i = 0; i < 5; i++)
{
    a[i]=Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("\nThe numbers are:");
for(int j=0;j<5;j++)
{
    Console.Write(a[j]+" ");
}

Console.WriteLine("\n");
Console.WriteLine("Double Dimensional Array");
int[,] b = new int[3, 3];
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("\nEnter elements for row: " + (i+1));
    for (int j = 0; j < 3; j++)
    {
        Console.Write("Enter "+(j+1)+" element: ");
        b[i,j]= Convert.ToInt32(Console.ReadLine());
    }
}
Console.WriteLine("\nThe numbers are:");
for(int i=0;i<3;i++)
{
    for(int j = 0; j < 3; j++)
    {
        Console.Write(b[i, j]+" ");
    }
    Console.WriteLine();
}