using System;
using System.Collections.Generic;
using System.Text;

namespace PoP_Assignement
{
    public class Student : Person
    {
        // Attributes 

        private string studentnbr;
        private int age;
        private int averagescore;

        public int Averagescore
        {
            get { return this.averagescore; }
            set
            {
                this.averagescore = value;
            }
        }
        public string Studentnbr
        {
            get { return this.studentnbr; }
            set
            {
                if (value == null)
                { throw new ArgumentNullException(); }
                this.studentnbr = value;
            }

        }
        public int Age
        {
            get { return this.age; }
            set
            {

                if (value < 0)
                { throw new ArgumentOutOfRangeException(); }
                this.age = value;
            }

        }
        private string fulladdress;
        public string Fulladdress
        {
            get { return this.fulladdress; }
            set
            {
                if (value == null)
                { throw new ArgumentNullException(); }
                this.fulladdress = value;
            }

        }

        private Address address;
        public Address Address
        {
            get { return this.address; }
            set
            {
                if (value == null)
                { throw new ArgumentNullException(); }
                this.address = value;
            }
        }

        public Student(string first_name, string last_name, string studentnbr, int age, Address address, string fulladdress)
            : base(first_name, last_name) // The constructor inherites the first and last name directly from the class Person. 
        {
            this.address = address;
            this.studentnbr = studentnbr;
            this.age = age;
            this.fulladdress = $"n°{ address.Address_} { address.Street}, { address.City}, { address.Country}";
        }

        public override string ToString()
        {
            // Displays 

      return     $"\n\n\n Student : \n\n {First_name + " " + Last_name} " +
                 $"\n\n {Age} years old " +
                 $"\n\n {studentnbr}"

               + $"\n\n\n       {First_name + " " + Last_name}'s average score is {Averagescore}"

               + $"\n\n\n       {First_name + " " + Last_name} is living in {address.City}"

               + $"\n\n\n       {First_name + " " + Last_name}'s address is {fulladdress}";
        }

        public int Score()
        { 
            //Creates an array with a given number of scores, adds this score to the array. When all the scores have been entered, calculates and returns the average 

            Console.WriteLine("\n\n\n How many scores are there ? ");
            int length = int.Parse(Console.ReadLine());
            int[] scores = new int[length];
            int compteur = 1;
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine("\n Score n°" + compteur + " : ");
                int nbr = int.Parse(Console.ReadLine());

                scores[i] = nbr;

                compteur++;
            }

            // goes through the array to calculate the avrage based on the numbers entered

            int total = 0;
            foreach(var item in scores)
            {
                total += item;
            }
            Averagescore = total / scores.Length;
            return Averagescore;
        }
    }
}
