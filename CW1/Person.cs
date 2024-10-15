using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW1
{
    internal class Person
    {
        // Private fields to store the persons first name, last name and age
        private string firstName; 
        private string lastName;
        private int age;

        //Public property to access and modify the first name
        public string FirstName
        {
            get { return firstName; } // get the current value of firstName
            set { firstName = value; } // Set a new value to firstName

        }

       //Public property to access and modify the last name
        public string LastName
        {
            get { return lastName; } // get the current value of lastNamw
            set { lastName = value; } // set a new value to lastName
        }

        //Public property to access and modify age
        public int Age
        {
            get { return age; } // get the current value of age
            set { age = value; } // set a new value to age
        }

        //*** CONSTRUCTOR to initialise the fields when a new object is created 
        public Person(String FirstName, String LastName, int Age)
        {
            this.FirstName = FirstName; // Assign the constructor parameter to the FirstName property
            this.LastName = LastName;   // Assign the constructor parameter to the LastName property
            this.Age = Age; // Assign the constructor parameter to the Age property
        }

        // Method to print the persons details to the console
        public void PrintName()
        {
            Console.WriteLine("First name : " + firstName); // print the first name
            Console.WriteLine("Last name : " + lastName); // Print the last name
            Console.WriteLine("Age : " + age); // Print the age
            Console.WriteLine(); // Add an empty line for spacing
        }

        public static Person CalculateOldest(Person p1, Person p2) // New method to calculte the oldest person
        {
            if (p1.age > p2.age)
            {
                return p1; // if p1 is older, return p1
            }
            else
            {
                return p2; // if p2 is older return p2
            }

        }
    }
}