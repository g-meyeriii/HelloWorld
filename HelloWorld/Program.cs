using System;

namespace HelloWorld

  
{
    class Program
    {
         //condition ? first_expression : second_expression;
         //condition has to be either true or false
         //The conditional operator is right - associative;
         //The expressiong a ? b : (c ? d : e),
         //not as (a ? b :c)? d : e.
         //The conditional operator can't be overloaded.

        static void Main(string[] args)
        {
            int temperature = -5;
            string stateOfMatter;

            if (temperature < 32)
                stateOfMatter = "solid";
            else
                stateOfMatter = "liquid";
            Console.WriteLine("State of matter is {0}", stateOfMatter);
            temperature += 40;

            // ternary operator short version of above
            stateOfMatter = temperature < 32 ? "solid" : "liquid";
            Console.WriteLine("State of matter is {0}", stateOfMatter);

            temperature += 200;

            // gas state of water
            stateOfMatter = temperature > 212 ? "steam/gas" : temperature < 32 ? "solid" : "liquid";
            Console.WriteLine("State of matter is {0}", stateOfMatter);
            Console.Read();
            
        }
        
       
    }
}
