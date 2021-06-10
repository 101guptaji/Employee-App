using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLib;

namespace HRAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfirmEmployee e1 = new ConfirmEmployee("Himanshu", "Jaipur, Raj", 50000, "Junior Developer");
            Console.WriteLine(e1);
            try
            {
                Console.WriteLine("Salary: " + e1.CalculateSalary());
            }
            catch(MinimumBasic ex)
            {
                Console.WriteLine(ex.Message);
            }

            ConfirmEmployee e2 = new ConfirmEmployee();
            e2.Name = "Ravi Sinha";
            e2.Address = "Alwar, Rajasthan";
            e2.Basic = 20000;
            e2.Designation = "Intern";
            Console.WriteLine(e2);

            try
            {
                Console.WriteLine("Salary: " + e2.CalculateSalary());
            }
            catch (MinimumBasic ex)
            {
                Console.WriteLine(ex.Message);
            }
           

            Trainee t1 = new Trainee("Shunder", "Ranchi, India", 20, 5);
            Console.WriteLine(t1);

            Console.WriteLine("Salary: "+t1.CalculateSalary());
            Console.ReadLine();
        }
    }
}
