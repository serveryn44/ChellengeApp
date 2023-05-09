using ChallengeApp;

Console.WriteLine("Witamy w programie XYZ do oceny Pracowników");
Console.WriteLine("=============================================");
Console.WriteLine();

var employee = new EmployeeInFile("Adam", "Kamizelich");
employee.AddGrade('a');
employee.AddGrade(28.5);
employee.AddGrade('c');
employee.AddGrade(150);

//while (true)
//{
//    console.writeline("podaj kolejną ocenę pracownika");
//    var input = console.readline();
//    if (input == "q")
//    {
//        break;
//    }

//    try
//    {

//        employee.addgrade(input);
//    }
//    catch (exception e)
//    {
//        console.writeline($"exception catched: {e.message}");
//    }

//}

//var statistics = employee.getstatistics();
//console.writeline($"average {statistics.average}");
//console.writeline($"min {statistics.min}");
//console.writeline($"max {statistics.max}");
//console.writeline($"averageletter {statistics.averageletter}");
