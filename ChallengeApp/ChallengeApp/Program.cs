using ChallengeApp;

Employee employee1 = new Employee("Karol", "Radzikowski", 30);
Employee employee2 = new Employee("Alicja", "Radzikowska", 26);
Employee employee3 = new Employee("Klara", "Radzikowska", 3);

employee1.AddScore(5);
employee1.AddScore(2);
employee1.AddScore(9);
employee1.AddScore(7);
employee1.AddScore(8);


employee2.AddScore(9);
employee2.AddScore(3);
employee2.AddScore(1);
employee2.AddScore(2);
employee2.AddScore(10);



employee3.AddScore(4);
employee3.AddScore(5);
employee3.AddScore(1);
employee3.AddScore(2);
employee3.AddScore(6);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
    };
int maxScore = -1;
Employee employeeTopScore = null;

foreach (var employee in employees)
{
    if (employee.Score > maxScore)
    {
        maxScore = employee.Score; 
        employeeTopScore = employee;
    }
}



Console.WriteLine("Imię:" + employeeTopScore.Name);
Console.WriteLine("Nazwisko:" + employeeTopScore.Surname);
Console.WriteLine("Wiek:" + employeeTopScore.Age + "Lat");
Console.WriteLine("Ilość punktów:" + employeeTopScore.Score + "Pkt");




