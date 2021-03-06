﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask2
{
    class Month
    {
        
        public Month(int monthNumber)
        {
            MonthNumber = monthNumber;
        }

        public int MonthNumber { get; set;}

        public string MonthName()
        {
            string monthName;

            switch (MonthNumber)
            {
                case 1:
                    monthName = "January";
                    break;

                case 2:
                    monthName = "February";
                    break;

                case 3:
                    monthName = "March";
                    break;

                case 4:
                    monthName = "April";
                    break;

                case 5:
                    monthName = "May";
                    break;

                case 6:
                    monthName = "June";
                    break;

                case 7:
                    monthName = "July";
                    break;

                case 8:
                    monthName = "August";
                    break;

                case 9:
                    monthName = "September";
                    break;

                case 10:
                    monthName = "Ocotober";
                    break;

                case 11:
                    monthName = "November";
                    break;

                case 12:
                    monthName = "December";
                    break;

                default:
                    monthName = "Invalid Input";
                    break;
            }

            return monthName;
        }


        public int MonthDays()
        {
            if(MonthNumber == 1 || MonthNumber == 3 || MonthNumber == 5 || MonthNumber == 7 
                || MonthNumber == 8 || MonthNumber == 10 || MonthNumber == 12)
            {
                return 31;
            } 

            else if(MonthNumber == 2)
            {
                return 28;
            }

            else
            {
                return 30;
            }
        }

        public override string ToString()
        {
            return string.Format("Month of {0} has {1} days", MonthName(), MonthDays());
        }

        
    }

   
}
