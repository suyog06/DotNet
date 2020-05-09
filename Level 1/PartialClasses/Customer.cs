using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialClasses
{
    public class Customer
    {
        private string _firstname;
        private string _lastname;

        public string Firstname
        {
            get
            {
                return _firstname;
            }
            set
            {
                _firstname = value;
            }
        }

        public string Lastname { get => _lastname; set => _lastname = value; }

        public string GetFullName()
        {
            return _firstname + " , " + _lastname;
        }
    }
}