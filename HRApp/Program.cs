
using System;
using HRLib;
namespace HRApp
{  internal class Program
    {
        static void Main(string[] args)
        { try
            {
                ConfirmEmployee confirmemp = new ConfirmEmployee("Aarav", "Pune", 32000, "Senior Developer");
                Console.WriteLine(confirmemp); 
                Console.WriteLine("Confirm Employee Salary: " + confirmemp.CalculateSalary());
                Console.WriteLine();
            }
            catch (MinimumBasicException ex)
            {
                Console.WriteLine("Error (ConfirmEmployee): " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error (ConfirmEmployee): " + ex.Message);
            }
            try
            {
                Trainee trainee = new Trainee("Neha", "Mumbai", 20, 800);
                Console.WriteLine(trainee); 
                Console.WriteLine("Trainee Salary: " + trainee.CalculateSalary());
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error (Trainee): " + ex.Message);
            }
            try
            {
                ConfirmEmployee invalid = new ConfirmEmployee("Isha", "Nashik", 4000, "Analyst");
                Console.WriteLine(invalid);
                Console.WriteLine("Invalid Confirm Salary: " + invalid.CalculateSalary());
            }
            catch (MinimumBasicException ex)
            {
                Console.WriteLine("Exception caught (Invalid ConfirmEmployee): " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error (Invalid ConfirmEmployee): " + ex.Message);
            }

        }
    }
}

