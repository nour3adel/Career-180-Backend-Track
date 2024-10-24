namespace Day5
{
    public delegate void EmployeeEvent(Employee emp);

    public class Employee
    {
        public int Id { get; set; }
        public string Emp_Name { get; set; }


        public Employee(int id, string emp_name)
        {
            Id = id;
            Emp_Name = emp_name;
        }

        public event EmployeeEvent Employee_Add;

        public void Add()
        {
            Employee_Add?.Invoke(this);
        }

        public override string ToString()
        {
            return $"Employee with id: {Id} and name: {Emp_Name}";
        }
    }

}
