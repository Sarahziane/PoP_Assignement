using System;

namespace PoP_Assignement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Gets all the informations about the student

            Console.WriteLine("\n First name ?");
            string fst = Console.ReadLine();
            Console.WriteLine("\n Last name ?");
            string lst = Console.ReadLine();
            Console.WriteLine("\n Age ?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("\n Student number?");
            string studentnbr = Console.ReadLine();


            Console.WriteLine("\n Address number ?");
            int nb = int.Parse(Console.ReadLine());
            Console.WriteLine("\n Street ?");
            string str = Console.ReadLine();
            Console.WriteLine("\n City ?");
            string cty = Console.ReadLine();
            Console.WriteLine("\n Country ?");
            string cnty = Console.ReadLine();

            // creates a new address, based on the class Address
            Address address1 = new Address(nb,str,cty,cnty);

            // creates a new student, based on the class Student, which inherits from the class Person
            Student student1 = new Student(fst, lst, studentnbr, age, address1, "");

            // returns the average score
            student1.Score();    

            // Displays the complete status of the student created. 
            Console.WriteLine(student1.ToString());

            Console.ReadKey();
        }
    }
}
 