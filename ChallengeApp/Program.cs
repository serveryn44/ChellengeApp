

using ChallengeApp;

Console.WriteLine("Witamy w programie XYZ do oceny Pracowników");
Console.WriteLine("=============================================");
Console.WriteLine();

var employee = new EmployeeInMemory("Adam", "Kamizelich");

employee.GradesAdded += Employee_GradesAdded;

void Employee_GradesAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}

employee.AddGrade(0.6f);

while (true) 
{ 
    
    Console.WriteLine("podaj kolejną ocenę pracownika");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }

    try
    {

        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"exception catched: {e.Message}");
    }

}

var statistics = employee.GetStatistics();
Console.WriteLine($"average {statistics.Average}");
Console.WriteLine($"min {statistics.Min}");
Console.WriteLine($"max {statistics.Max}");
Console.WriteLine($"averageletter {statistics.AverageLetter}");
