using System;

namespace HelloWorld

  
{
    class Program
    {
        
        static void Main(string[] args)
        {

            //Console.WriteLine(Calculate());
            //Console.Read();

            //Console.WriteLine("Please enter a number!");
            //string userInput = Console.ReadLine();
            //int num1 = 0;
            //int num2 = 5;
            //int result;
            //try
            //{
            //    result = num2 / num1;
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Can't divide by zero");
            //}


            //try
            //{
            //    int userInputAsInt = int.Parse(userInput);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Format exception, please enter a number.");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Too long or short Exception");
            //}
            //catch (ArgumentNullException)
            //{
            //    Console.WriteLine("Null must have a value");
            //}
            //finally
            //{
            //    Console.WriteLine("This is called anyways");
            //}
            int num1 = 5;
            int num2 = 3;
            int num3;

            //unary operatrors
            num3 = -num1;
            Console.WriteLine("num3 is {0}",num3);

            bool isSunny = true;
            Console.WriteLine("is it sunny? {0}", !isSunny);

            //increment operators
            int num = 0;
            num ++ ;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num++);
            //pre increment 
            Console.WriteLine("num is {0}", ++num);

            //decrement operator
         
            num--;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num--);
            //pre decrement 
            Console.WriteLine("num is {0}", --num);

            int result;
            
            result = num1 + num2;
            Console.WriteLine("Result of num1 + num2 is {0}", result);
            result = num1 - num2;
            Console.WriteLine("Result of num1 - num2 is {0}", result);
            result = num1 * num2;
            Console.WriteLine("Result of num1 * num2 is {0}", result);
            result = num1 / num2;
            Console.WriteLine("Result of num1 / num2 is {0}", result);
            //modulus
            result = num1 % num2;
            Console.WriteLine("Result of num1 % num2 is {0}", result);

            // relational and type operators
            bool isLower;
            isLower = num1 > num2;
            Console.WriteLine("Result of num1 > num2 is {0}", isLower);

            //equality operators
            bool isEqual = num1 == num2;
            Console.WriteLine("Result of num1 == num2 is {0}", isEqual);
            

            isEqual = num1 != num2;
            Console.WriteLine("Result of num1 != num2 is {0}", isEqual);

            //Conditional operators && Both have to be true for 'True' result
            bool isLowerAndSunny = isLower && isSunny;
            Console.WriteLine("Result of isLower and IsSunny is {0}", isLowerAndSunny);

            //Only one needs to be true to return 'True' result
            isLowerAndSunny = isLower || isSunny;
            Console.WriteLine("Result of isLower or IsSunny is {0}", isLowerAndSunny);

            Console.ReadKey();

        }
        //public static int Calculate()
        //{
        //    Console.WriteLine("Please enter the first number");
        //    string number1Input = Console.ReadLine();
        //    Console.WriteLine("Please enter the second number");
        //    string number2Input = Console.ReadLine();

        //    int num1 = int.Parse(number1Input);
        //    int num2 = int.Parse(number2Input);

        //    int result = num1 + num2;
        //        return result;
        //}
         
    }
}
