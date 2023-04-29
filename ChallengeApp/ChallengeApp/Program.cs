using ChallengeApp;
Console.WriteLine("Witamy w programie oceny pracowników: Employee-XYZ");
Console.WriteLine("////////////////////////////////////////////////////");
Employee employee = new Employee("Karol", "Radzikowski");
while(true)
{
    Console.WriteLine("Podaj kolejną ocene pracownika:");
    var input = Console.ReadLine();
    if(input == "q") 
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

var statistics = employee.GetStatistics();
Console.WriteLine($"Averange:{statistics.Average:N2}");
Console.WriteLine($"Min:{statistics.Min}");
Console.WriteLine($"Max:{statistics.Max}");






