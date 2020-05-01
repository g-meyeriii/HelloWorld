using System;

namespace HelloWorld

  
{
    class Program
    {
        
        static void Main(string[] args)
        {

            bool isAdmin = false;
            bool isResgiterd = true;
            string userName = "";

            Console.WriteLine("Input username");
            userName = Console.ReadLine();

            if (isResgiterd && userName !="" && userName.Equals("admin"))
            {
                    Console.WriteLine("Hello registerded user!");
               
                    Console.WriteLine("Hello there," + userName + ", a registerded user!");
                    
                    Console.WriteLine("Hello Admin");
                
            }
            if(isAdmin || isResgiterd)
            {
                Console.WriteLine("You are logged in");
            }
            Console.Read();

            //Console.WriteLine("What's the temperature in *F");
            //string temperature = Console.ReadLine();
            //int numTemp;
            //int number;
            //bool userEnteredANumber = int.TryParse(temperature, out number);

            //if (userEnteredANumber)
            //{
            //    numTemp = number;
            //}
            //else
            //{
            //    numTemp = 0;
            //    Console.WriteLine("Must be a number entered temp set @ 0");
            //}


            //if(numTemp < 50)
            //{
            //    Console.WriteLine("Take your coat");
            //}
            //else if(numTemp >=50 && numTemp <=69)
            //{
            //    Console.WriteLine("It is a pants day");
            //}
            //else
            //{
            //    Console.WriteLine("Shorst weather!");
            //}
            //Console.Read();
        }
       
         
    }
}
