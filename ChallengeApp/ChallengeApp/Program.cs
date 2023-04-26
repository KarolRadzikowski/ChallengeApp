using ChallengeApp;
Employee employee = new Employee("Karol", "Radzikowski");

employee.AddGrades(5);
employee.AddGrades(6);
employee.AddGrades(2);
employee.AddGrades(3);
employee.AddGrades(1);
var statistics = employee.GetStatistics();
Console.WriteLine($"Averange:{statistics.Average:N2}");
Console.WriteLine($"Min:{statistics.Min}");
Console.WriteLine($"Max:{statistics.Max}");
var statistics1 = employee.GetStatisticsWitchForEach();
var statistics2 = employee.GetStatisticsWhitchWhile();
var statistics3 = employee.GetStatisticsWhitchDoWhile();
var statistics4 = employee.GetStatisticsWhitchFor();






