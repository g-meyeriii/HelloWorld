using System;

namespace HelloWorld

  
{
    class Program
    {
        static string username;
        static string password;

        static void Main(string[] args)
        {
            Register();
            Login();
            Console.Read();
        }
        static void Register()
        {
            Console.WriteLine("Please enter username.");
            username = Console.ReadLine();
            Console.WriteLine("Please enter password");
            password = Console.ReadLine();
            Console.WriteLine("Registration complete!");
        }
        static void Login()
        {
            Console.WriteLine("Please enter username.");
            if (username == Console.ReadLine())
            {
                Console.WriteLine("Please enter password");
                if (password == Console.ReadLine())
                {
                    Console.WriteLine("Login complete!"); ;
                }
                else
                {
                    Console.WriteLine("Login failed, (password) restart program");
                }
            }
            else
            {
                Console.WriteLine("Login failed, (username) restart program");
            }
        }
    }
}
