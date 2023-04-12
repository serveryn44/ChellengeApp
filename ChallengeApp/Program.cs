using ChallengeApp;

var employee = new Employee("Adam", "Kowalski");
employee.AddGrade("Adam");
employee.AddGrade("4000");
employee.AddGrade(8);
employee.AddGrade(2);
employee.AddGrade(9.5);

var statistics = employee.GetStatisticsWithWhile();
Console.WriteLine("While");
Console.WriteLine($"Average:{statistics.Average:N2}");
Console.WriteLine($"Min:{statistics.Min}");
Console.WriteLine($"Max:{statistics.Max}");

var statistics1 = employee.GetStatistisWithForeach();
Console.WriteLine("Foreach");
Console.WriteLine($"Average:{statistics.Average:N2}");
Console.WriteLine($"Min:{statistics.Min}");
Console.WriteLine($"Max:{statistics.Max}");

var statistics2 = employee.GetStatisticWithDoWhile();
Console.WriteLine("DoWhile");
Console.WriteLine($"Average:{statistics.Average:N2}");
Console.WriteLine($"Min:{statistics.Min}");
Console.WriteLine($"Max:{statistics.Max}");

var statistics3 = employee.GetStatisticWithFor();
Console.WriteLine("For");
Console.WriteLine($"Average:{statistics.Average:N2}");
Console.WriteLine($"Min:{statistics.Min}");
Console.WriteLine($"Max:{statistics.Max}");
