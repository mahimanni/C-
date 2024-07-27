// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography.X509Certificates;

namespace OneDimensionalArray
{
    class Controller
    {
        static int size;
        static int[] number = new int[100];
        static string[] name = new string[100];
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number of phone numbers to be entered:");
            size = Convert.ToInt32(Console.ReadLine());          
            int stop = 0;
     
            for(int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter phone number :");
                number[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter name for the phone number entered");
                name[i] = Console.ReadLine();
            }

            //RecordHandling obj = new RecordHandling();
            while (stop != 1)
            {
                Console.WriteLine("\nMENU FOR CONTACT NUMBERS:\nPress 1 to add contact number along with their respective name");
                Console.WriteLine("Press 2 for removing contact number\nPress 3 for updating contact number\nPress 4 for searching contact number");
                Console.WriteLine("Press 5 for displaying records\nPress 6 for Quiting");

                Console.WriteLine("Enter your choice:");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nAdding your phone number...");
                        insert(number, name);
                        break;
                    case 2:
                        Console.WriteLine("\nRemoving your phone number...");
                        remove(number, name);
                        break;
                    case 3:
                        Console.WriteLine("\nUpdating your phone number...");
                        update(number, name);
                        break;
                    case 4:
                        Console.WriteLine("\nSearching your phone number...");
                        search(number, name);
                        break;
                    case 5:
                        Console.WriteLine("\nDisplaying the records...");
                        display(number, name);
                        break;
                    case 6:
                        stop = 1;
                        Console.WriteLine("\nQuiting...");
                        break;
                    default:
                        Console.WriteLine("\nInvalid option selected...");
                        break;
                }//switch ends here
            }//while ends here


        }//main method ends here

        public static void insert(int[] no, string[] name)
        {
            Console.WriteLine("Enter the location of insertion:");
            int loc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter phone number:");
            int newNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name of the contact:");
            string newName = Console.ReadLine();

            int last = size;
            size += 1;
            for (int i = last - 1; i >= 0; i--)
            {
                if(loc - 1 == 0 && i == 0)
                {
                    no[i + 1] = no[i];
                    name[i + 1] = name[i];
                    no[i] = newNumber;
                    name[i] = newName;
                    break;
                }
                else if (i >= loc - 1)
                {
                    no[i + 1] = no[i];
                    name[i + 1] = name[i];
                }
                else if (i + 1 == loc - 1)
                {
                    no[i+1] = newNumber;
                    name[i+1] = newName;
                    break;
                }
            }
        }

        public static void remove(int[] no, string[] name)
        {
            Console.WriteLine("Enter phone number whose record you want to delete");
            int delNumber= Convert.ToInt32(Console.ReadLine());
            for(int i= 0; i<size; i++)
            {
                int flag = 0;
                if (no[i]==delNumber && i == size - 1)
                {
                    no[i] = 0;
                    name[i] = "";
                }
                else if (no[i] == delNumber || flag==1)
                {
                    no[i] = no[i + 1];
                    name[i] = name[i + 1];
                    flag = 1;
                }               
            }
            size -= 1;
        }

        public static void update(int[] no, string[] name)
        {
            Console.WriteLine("Enter phone number whose record you want to update:");
            int updationNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter new phone number:");
            int updatedNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter new name for the phone number:");
            string updatedName = Console.ReadLine();

            for(int i = 0; i < size; i++)
            {
                if (no[i] == updationNo)
                {
                    no[i] = updatedNumber;
                    name[i] = updatedName;
                }
            }
        }

        public static void search(int[] no, string[] name)
        {
            Console.WriteLine("Enter phone number whose record you want to search or 0 if you want to search by name");
            int searchNo = Convert.ToInt32(Console.ReadLine());
            int pos=0;
            if (searchNo == 0)
            {
                Console.WriteLine("Enter name of the phone number to be searched:");
                string searchName = Console.ReadLine();
                for(int i = 0; i < size; i++)
                {
                    if (searchName == name[i])
                    {
                        pos = i + 1;
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < size; i++)
                {
                    if (searchNo == no[i])
                    {
                        pos = i + 1;
                        break;
                    }
                }
            }
            if (pos != 0)
                Console.WriteLine("The given record is found at position: " + pos);
            else
                Console.WriteLine("No such record found");
        }

        public static void display(int[] no, string[] name)
        {
            Console.WriteLine("Phone numbers along with their name are:");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Record-" + (i + 1) + ": " + name[i] + " " + no[i]);
            }
        }
    }//class ends here

    /*
    class RecordHandling
    {
    }
    */
}//namespace ends here