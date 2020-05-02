using System;

namespace HelloWorld

  
{
    class Program
    {

        static void Main(string[] args)
        {
            int idx = 0;
            string enteredText = "";
            while (enteredText.Equals(""))
            {
                
                Console.WriteLine("Please press enter to continue, any other characters and enter to finish");
                Console.WriteLine("Current people count is {0}", idx);
                enteredText=Console.ReadLine();
                idx++;
            }

            //do while loops
            //int counter = 0;
            //int lengthOfText = 0;
            //string wholeText = "";
            //do
            //{
            //    Console.WriteLine("Please enter the naem of a friend");
            //    string nameOfFriend = Console.ReadLine();
            //    int currentLength = nameOfFriend.Length;
            //    lengthOfText += currentLength;
            //    wholeText += nameOfFriend;
            //    Console.WriteLine(counter);

            //} while (lengthOfText < 20);
            //Console.WriteLine("Thanks, that was enough!" + wholeText);
            //for (int idx = 1; idx < 20; idx+=2)
            //{

            //    Console.WriteLine(idx);

            //}
            Console.WriteLine("Process complete");
            Console.Read();
        }
      
       
        
       
    }
}
