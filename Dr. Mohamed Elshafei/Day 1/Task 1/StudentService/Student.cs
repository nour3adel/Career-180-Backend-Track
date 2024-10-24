namespace StudentService;

public class Student
{
    public int StudentID { get; set; }

    public required string Name { get; set; }

    public required string Email { get; set; }

    public int DepartmentID { get; set; }

    public Department Department { get; set; }

    public Student(Department department)
    {
        DepartmentID = department.DepartmentID;
        Department = department;
    }

    public string GetString()
    {
        return $"{StudentID} - {Name} - {Email} - {Department.DepartmentName}";
    }

    public string GetDepartmentName()
    {
        return Department.DepartmentName;
    }
}
