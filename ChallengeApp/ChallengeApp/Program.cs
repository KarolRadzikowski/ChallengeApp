using ChallengeApp;
Console.WriteLine("Witamy w programie oceny pracowników: Employee-XYZ");
Console.WriteLine("////////////////////////////////////////////////////");
EmployeeInFile employee = new EmployeeInFile("Karol", "Radzikowski","Mężczyzna");
employee.GradeAdded += Employee_GradeAdded;

void Employee_GradeAdded(object sender, EventArgs agrs)
{
    Console.WriteLine("New grade has been added");
}

while (true)
{
    Console.WriteLine("Podaj kolejną ocene pracownika:");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try
    {
        employee.AddGrades(input);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
employee.AddGrade(10);

var statistics = employee.GetStatistics();
Console.WriteLine($"Averange:{statistics.Average:N2}");
Console.WriteLine($"Min:{statistics.Min}");
Console.WriteLine($"Max:{statistics.Max}");






