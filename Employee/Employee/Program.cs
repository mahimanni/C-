class Employee
{
    int sal,inc,t,d,h,p,pack;
    public void calcSalary(int package,int ta,int da, int hra,int pf)
    {
        sal = (package/12) + ta + da + hra - pf;
        pack = package;
        t = ta;
        d = da;
        h = hra;
        p = pf;
    }
    public void addIncentive(int incentive)
    {
        inc = incentive;
        sal += incentive;
    }
    public void display()
    {
        Console.WriteLine("\nSalary Slip:");
        Console.WriteLine("Basic= " + pack/12);
        Console.WriteLine("ta= " + t);
        Console.WriteLine("da= " + d);
        Console.WriteLine("hra= " + h);
        Console.WriteLine("pf= " + p);
        Console.WriteLine("incentive= " + inc);
        Console.WriteLine("\nSalary= " + sal);
    }
}
class Developer: Employee
{
    public void calcSalaryDeveloper(int package, int ta, int da, int hra, int pf)
    {
        base.calcSalary(package, ta, da, hra, pf);
    }
    public void addIncentiveDeveloper(int incentive)
    {
        base.addIncentive(incentive);
    }
    public void displayDeveloper()
    {
        base.display();
    }
}
class Backoffice: Employee
{
    public void calcSalaryBackoffice(int package, int ta, int da, int hra, int pf)
    {
        base.calcSalary(package, ta, da, hra, pf);
    }
    public void displayBackoffice()
    {
        base.display();
    }
}

class Tester: Employee
{
    public void calcSalaryTester(int package, int ta, int da, int hra, int pf)
    {
        base.calcSalary(package, ta, da, hra, pf);
    }
    public void addIncentiveTester(int incentive)
    {
        base.addIncentive(incentive);
    }
    public void displayTester()
    {
        base.display();
    }
}

class Mkt: Employee
{
    public void calcSalaryMkt(int package, int ta, int da, int hra, int pf)
    {
        base.calcSalary(package, ta, da, hra, pf);
    }
    public void addIncentiveMkt(int incentive)
    {
        base.addIncentive(incentive);
    }
    public void displayMkt()
    {
        base.display();
    }
}

class Program
{
    static string name, empCode;
    static int package, choice, attendance;
    static int ta, da, hra, pf;
    public static void basicInfo()
    {
        Console.WriteLine("Enter the name of the employee");
        name = Console.ReadLine();
        Console.WriteLine("Enter the package of the employee");
        package= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the post of the employee by pressing:");
        Console.WriteLine("1.Developer\n2.Backoffice\n3.Tester\n4.Mkt");
        choice= Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the employee code");
        empCode= Console.ReadLine();
        Console.WriteLine("Enter the attendance of employee in %");
        attendance= Convert.ToInt32(Console.ReadLine());
    }
    public static bool checkAttendance()
    {
        if (attendance > 70)
        {
            return true;
        }
        return false;
    }
    public static void salInfo()
    {
        Console.WriteLine("Enter ta,da,hra,pf");
        ta = Convert.ToInt32(Console.ReadLine());
        da = Convert.ToInt32(Console.ReadLine());
        hra = Convert.ToInt32(Console.ReadLine());
        pf = Convert.ToInt32(Console.ReadLine());
    }
    public static void Main(string[] args)
    {
        basicInfo();
        switch (choice)
        {
            case 1:
                Console.WriteLine($"Welcome Developer {name}");
                Developer d=new Developer();
                if (checkAttendance())
                {
                    salInfo();
                    d.calcSalaryDeveloper(package, ta, da, hra, pf);
                    d.addIncentiveDeveloper((package/24));
                    d.displayDeveloper();
                }
                else 
                {
                    Console.WriteLine("Attendance not sufficient");
                }
                break;

            case 2:
                Console.WriteLine($"Welcome Backoffice {name}");
                Backoffice b=new Backoffice();
                if(checkAttendance())
                {
                    salInfo();
                    b.calcSalaryBackoffice(package, ta, da, hra, pf);
                    b.displayBackoffice();
                }
                else
                {
                    Console.WriteLine("Attendance not sufficient");
                }
                break;

            case 3:
                Console.WriteLine($"Welcome Tester {name}");
                Tester t= new Tester();
                if(checkAttendance())
                {
                    salInfo();
                    int noOfProj = Convert.ToInt32(Console.ReadLine());
                    int noOfReports = Convert.ToInt32(Console.ReadLine());
                    t.calcSalaryTester(package, ta, da, hra, pf);
                    t.addIncentiveTester((noOfProj*200+noOfReports*100));
                    t.displayTester();
                }
                else
                {
                    Console.WriteLine("Attendance not sufficient");
                }
                break;

            case 4:
                Console.WriteLine($"Welcome Mkt {name}");
                Mkt m= new Mkt();
                if(checkAttendance())
                {
                    salInfo();
                    m.calcSalaryMkt(package, ta, da, hra, pf);
                    m.addIncentiveMkt((package / 30));
                    m.displayMkt();
                }
                else
                {
                    Console.WriteLine("Attendance not sufficient");
                }
                break;

            default:
                Console.WriteLine("Wrong choice entered");
                break;
        }

    }
}