using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4._3.Model
{
    internal class Employee
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { 
                if(value.Length>3 && value.Length<15)
                    _name = value;
                else Console.WriteLine("Wrong format");
            }
        }

        private decimal _salary;

        public decimal Salary
        {
            get { return _salary; }
            set { 
                if(value>0)
                     _salary = value;
                else Console.WriteLine("Salary can not be negative");
            }
        }
        public bool IsSuccessfull { get; set; }

        public Employee(string name, decimal salary, bool isSuccessfull)
        {
            Name = name;
            Salary = salary;
            IsSuccessfull = isSuccessfull;
        }
    }
}
