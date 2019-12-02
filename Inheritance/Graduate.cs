using System;

namespace Inheritance
{
    public class Graduate : Student
    {
       public bool CompletedThesisOrCapstone {get; set;}


        public Graduate ( string _firstName, string _lastName, char _midInit, 
                         string _id, DateTime _dob, string _prgCode, 
                         short _prgYear, string _cell, bool _completedThesisOrCapstone) : base(_firstName, _lastName, _midInit, _id, _dob, _prgCode, _prgYear, _cell){
            CompletedThesisOrCapstone = _completedThesisOrCapstone; 
        }

        public override string ToString() {
            string result = base.ToString();
            result += String.Format("Completed Thesis or Capstone: {0}\n", CompletedThesisOrCapstone);
            return result;
        }
    }
}