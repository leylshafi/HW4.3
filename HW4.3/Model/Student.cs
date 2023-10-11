using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HW4._3.Model
{
    internal class Student
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                char firstLetter = value[0];
                string temp= value.Trim().Substring(1).ToLower();
                value = Char.ToUpper(firstLetter) + temp;
                Regex rg = new Regex("^[A-Z]{1}[a-z]{1,}$");
                if (rg.IsMatch(value))
                    _name = value;
                else Console.WriteLine("Wrong format");
            }
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set
            {
                Regex rg = new Regex("^(?:[6-9]|[1-4]\\d|50)$");
                if (rg.IsMatch(value.ToString()))
                    _age = value;
                else Console.WriteLine("Age should be between 6-50");
            }
        }

        private int _grade;

        public int Grade
        {
            get { return _grade; }
            set
            {
                Regex rg = new Regex("^(?:[1-9]\\d?|100)$");
                if (rg.IsMatch(value.ToString()))
                    _grade = value;
                else Console.WriteLine("Grade should be between 0-100");
            }
        }

        public Student(string name, int age, int grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }

        public void ShowInfo()
        {
            Console.WriteLine($@"Name: {Name},
Age: {Age},
Grade: {Grade}");
        }
    }
}
