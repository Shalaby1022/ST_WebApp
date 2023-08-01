namespace ST_WebApp.Models
{
    public class SampleData
    {
        public static List<Employee> Employees { get; } = new List<Employee>
        {
            new Employee
            {
                Id = 1,
                Name = "Ahmed Shalaby",
                Age = 28,
                Salary = 50000,
                Address = "10st Menouf",
                Email = "Shelby@gmail.com"
            },
            new Employee
            {
                Id = 2,
                Name = "Ibrahim Poliska",
                Age = 30,
                Salary = 60000,
                Address = "Gdansk",
                Email = "HemaShalaby@gmsil.com"
            },
            new Employee
            {
                Id = 3,
                Name = "Mohamed ",
                Age = 32,
                Salary = 60000,
                Address = "El-Horya St",
                Email = "montenegro@gmail.com"
            },


        };
    }
}
