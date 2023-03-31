using ChallengeApp;
using System.Reflection.Metadata;


List<Employee> employees = new List<Employee>();
{

}    

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employeeWithMaxResult = employee;
    }
}
Console.WriteLine("Najwyższą ocenę ma: " + employeeWithMaxResult.Name);
Console.WriteLine("Imię: " + employeeWithMaxResult.Name);
Console.WriteLine("Nazwisko: " + employeeWithMaxResult.Surname);
Console.WriteLine("Wiek:  " + employeeWithMaxResult.Age);
Console.WriteLine("Liczba zdobytych punktów: " + employeeWithMaxResult.Result);