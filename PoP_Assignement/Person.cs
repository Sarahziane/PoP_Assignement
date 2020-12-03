using System;
using System.Collections.Generic;
using System.Text;

namespace PoP_Assignement
{
  public  class Person
    {
        private string first_name;
        private string last_name;
        public string First_name
        {
            get { return this.first_name; }
            set
            {
                if (value == null)
                { throw new ArgumentNullException(); }
                this.first_name = value;
            }

        }
        public string Last_name
        {
            get { return this.last_name; }
            set
            {
                if (value == null)
                { throw new ArgumentNullException(); }
                this.last_name = value;
            }
        }

        public Person(string first_name, string last_name)
        {
            this.first_name = first_name;
            this.last_name = last_name;
        }
  
    }
}
