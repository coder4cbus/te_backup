using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Employee
    {
        //class properties listed below...
        private int employeeId;
        private string firstName;
        private string lastName;
        private string fullName;
        private string department;
        private double annualSalary;

        //accessors
        public int EmployeeId
        {
            get;
        }

        public string FirstName
        {
            get;
            
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public string FullName
        {
            get
            {
                return ($"{LastName}, {FirstName}");
            }
        }
        public string Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }
        public double AnnualSalary
        {
            get
            {
                return annualSalary;
            }
            private set
            {
                annualSalary = value;
            }
        }
        //constructor 
        public Employee(int employeeId, string firstName, string lastName, double salary)
        {
            EmployeeId = employeeId;
            FirstName = firstName;
            LastName = lastName;
            AnnualSalary = salary;
        }

        // method
        public void RaiseSalary(double percent)
        {
            AnnualSalary += (double)AnnualSalary * (double)(percent/100.0);
        }
    }
}
