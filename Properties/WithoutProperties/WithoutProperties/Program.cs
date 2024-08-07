// See https://aka.ms/new-console-template for more information
namespace PropertyDemo
{
    public class Student
    {
        public int ID;
        public string Name;
        public int PassMark;
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Student s = new Student();
            s.ID = 100;
            s.Name = null;
            s.PassMark = 0;

            Console.WriteLine("Id={0} Name={1} PassMark={2}",s.ID,s.Name,s.PassMark);
            Console.ReadKey();
        }
    }
}
