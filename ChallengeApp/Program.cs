using ChallengeApp;




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
//Console.WriteLine("Imię: " + employeeWithMaxResult.Name);
//Console.WriteLine("Nazwisko: " + employeeWithMaxResult.Surname);
//Console.WriteLine("Liczba zdobytych punktów: " + employeeWithMaxResult.Result);