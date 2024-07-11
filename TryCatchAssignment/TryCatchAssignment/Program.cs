using System;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter their age
            Console.WriteLine("Please enter your age:");

            try
            {
                // Read the user's input and convert it to an integer
                int age = Convert.ToInt32(Console.ReadLine());

                // Check if the entered age is zero or negative
                if (age <= 0)
                {
                    // Display an error message for zero or negative numbers
                    Console.WriteLine("Error: Age must be a positive number greater than zero.");
                }
                else
                {
                    // Calculate the year the user was born
                    int currentYear = DateTime.Now.Year;
                    int birthYear = currentYear - age;

                    // Display the calculated birth year to the user
                    Console.WriteLine("You were born in the year: " + birthYear);
                }
            }
            catch (FormatException)
            {
                // Display a specific error message if the input is not a valid number
                Console.WriteLine("Error: Please enter a valid number.");
            }
            catch (Exception)
            {
                // Display a general error message for any other exceptions
                Console.WriteLine("An error occurred. Please try again.");
            }

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}
