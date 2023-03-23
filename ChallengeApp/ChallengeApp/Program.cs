using ChallengeApp;


Employee employee1 = new Employee("Adam", "Kowalski", 33);
Employee employee2 = new Employee("Zuzia", "Nowak", 45);
Employee employee3 = new Employee("Damian", "Iksiński", 22);


employee1.AddScore(5);
employee1.AddScore(3);
employee1.AddScore(3);
employee1.AddScore(30);
employee1.AddScore(3);

employee2.AddScore(1);
employee2.AddScore(1);
employee2.AddScore(0);
employee2.AddScore(10);
employee2.AddScore(1);

employee3.AddScore(4);
employee3.AddScore(4);
employee3.AddScore(4);
employee3.AddScore(4);
employee3.AddScore(4);

List<Employee> employees = new List<Employee>();
{
    employees.Add(employee1); employees.Add(employee2); employees.Add(employee1);
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
