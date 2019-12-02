using System;

namespace Inheritance
{
    public class Student : Person
    {
        public string ProgramCode { get; set; }
        public short ProgramYear { get; set; }
        public string CellPhone { get; set; }

        public Student() : base()
        {
            ProgramCode = "MAD";
            ProgramYear = 2019;
            CellPhone = "(555) 555-5555";
        }

        public Student ( string _firstName, string _lastName, char _midInit, 
                         string _id, DateTime _dob, string _prgCode, 
                         short _prgYear, string _cell ) : base (_firstName, _lastName, _midInit, _id, _dob) {
            ProgramCode = _prgCode;
            ProgramYear = _prgYear;
            CellPhone = _cell;
        }

        public override string ToString() {
            string result = base.ToString();
            result += String.Format("Program: {0}/{1}\n", ProgramCode, ProgramYear);
            result += String.Format("Cell: {0}\n", CellPhone);
            return result;
        }
    }
}