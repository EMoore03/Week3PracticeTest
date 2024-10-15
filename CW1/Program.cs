using CW1;
using System;

namespace YourNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Person person = new Person("Ethan", "Moore", 23); // Create a new 'Person' object with first name, last name and age
            person.PrintName(); // Call the 'PrintName' method to display persons details

            Person person1 = new Person("Ellie", "Dixon", 20);
            person1.PrintName(); // Display Ellies details, REMEMBER person1 = person1.PrintName!!

            Person person2 = new Person("Davy", "Scott", 46);
            person2.PrintName(); // Print Davys detaild, REMEMBER person2 = person2.PrintName!!!

            Person oldestPerson = Person.CalculateOldest(person1, person2); // Call the CalculateOldest method to find the oldest person

            Console.WriteLine("The oldest person is: "); // display all information about the oldest person
            oldestPerson.PrintName(); // This will print the details
            
            Task1();
            Task2();
            Task3();
        }

        static void Task1()
        {
            for (int num = 1; num <= 10; num++) // Looping from 1-10
            {
                Console.WriteLine(num); // Printing the results
            }
            Console.WriteLine(); //Adding a break between task 1 & 2
        }

        static void Task2()
        {
            for (int num = 10; num >=1 ; num--) // Looping from 10-1
            {
                Console.WriteLine(num); // Printing the results
            }
        }

        static void Task3()
        {
            int count = 1; // initalise count
            int sum = 0; //initalise to store
            while (count != 0) // when count is not equal to 0
            {
                Console.WriteLine("Please enter a integer, Enter 0 to quit");
                count = Convert.ToInt32(Console.ReadLine()); // Converting count into an integer the user can input
                Console.WriteLine();

                if (count == 0) // if count is equal to 0, exit the app, always remember the BREAK!!!
                {
                    Console.WriteLine("Exiting the program");
                    break; // REMEMBER THIS!!
                }

                sum += count; // this is the sum, addng each numbers
                Console.WriteLine("Current total of all numbers added is  " + sum); // displaying result to the screen

            }
        }



    }
}


