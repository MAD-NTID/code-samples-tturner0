using System;

namespace NameStructExample
{

    struct NameStruct
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }

        public void ChangeName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NameStruct ns = new NameStruct();
            ns.FirstName = "Tiandre";
            ns.LastName = "Turner";
            Console.WriteLine($"Full name is {ns.FullName()}");

            ChangeName(ns);

            Console.WriteLine($"Full name is {ns.FullName()}");
        }

        static void ChangeName(NameStruct ns)
        {
            Console.WriteLine($"In method ChangeName, the current full name is {ns.FullName()}");
            ns.ChangeName("Keith", "Waterman");
            Console.WriteLine($"In method ChangeName, the current full name is {ns.FullName()}");
        }
    }
}
