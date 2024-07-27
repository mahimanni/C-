namespace machinelearning
{
    class PremiumPrediction
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of input datasets");
            int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter age and premium respectively");
            int[] age = new int[n];
            int[] premium = new int[n];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter age and premium respectively for "+(i+1)+" record");
                age[i]= Convert.ToInt32(Console.ReadLine());
                premium[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\nThe records are:");
            display(age, premium);

            Console.WriteLine("\nEnter the age for which you want the premium to be calculated");
            int userAge = Convert.ToInt32(Console.ReadLine());
            calculatePremium(age, userAge, premium) ;
        }
        public static void display(int[] arr, int[] brr)
        {
            Console.WriteLine("Record: Age\tPremium");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine((i + 1) + "\t" + arr[i] + "\t" + brr[i]);
            }
        }
        public static void calculatePremium(int[] age,int userAge,int[]premium)
        {
            int lowerDiff=1000000007, upperDiff=1000000007, lowerAge=0, upperAge=0, lowerPremium=0, upperPremium=0;
            int a=0, b=0;
            int estimatedPrediction;

            for(int i = 0; i < age.Length; i++)
            {
                if (userAge - age[i] >= 0)
                {
                    a = lowerDiff;
                    lowerDiff = Math.Min(lowerDiff, userAge - age[i]);
                    
                    if(a!=lowerDiff)
                    {
                        lowerAge = age[i];
                        lowerPremium = premium[i];
                    }
                }
                if (age[i]- userAge >=0)
                {
                    b = upperDiff;
                    upperDiff = Math.Min(upperDiff, age[i]-userAge);

                    if (b != upperDiff)
                    {
                        upperAge = age[i];
                        upperPremium = premium[i];
                    }
                }
            }

            estimatedPrediction = (lowerPremium + upperPremium) / 2;
            //Console.WriteLine(lowerAge + "\t" + upperAge);
            //Console.WriteLine(lowerPremium + "\t" + upperPremium);
            Console.WriteLine("\nEstimated Premium: "+estimatedPrediction);
        }
    }
}
