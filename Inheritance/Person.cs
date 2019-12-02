using System;

namespace Inheritance
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char MiddleInit { get; set; }
        public string RitId { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Person()
        {
            FirstName = "John";
            LastName = "Doe";
            MiddleInit = 'M';
            DateOfBirth = new DateTime();
        }

        public Person ( string _firstName, string _lastName, char _midInit, string _id, DateTime _dob ) {
            FirstName = _firstName;
            LastName = _lastName;
            MiddleInit = _midInit;
            RitId = _id;
            DateOfBirth = _dob;
        }

        public override string ToString() {
            string result = String.Format("{0}, {1} {2}\n", LastName, FirstName, MiddleInit);
            result += String.Format("DOB: {0}\n", DateOfBirth.ToShortDateString());
            result += String.Format("ID: {0}\n", RitId);

            return result;
        }
    }
}