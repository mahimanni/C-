// See https://aka.ms/new-console-template for more information
namespace ZoneChart
{
    class Zones
    {
        public static void Main(string[] args)
        {
            int[,] zoneMonth = new int[4, 12];
            int[] annualSales = new int[4];

            string[] months;
            //months = new string[12] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            months = new string[12] { "Jan", "Feb", "Mar", "April", "May", "June", "July", "Aug", "Sept", "Oct", "Nov", "Dec" };

            string[] zone = new string[4] { "East", "West", "North", "South" };

            input(zoneMonth, annualSales, months, zone);
            displayMatrix(zoneMonth, annualSales, months, zone);
            rankCalculate(annualSales,zone);

            //for checking purpose only
            //int[] ranks = { 1, 2, 2, 3 };
            //graph(zone, ranks);
        }

        //for taking the input monthly salaries of each month
        public static void input(int[,] zoneMonth, int[] annualSales, string[] months, string[] zone)
        {
            for (int i = 0; i < 4; i++)
            {
                int totalSales = 0;
                Console.WriteLine("\nEnter the monthly sales for " + zone[i]+" zone");
                for(int j = 0; j < 12; j++)
                {
                    Console.Write("Enter the sales for " + months[j] + " month: ");
                    zoneMonth[i, j] = Convert.ToInt32(Console.ReadLine());
                    totalSales += zoneMonth[i, j];
                }
                annualSales[i] = totalSales;
            }
        }

        //for showing the desired 2d-matrix data
        public static void displayMatrix(int[,] zoneMonth, int[] annualSales, string[] months, string[] zone)
        {
            Console.WriteLine("\n\t\t\t Monthly and Annual Sales of the Zones are:");
            Console.Write("\t");
            for(int i = 0; i < months.Length; i++)
            {
                Console.Write(months[i] + "\t");
            }
            Console.Write("Annual Sales");
            Console.WriteLine();

            for(int i = 0; i < 4; i++)
            {
                Console.Write(zone[i] + "\t");
                for(int j = 0; j < 12; j++)
                {
                    Console.Write(zoneMonth[i, j] + "\t");
                }
                Console.Write(annualSales[i] + "\t");
                Console.WriteLine();
            }
        }

        //for calculating the ranks and then drawing the graph
        public static void rankCalculate(int[] annualSales, string[] zone)
        {
            //string[] rankZoneName = new string[4];
            int[] ranks = new int[4];
            int t;
            string ts;
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4-1-i; j++)
                {
                    if (annualSales[j] < annualSales[j + 1])
                    {
                        t= annualSales[j];
                        annualSales[j] = annualSales[j + 1];
                        annualSales[j + 1] = t;

                        ts = zone[j];
                        zone[j] = zone[j + 1];
                        zone[j + 1] = ts;
                    }
                }
            }
            //now we have the annual sales arranged from largest to smallest and their corresponding zones arranged in the zone array

            //displaying the ranks
            Console.WriteLine("\nThe rank of zones calculated on the basis of annual sales are: ");
            int rank = 1;
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine(zone[i] + "\t"+rank+ "rank");
                ranks[i] = rank;
                if (i!=3 && annualSales[i] != annualSales[i+1])
                    rank += 1;
            }

            //calling the graph method
            graph(zone, ranks);
        }

        //for drawing the graph
        public static void graph(string[] zone, int[] ranks)
        {
            Console.WriteLine("\nGraph can be depicted as:\n");

            Console.WriteLine("Zones:\t|");
            for(int i = 0; i < 4; i++)
            {
                Console.Write(zone[i]);
                Console.Write("\t" + "|");
                for(int j = 1; j <= 4; j++)
                {
                    if (ranks[i] == j)
                    {
                        for(int k = 0; k < j; k++)
                        {
                            Console.Write("\t");
                        }
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("\t|"+"__________________________________");
            Console.Write("Ranks->\t0\t");
            Console.Write("1\t2\t3\t4");
        }
    }
}