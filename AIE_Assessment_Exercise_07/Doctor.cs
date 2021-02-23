using System;
using System.Collections.Generic;
using System.Text;

namespace AIE_Assessment_Exercise_07
{
    class Doctor : Person
    {
        protected int Salary;

        public Doctor() : base()
        {

        }

        public Doctor(string personName, string phoneNumber, string emailAddress, string salary) : base(personName, phoneNumber, emailAddress, salary)
        {

        }

        public override void SayGreeting()
        {
            Console.WriteLine($"Hello, I'm Dr. {personName}.");
        }

        //what happens if you just want the doctor class to have 
        public void DeliverPrognosis(Person patient)
        {
            Console.WriteLine($"Hello {patient.personName}, I am Dr. {personName}. I'm sorry but I'm afraid you only have three months live.");
        }

        public override void SalaryBoast()
        {
            Console.WriteLine($"Dr. {personName}: Stop flexing bro. That's nothing. I make {salary} a year.");
        }

    }
}
