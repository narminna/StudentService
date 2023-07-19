using ConsoleApp28.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28.Service
{
    public class MenuService
    {
        private static StudentService studentService = new StudentService();
        public static void MenuShowStudents()
        {
            var students = studentService.GetStudents();
            if (students.Count == 0)
            {
                Console.WriteLine("No students yet.");
                return;
            }
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.id} | Name: {student.Name} | Surname: {student.Surname} | Grade: {student.Grade}");
            }
        }
        public static void MenuAddStudent()
        {
            try
            {
                Console.WriteLine("Enter student's ID:");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter student's name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter student's surname:");
                string surname = Console.ReadLine();

                Console.WriteLine("Enter student's grade:");
                double grade =double.Parse(Console.ReadLine());

                studentService.AddStudent(id, name, surname, grade);

                Console.WriteLine("Added student successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Oops, Error {ex.Message}");
            }
            
        }
        public static void MenuUpdateStudent()
        {
            try
            {
                Console.WriteLine("Enter student's ID:");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter student's name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter student's surname:");
                string surname = Console.ReadLine();

                Console.WriteLine("Enter student's grade:");
                double grade = double.Parse(Console.ReadLine());

                var students = studentService.GetStudents();

                if (students != null)
                {
                    studentService.AddStudent(id, name, surname, grade);
                    Console.WriteLine("Updated successfully");
                }
                else
                {
                    Console.WriteLine("Not found");
                }                       
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Oops, Error {ex.Message}");
            }
        }
        public static void MenuRemoveStudent()
        {
            try
            {
                Console.WriteLine("Enter student's ID:");
                int id = int.Parse(Console.ReadLine());

                studentService.RemoveStudent(id);

                Console.WriteLine("Deleted student successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Oops, Error {ex.Message}");
            }
        }
        public static void MenuFindStudentByName()
        {
            try
            {
                
                string name = Console.ReadLine();
                Console.WriteLine("Enter student's surname:");
                
                List<Student> students = studentService.GetStudents(name);

                if (students.Count > 0)
                {
                    foreach (var student in students)
                    {
                        Console.WriteLine(students);
                    }
                    
                }
                else
                {
                    Console.WriteLine("Not found students with same name");
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Oops, Error {ex.Message}");
            }
        }
    }
}
