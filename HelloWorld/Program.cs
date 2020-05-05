using System;

namespace HelloWorld


{
    class Program
    {

        static void Main(string[] args)
        {

            //Human greg = new Human("Greg");
            //greg.IntroduceMyself();

            //Human jason = new Human("Jason", "Yoho") ;
            //jason.IntroduceMyself();

            //Human leela = new Human("Leela", "Meyer", "Brown");
            //leela.IntroduceMyself();

            //Human maria = new Human("Maria", "Meyer", "Green", 29);
            //maria.IntroduceMyself();

            //Human basicHuman = new Human();
            //basicHuman.IntroduceMyself();

            //Box box = new Box(3,4,5);



            //Console.WriteLine("Box width is " + box.Width);
            //box.Width = 10;
            //Console.WriteLine("Box width is " + box.Width);

            //Console.WriteLine("Box volume is " + box.Volume);

            //Console.WriteLine("Box area is " + box.Area);
            //box.DisplayInfo();

            Members member1 = new Members();
            member1.Introducing(true);


            Console.Read();
        }    
        
    }
}
