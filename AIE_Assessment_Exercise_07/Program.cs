/*
 * Appendix 4 - Exercise 1: Greetings
 */

using System;

namespace AIE_Assessment_Exercise_07
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO:
            // Create instances of
            // - A Person and Doctor classes.

            // Person p1 = new Person("Bob");
            // Doctor p2 = new Doctor("Fred");
            // Person p3 = new Doctor("Ted");

            // Invoke the "SayGreeting" method on the above instances
            // p1.SayGreeting(); // hello I'm Bob
            // p2.SayGreeting(); // hello I'm Dr. Fred
            // p3.SayGreeting(); // hello I'm Dr. Ted

            Person p1 = new Person("Bob", "04777777", "bob@bobbo.com");
            Person p2 = new Doctor("Fred", "04888888", "fred@freddo.com");
            Person p3 = new Doctor("Ted", "04999999", "ted@teddo.com");

            p1.SayGreeting();
            p2.SayGreeting();
            p3.SayGreeting();

            //Add doctor salary
        }



    }
}
