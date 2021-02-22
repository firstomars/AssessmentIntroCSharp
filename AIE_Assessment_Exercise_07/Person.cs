using System;
using System.Collections.Generic;
using System.Text;

namespace AIE_Assessment_Exercise_07
{
    class Person
    {
        public string personName;
        public string phoneNumber;
        public string emailAddress;
            
        public Person()
        {

        }

        public Person(string name, string phoneNumber, string emailAddress)
        {
            this.personName = name;
            this.phoneNumber = phoneNumber;
            this.emailAddress = emailAddress;
        }

        public virtual void SayGreeting()
        {
            Console.WriteLine($"Hello, I'm {personName}.");
        }
    }
}
