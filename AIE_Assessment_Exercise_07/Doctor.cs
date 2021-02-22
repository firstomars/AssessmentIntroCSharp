using System;
using System.Collections.Generic;
using System.Text;

namespace AIE_Assessment_Exercise_07
{
    class Doctor : Person
    {
        
        public Doctor() : base()
        {

        }

        public Doctor(string personName, string phoneNumber, string emailAddress) : base(personName, phoneNumber, emailAddress)
        {

        }

        public override void SayGreeting()
        {
            Console.WriteLine($"Hello, I'm Dr. {personName}.");
        }

    }
}
