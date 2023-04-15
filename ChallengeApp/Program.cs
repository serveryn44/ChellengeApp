using ChallengeApp;

var employee = new Employee("Adam", "Kowalski");
employee.AddGrade("Adam");
employee.AddGrade("4000");
employee.AddGrade(8);
employee.AddGrade(2);
employee.AddGrade(9.5);

var statistics = employee.GetStatistics();
Console.WriteLine("Foreach");
Console.WriteLine($"Average:{statistics.Average:N2}");
Console.WriteLine($"Min:{statistics.Min}");
Console.WriteLine($"Max:{statistics.Max}");
