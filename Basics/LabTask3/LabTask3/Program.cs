using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask3
{
    class Employee
    {
        public int empNo;
        public string name { get; set; }
        public int yearOfHire;
       // public int currentYear = 2020;
        public string jobDesc { get; set; }
        public string dept { get; set; }
        private decimal sal;
        //public int age { get; set; }

        public Employee(int sn_no, string nm, int date_of_hire, string job_desc, string department, decimal salary)
        {
            empNo = sn_no;
            name = nm;
            yearOfHire = date_of_hire;
            jobDesc = job_desc;
            dept = department;
            Salary = salary;
            
            
        }

        public decimal Salary
        {
            get{return sal; }
            set
            {
                if(value >= 0)
                {
                    sal = value;
                }
            }
        }

       // public int Age
        //{
          //  get { return age; }
            //set
           // {
             //   age = currentYear - yearOfHire;
            //}
        //}

        public void toString()
        {
            Console.WriteLine("++++++++++++++++++++++Employee Information+++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Employee No. " + empNo);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Job Description: {0}\nDepartment: {1}\nSalary: {2}" ,jobDesc, dept, sal);
            //Console.WriteLine("Age: " + age);
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

        }

    }
}
