using System;

namespace HelloWorld

  
{
    class Program
    {
        
        static int highscore = 300;
        static string highScorePlayer= "George";
        

        static void Main(string[] args)
        {
            //int age = 17;

            //if (age == 15)
            //{
            //    Console.WriteLine("Too young to skydive");
            //}
            //else if (age > 18)
            //{
            //    Console.WriteLine("Old enough to skydive");
            //}
            //else
            //{
            //    Console.WriteLine("How old are you then?");
            //}

            //switch (age)
            //{
            //    case 15:
            //        Console.WriteLine("Too young to skydive");
            //        break;
            //    case 25:
            //        Console.WriteLine("Old enough to skydive");
            //        break;
            //    default:
            //        Console.WriteLine("How old are you then?");
            //        break;
            //}

            //string username = "Root";

            //switch (username)
            //{
            //    case "George":
            //        Console.WriteLine("username is George");
            //        break;
            //    case "root":
            //        Console.WriteLine("username is root");
            //        break;
            //    default:
            //        Console.WriteLine("username is unknown");
            //        break;
            //}
            CheckScore(295, "Joe");
            CheckScore(310, "Luke");
            CheckScore(350, "George");

            Console.Read();
        }
        static void CheckScore(int score, string playerName)
        {
            if(highscore < score)
            {
                highscore = score;
                highScorePlayer = playerName;
                Console.WriteLine("New high score is "+ score);
                Console.WriteLine("New highscore holder is " + playerName);
            }
            else
            {
                Console.WriteLine("The old highscore of " + highscore + " is still held by " + highScorePlayer);
            }
        }
       
    }
}
