namespace Day5
{
    class Club
    {
        public List<Employee> Employees { get; private set; }

        public Club()
        {
            Employees = new List<Employee>();
        }

        public void AddOnClub(Employee emp)
        {
            Employees.Add(emp);
            Console.WriteLine($"{emp} has been added to the club");
        }
    }
}
