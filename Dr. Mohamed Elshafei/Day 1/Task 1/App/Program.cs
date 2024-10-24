namespace App;
using StudentService;

class Program
{
    static void Main(string[] args)
    {
        Department department = new Department { DepartmentID = 1, DepartmentName = "Computer Science" };
        Student student = new Student(department) { StudentID = 1, Name = "Nour", Email = "nour@gmail.com" };

        Console.WriteLine(student.GetDepartmentName());
        Console.WriteLine(student.GetString());
    }
}