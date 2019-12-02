using System;

namespace Inheritance
{
    public class Undergraduate : Student
    {
       public bool CompletedCoop {get; set;}


        public Undergraduate ( string _firstName, string _lastName, char _midInit, 
                         string _id, DateTime _dob, string _prgCode, 
                         short _prgYear, string _cell, bool _completedCoop ) : base(_firstName, _lastName, _midInit, _id, _dob, _prgCode, _prgYear, _cell){
            CompletedCoop = _completedCoop;
        }

        public override string ToString() {
            string result = base.ToString();
            result += String.Format("Completed Coop: {0}\n", CompletedCoop);
            return result;
        }
    }
}