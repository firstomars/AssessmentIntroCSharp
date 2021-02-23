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
        public string salary;
            
        public Person()
        {

        }

        public Person(string name, string phoneNumber, string emailAddress, string sal)
        {
            this.personName = name;
            this.phoneNumber = phoneNumber;
            this.emailAddress = emailAddress;
            this.salary = sal;
        }

        public virtual void SayGreeting()
        {
            Console.WriteLine($"Hello, I'm {personName}.");
        }

        public virtual void SalaryBoast()
        {
            Console.WriteLine($"{personName}: Are you kidding me? Fix me damn it. How much $$ do you want?? I'll pay whatever you want. I make {salary} a year.");
        }

    }
}
