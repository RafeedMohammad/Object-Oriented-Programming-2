using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the month number: ");
            int MonthNumber = Convert.ToInt32(Console.ReadLine());

            Month m = new Month(MonthNumber);

            Console.WriteLine(m);
        }
    }
}
