using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask3

{ 
    class Test
    {
        private static DateTime date_of_hire;

        static void Main(string[] args)
        {
            //var today = DateTime.Today;

             Employee e1 = new Employee(1, "Rafeed Mohammad", 2015, "Project Manager" ,"Software Department", 200000);
             Employee e2 = new Employee(2, "Black Sabbath", 1882, "Managing Director", "Human Resource Management Dept.", 200000);
             e1.toString();
             e2.toString();

    }
   }
}

