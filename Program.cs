using System ;

namespace project 
{
    class Program 
    {
        static void Main (string[]args)
        {
        Console.WriteLine("calculate simple interest  ");
        Console.WriteLine("    ");
           
           Console.Write("what is the principal amount value you want to calculate simple interest in rupees : ");
           int pA = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("What is the percent of interest rate on your given amount : ");
            int R = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("if rate of interest is in months type : m");
            Console.WriteLine("if rate of interest is in year type : y");

            string a = Console.ReadLine();


            if (a==("m"))
            {

            Console.Write("what is the time period in MONTHS for your rate of intrest : ");
                int time = Convert.ToInt32(Console.ReadLine());

            int simpleInterest = (pA*R*time)/(100*12) ;

                    Console.WriteLine(" ");

                Console.WriteLine ($"For time period of {time} months at the rate of {R} the given amount of {pA} , the  SIMPLE INTEREST is : {simpleInterest}");
                    Console.WriteLine ( $"total amount after {time} month is : {simpleInterest+pA} ");
            }


            else if (a==("y"))
            {
               Console.Write("what is the time period in YEAR for your rate of intrest : ");
                int time = Convert.ToInt32(Console.ReadLine());

            int simpleInterest = (pA*R*time)/100 ;

                    Console.WriteLine(" ");

                Console.WriteLine ($"For time period of {time} year at the rate of {R} the given amount of {pA} , the  SIMPLE INTEREST is : {simpleInterest}");
               Console.WriteLine ( $"total amount after {time} year is : {simpleInterest+pA} ");
            }

            else 
            {
                Console.WriteLine(" invalid input");
            }

        }
    }
}
