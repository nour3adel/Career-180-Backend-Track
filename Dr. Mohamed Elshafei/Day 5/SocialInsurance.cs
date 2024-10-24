namespace Day5
{
    class SocialInsurance
    {
        public List<Employee> Employees { get; private set; }


        public SocialInsurance()
        {
            Employees = new List<Employee>();
        }

        public void BeginSocialInsurance(Employee emp)
        {
            Employees.Add(emp);
            Console.WriteLine($"{emp} has been added to the social insurance");
        }
    }
}
