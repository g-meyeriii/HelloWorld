using System;

namespace HelloWorld

    //Constants are immutable balues with are known
    //at compile time and do not change for the life of the program.
{
    class Program
    {
        ////contants as fields

        //const double PI = 3.14159265359;
        //const int weeks = 52, months = 12;
        //const string bday = "07.15.1977";


        static void Main(string[] args)
        {

            //Console.WriteLine("My birthday is always going to be: {0}", bday);
            //Console.Read();

            //WriteSomething();
            //WriteSomethingSpecific("I am an argument and am called from a method");


            //Console.WriteLine(Add(15,14));
            //Console.Read();

            string friend1 = "Frank";
            string friend2 = "Michael";
            string friend3 = "Wlad";


            GreetFriend(friend1);
            GreetFriend(friend2);
            GreetFriend(friend3);
            Console.Read();
        }
        // access modifier (static) return type method name (parameter1, parameter2)
        public static void WriteSomething()

        {
            Console.WriteLine("I am called from a method");
         
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
            Console.Read();        
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;

        }
        public static int Multiply(int num1, int num2)
        {

            return num1 * num2;
        }
        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
        public static void GreetFriend(string friend)
        {
            Console.WriteLine("Hi "+  friend + " , my friend");
        }
    }
}
