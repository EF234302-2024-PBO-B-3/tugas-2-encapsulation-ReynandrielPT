using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Employment
{
    public class Employee
    {
        private string _firstName;
        private string _lastName;
        private double _monthlySalary;
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    _firstName = "Unknown";
                }
                else
                {
                    _firstName = value;
                }
            }
        }
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    _lastName = "Unknown";
                }
                else
                {
                    _lastName = value;
                }
            }
        }
        public double MonthlySalary
        {
            get { return _monthlySalary; }
            set
            {
                if (value < 0)
                {
                    _monthlySalary *= 1;
                }
                else
                {
                    _monthlySalary = value;
                }
            }

        }

        public Employee(string Depan, string Blkng, double gaji)
        {
           FirstName = Depan; LastName = Blkng; MonthlySalary = gaji;
           
        }

        public void RaiseSalary(double raisePercentage)
        {
            if (raisePercentage > 0.0 && raisePercentage <= 20)
            {
                MonthlySalary *= (100 + raisePercentage) / 100;
            }
            else
            {
                MonthlySalary *= 1;
            }
        }
        public double GetYearlySalary()
        {
            return MonthlySalary * 12;
        }
    }

    //public class Program
    //{
    //    static void Main()
    //    {
    //        Employee test = new Employee("Rey", "Prams", 5000);
    //        Employee test1 = new Employee("Than", "Dya", 6000);
    //        Employee test2 = new Employee("", "", 7000);
    //        Console.WriteLine(test2.FirstName + " " + test2.LastName);  
    //        Console.WriteLine(test.GetYearlySalary());
    //        Console.WriteLine(test1.GetYearlySalary());
    //        test.RaiseSalary(100);
    //        test.RaiseSalary(20);
    //        Console.WriteLine(test.GetYearlySalary());
    //    }
    //}

}

