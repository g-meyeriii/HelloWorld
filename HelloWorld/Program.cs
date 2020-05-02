using System;

namespace HelloWorld


{
    class Program
    {

        static void Main(string[] args)
        {
            string input = "0";
            int count = 0;
            int sum = 0;
            int currentNumber = 0;

            while (input != "-1")
            {
                Console.WriteLine("The current number is {0}", currentNumber);
                Console.WriteLine("Please enter a grade");
                Console.WriteLine("Current amount of entries {0}", count);
                Console.WriteLine("-1 and enter to get the average");

                input = Console.ReadLine();
                if (input == "-1")
                {
                    Console.WriteLine("-----------------------------------------------");
                    double average = (double)sum / (double)count;
                    Console.WriteLine("The average for this student is {0}", average);
                }
                if (int.TryParse(input, out currentNumber) && currentNumber > 0 && currentNumber < 21)
                {
                    sum = sum + currentNumber;
                }
                else
                {
                    if (!(input.Equals("-1")))
                    {
                        Console.WriteLine("Please enter a value between 0-20");
                    }
                    continue;
                }
                count++;

            }
            Console.Read();
        }

        //for (int counter = 0; counter < 10; counter++)
        //{
        //    if (counter % 2 ==0)
        //    {
        //        Console.WriteLine("Even");
        //        continue;

        //    }
        //    Console.WriteLine(counter);
        //}
        //Console.Read();
     
    }
}
