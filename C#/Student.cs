using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise.C_
{
    class Student
    {
        //
        // Long da sua
        //
        //
        /**
         * name
         * full name student
         * @name    string
         */
        private string _name;
        public string namestudent
        {
            get
            {
                return "sv " + this._name;
            }
            set
            {
                this._name = value;
            }
        }


    }
}
