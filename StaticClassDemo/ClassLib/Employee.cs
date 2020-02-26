using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Employee
    {
        private string _empFirstName;
        private string _empLastName;
        private string _id;
        private string _sin;

        public string EmpFirstName 
        {
            get;set;
        }

        public string EmpLastName
        {
            get; set;
        }

        public decimal HourlyRate
        {
            get; set;
        }

        public decimal HoursWorked
        {
            get; set;
        }

        public string ID
        {
            get; set;
        }

        public string SIN
        {
            get; set;
        }

        public Employee() { }

    }
}
