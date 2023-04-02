using ChallengeApp;

var employee = new Employee("Adam", "Kowalski");
employee.AddGrade(3);
employee.AddGrade(5);
employee.AddGrade(8);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average:{statistics.Average:N2}");
Console.WriteLine($"Min:{statistics.Min}");
Console.WriteLine($"Max:{statistics.Max}");