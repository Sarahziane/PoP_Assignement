using System;
using System.Collections.Generic;
using System.Text;

namespace PoP_Assignement
{
   public class Address
    {
        private int address_;
        private string street;
        private string city;
        private string country;

        public int Address_
        {
            get { return this.address_; }
            set
            {
                if (value == null)
                { throw new ArgumentNullException(); }
                this.address_ = value;
            }

        }
        public string Street
        {
            get { return this.street; }
            set
            {
                if (value == null)
                { throw new ArgumentNullException(); }
                this.street = value;
            }
        }
        public string City
        {
            get { return this.city; }
            set
            {
                if (value == null)
                { throw new ArgumentNullException(); }
                this.city = value;
            }
        }
        public string Country
        {
            get { return this.country; }
            set
            {
                if (value == null)
                { throw new ArgumentNullException(); }
                this.country = value;
            }
        }

        public Address(int address_, string street, string city, string country)
        {
            this.address_ = address_;
            this.street = street;
            this.city = city;
            this.country = country;
        }

    }
}
