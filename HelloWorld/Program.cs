using System;

namespace ConstansC

    //Constants are immutable balues with are known
    //at compile time and do not change for the life of the program.
{
    class Program
    {
        //contants as fields

        const double PI = 3.14159265359;
        const int weeks = 52, months = 12;
        const string bday = "07.15.1977";


        static void Main(string[] args)
        {
            
            Console.WriteLine("My birthday is always going to be: {0}", bday);
            Console.Read();
        }

    }
}
