using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace HelloWorld
{
    class Members
    {
        //member - private field
        private string memberName;
        private string jobTitle;
        private int salary= 20000;
        //member - public field
        public int age;

        // member - property - exposes jobTitle safely - properties start with capital letter
        public string JobTitle {
            get {
                return jobTitle;
            }
            set {
                jobTitle = value;
            }
        }
        // public member methd

        public void Introducing(bool isFriend)
        {
            if(isFriend == true)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi, my name is {0}, job title is {1}. I'm {2} years old.", memberName, jobTitle, age);
            }
        }
        private void SharingPrivateInfo()
        {
            Console.WriteLine("My salary is {0}", salary);
        }
        //member constructor
        public Members()
        {
            age = 30;
            memberName = "Lucy";
            salary = 60000;
            jobTitle = "Developer";
            Console.WriteLine("Object created");
        }
        // member - finalizer - destructor
        ~Members()
        {
            // cleanup statements
            Console.WriteLine("Deconstruction of Members objects");
            Debug.Write("Destruction of Members objects");
        }
    }
}
