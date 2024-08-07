// See https://aka.ms/new-console-template for more information
namespace PropertyDemo
{
    public class Student
    {
        private int _id;
        private string _name;
        private int _passMark = 35;

        public int ID
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception("Id value should be greater than zero");
                }
                this._id = value;
            }
            get
            {
                return this._id;
            }
        }

        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name should not be empty");
                }
                this._name = value;
            }
            get
            {
                return string.IsNullOrEmpty(this._name) ? "No Name" : this._name;
            }
        }

        public int PassMark
        {
            get
            {
                return this._passMark;
            }
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Student s = new Student();
            s.ID = 102;
            s.Name = "Manya";
            Console.WriteLine("Student ID= {0}", s.ID);
            Console.WriteLine("Student Name= {0}", s.Name);
            Console.WriteLine("Student PassMark= {0}", s.PassMark);

            Console.ReadKey();
        }
    }
}