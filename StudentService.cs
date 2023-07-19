using ConsoleApp28.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp28.Models;

namespace ConsoleApp28.Service
{
    public class StudentService
    {
        private List<Student> students;
        public StudentService()
        {
            students = new List<Student>();
        }

        public List<Student> GetStudents()
        {
            return students;
        }
        public List<Student> GetStudents(string name)
        {
            return students;
        }

        public void AddStudent(int id, string name, string surname, double grade)
        {
            var student = new Student(name, surname, grade);
            students.Add(student);
        }

        public void RemoveStudent(int id)
        {
            var ExistingStudent = students.FirstOrDefault(x => x.id == id);
            if (ExistingStudent == null) throw new Exception("Not Found");
            students = students.Where(x => x.id != id).ToList();
        }
        public void FindStudent(int id, string name, string surname)
        {
            var ExistingStudent = students.FirstOrDefault(x => x.id != id && x.Name == name && x.Surname == surname);
            if (ExistingStudent == null) throw new Exception("Not Found");
            students = students.Where(x => x.id != id && x.Name != name && x.Surname != surname).ToList();
        }
    }
}
