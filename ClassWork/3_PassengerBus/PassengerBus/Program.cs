namespace busbook
{
    class PassengerBus
    {
        static int totalSeats = 20;
        static int ai = 0, aj = 0;
        public static void Main(string[] args)
        {
            int row = 5, col = 4 ;
            int[,] bus = new int[row,col];

            
            int choice = 1, busSeats=0;
            while (choice != 0)
            {
                Console.WriteLine("Enter any number for booking seats and 0 for exiting");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 0)
                {
                    Console.WriteLine("Exiting");
                    break;
                }

                Console.WriteLine("Enter the number of seats you want to book");
                busSeats= Convert.ToInt32(Console.ReadLine());
                //case for not enough seats handle
                if (totalSeats == 0)
                {
                    Console.WriteLine("There are no more seats available");
                    break;
                }
                else
                {
                    bookSeat(busSeats, bus);
                }
                choice = 1;
            }

        }

        public static void bookSeat(int seats, int [,] arr)
        {
            if (seats > totalSeats)
            {
                Console.WriteLine(seats + " seats are not available, only " + totalSeats + " are available");
            }
            else
            {
                while (seats > 0 && totalSeats > 0 && (seats <= totalSeats))
                {
                    if (aj >= 4 && aj % 4 == 0)
                    {
                        ai += 1;
                        aj = 0;
                    }
                    arr[ai, aj] = 1;
                    seats -= 1;
                    totalSeats -= 1;
                    aj++;
                }
                display(arr);
            }
        }

        public static void display(int[,] arr)
        {
            for(int i=0; i<5;i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    Console.Write(arr[i, j]+" ");
                }
                Console.WriteLine();
            }
        }
    }//class ends here
}//namespace neds here
