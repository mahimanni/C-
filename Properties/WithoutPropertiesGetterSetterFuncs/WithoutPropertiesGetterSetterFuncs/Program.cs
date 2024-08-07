// See https://aka.ms/new-console-template for more information
namespace PropertyDemo
{
    public class Student
    {
        private int _iD;
        private string _name;
        private int _passMark = 35;

        public void setID(int ID)//setting _iD by setter func
        {
            if (ID < 0)
            {
                throw new Exception("ID value should be greater than 0");
            }
            this._iD = ID;
        }
        public int getID()//getting _iD by getter func
        {
            return this._iD;
        }

        public void setName(string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new Exception("Name should not be empty");
            }
            this._name = Name;
        }
        public string getName()
        {
            if (string.IsNullOrEmpty(_name))
            {
                return "No Name";
            }
            return this._name;
        }

        public int getPassMark()
        {
            return this._passMark;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Student s = new Student();

            s.setID(111);
            s.setName("Mahi");
            Console.WriteLine("Student ID= {0}", s.getID());
            Console.WriteLine("Student Name= {0}", s.getName());
            Console.WriteLine("Student PassMark= {0}", s.getPassMark());
        }
    }
}
