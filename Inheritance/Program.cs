using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Copied from Day40Code
            Person aPerson = new Person("John", "Jones", 'J', "12345", new DateTime(1962, 10, 25));

            System.Console.WriteLine("\n***Just a Person***");
            System.Console.WriteLine( aPerson );

            // Now, for a student!

            Student aStudent = new Student("Mary", "Smith", 'J', "1122334", new DateTime(1975, 5, 30), "ICSM", 2, "800-555-1212");
            System.Console.WriteLine("\n***Now for a student***");
            System.Console.WriteLine( aStudent );

            Person stripped = aStudent;
            System.Console.WriteLine("\n***Casting the student to a Person***");
            System.Console.WriteLine( stripped );

            List<Person> people = new List<Person>();
            people.Add(aPerson);
            people.Add(aStudent);
            people.Add(new Undergraduate("Keith", "Waterman", 'X', "000000000", new DateTime(), "MAD", 2019, "(555) 555-5555", false));
            people.Add(new Graduate("Tiandre", "Turner", 'X', "000000000", new DateTime(), "MAD", 2019, "(555) 555-5555", false));
            //people.Add(12);

            foreach(Person person in people)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
