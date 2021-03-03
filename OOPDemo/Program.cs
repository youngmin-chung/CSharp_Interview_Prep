using System;

/// <summary>
/// What’s POLYMORPHISM? 
/// It’s when classes have different functionality while sharing the same interface.
/// REMEMBER TO NOTE!!!: Interfaces or abstract classes can be used
/// 
/// What’s encapsulation?
/// Prevents access to implementation details.
/// 
/// What’s abstraction? 
/// Abstraction allows making relevant information visible.
/// 
///  What's inheritance?
///  When an object or classe is based on a parent object or 
///  class taking on its characteristics. 
/// </summary>

namespace OOPDemo
{
    public class Employee
    {
        public virtual void CalculateWeeklySalary(int weeklyHours, int wage)
        {
            var salary = 40 * wage;
            Console.WriteLine("\nThis EMPLOYEE worked {0} hrs. " +
                              "Paid for 40 hrs (no overtime) at $ {1}" +
                              "/hr = ${2} \n", weeklyHours, wage, salary);
            Console.WriteLine("---------------------------------------------\n");
        }
    }

    public class Contractor : Employee
    {
        public override void CalculateWeeklySalary(int weeklyHours, int wage)
        {
            var salary = weeklyHours * wage;
            Console.WriteLine("\nThis CONTRACTOR worked {0} hrs. " +
                              "Paid for {0} hrs (w/ overtime) at $ {1}" +
                              "/hr = ${2} ", weeklyHours, wage, salary);
        }
    }

    public class Program
    {
        private static void Main(string[] args)
        {
            const int hours = 50, wage = 70;
            Employee person = new Employee();
            person.CalculateWeeklySalary(hours, wage);

            Contractor contractor = new Contractor();
            contractor.CalculateWeeklySalary(hours, wage);

        }
    }
}
