using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Human

    {
        //memeber variable
        private string firstname;
        private string lastname;
        private string eyeColor;
        private int age;

        //Default constructor
        public Human()
        {
            Console.WriteLine("Constructor called. Object Human created");
        }
      
        public Human(string firstname )
        {
            this.firstname = firstname;
            
        }
        public Human(string firstname, string lastname )
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }
        public Human(string firstname, string lastname, string eyeColor)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.eyeColor = eyeColor;
  
        }
        //Constructor method used whenever this object is created
        public Human(string firstname, string lastname, string eyeColor, int age)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.eyeColor = eyeColor;
            this.age = age;


        }



        //member mehtod
        public void IntroduceMyself()
        {
            if (firstname != null && lastname != null && eyeColor != null && age != 0)
                Console.WriteLine("Hi, I'm {0} {1} and {2} year old. My eye color is {3}", firstname, lastname, age, eyeColor);
            else if (firstname != null && lastname != null && eyeColor != null)
                Console.WriteLine("Hi, I'm {0} {1}. My eye color is {2}", firstname, lastname, eyeColor);
            else if (firstname != null && lastname != null)
                Console.WriteLine("Hi, I'm {0} {1}.", firstname, lastname);
            else if (firstname != null)
                Console.WriteLine("Hi, I'm {0}.", firstname);
            
            
            else
                Console.WriteLine("Hi, I'm a Human");
        }
    }
}
