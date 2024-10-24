namespace Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(101, "Nour");
            Employee employee2 = new Employee(102, "Ibrahim");


            Club club = new Club();
            SocialInsurance socialInsurance = new SocialInsurance();


            employee1.Employee_Add += club.AddOnClub;
            employee2.Employee_Add += club.AddOnClub;

            employee1.Employee_Add += socialInsurance.BeginSocialInsurance;

            employee1.Add();
            employee2.Add();


            Console.WriteLine("\nEmployees in the Club:");
            foreach (var emp in club.Employees)
            {
                Console.WriteLine(emp);
            }

            Console.WriteLine("\nEmployees in Social Insurance:");
            foreach (var emp in socialInsurance.Employees)
            {
                Console.WriteLine(emp);
            }
        }
    }
}
