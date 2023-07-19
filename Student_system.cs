using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28.Models
{
    public class Student
    {
        private static int counter = 0;

        public Student(string name, string surname, double grade)
        {
            Name = name;
            Surname = surname;
            Grade = grade;
        }

        public Student(string name, string surname, double grade, int ID)
        {
            Name = name;
            Surname = surname;
            Grade = grade;
            id = counter;
            counter++;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public double Grade { get; set; }
        public int id { get; set; }
    }
}
