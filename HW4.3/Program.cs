using HW4._3.Model;
using System.Diagnostics;
using System.Xml.Linq;

namespace HW4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // TASK 1
            //Employee employee = new Employee("Leyla",1000,true);

            //Assistant asistant = new Assistant();
            //asistant.GetFeedBack(employee);
            //Console.WriteLine(employee.Salary);

            // TASK 2

            //var inputs = Input();
            //var student = CreateStudent(inputs.name, inputs.age, inputs.grade);
            //student.ShowInfo();
        }

        public static (string name,int age,int grade) Input()
        {
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter grade: ");
            int grade = Convert.ToInt32(Console.ReadLine());
            return (name,age,grade);
        }

        public static Student CreateStudent(string name, int age, int grade)
        {
            Student student = new Student(name, age, grade);
            if (student.Name == string.Empty || student.Age == 0 || student.Grade == 0)
            {
                Console.WriteLine("Try again. Wrong inputs");
                (name, age, grade) = Input();
                CreateStudent(name, age, grade);
            }

            return student;
        }
    }
}