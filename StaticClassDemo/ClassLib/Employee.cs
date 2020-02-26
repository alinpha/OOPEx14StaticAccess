using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Employee
    {
        const int MAX_NAME_LENGTH = 15;
        const int MIN_NAME_LENGTH = 1;

        private string _empFirstName;
        private string _empLastName;
        private string _id;
        private string _sin;

        public string EmpFirstName 
        {
            get
            {
                return _empFirstName;
            }
            set 
            {
                if (!Validate.ValidateMinLength(MIN_NAME_LENGTH, value))
                    throw new ConstraintException($"name must be at least {MIN_NAME_LENGTH} charachters long");

                if (!Validate.ValidateMaxLength(MAX_NAME_LENGTH, value))
                    throw new ConstraintException($"name must be no longer than {MAX_NAME_LENGTH} characters");

                _empFirstName = value;
            }
        }

        public string EmpLastName
        {
            get
            {
                return _empLastName;
            }
            set
            {
                if (!Validate.ValidateMinLength(MIN_NAME_LENGTH, value))
                    throw new ConstraintException($"last name must be at least {MIN_NAME_LENGTH} charachters long");

                if (!Validate.ValidateMaxLength(MAX_NAME_LENGTH, value))
                    throw new ConstraintException($"last name must be no longer than {MAX_NAME_LENGTH} characters");

                _empLastName = value;
            }
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
            get
            {
                return _id;
            }

            set
            {
                if (!Validate.ValidateLength(5, value))
                    throw new ConstraintException("id must be 5 characters long");

                _id = value;
            }
        }

        public string SIN
        {
            get
            {
                return _sin;
            }

            set
            {
                if (!Validate.ValidateLength(9, value))
                    throw new ConstraintException($"sin must be 9 charachters long");

                if (!Validate.ValidateInteger(value))
                    throw new ConstraintException($"sin must be numeric");

                _sin = value;
            }
        }

        public Employee() { }

    }
}
