﻿using ChallengeApp;


Employee employee1 = new Employee("Adam", "Kowalski", 33);
Employee employee2 = new Employee("Zuzia", "Nowak", 45);
Employee employee3 = new Employee("Damian", "Iksiński", 22);


employee1.AddScore(1);
employee1.AddScore(3);
employee1.AddScore(3);
employee1.AddBadScore(3);
employee1.AddBadScore(3);

employee2.AddScore(1);
employee2.AddScore(1);
employee2.AddBadScore(4);
employee2.AddBadScore(1);
employee2.AddScore(1);

employee3.AddScore(0);
employee3.AddScore(2);
employee3.AddScore(0);
employee3.AddBadScore(4);
employee3.AddBadScore(4);

List<Employee> employees = new List<Employee>();
{
    employees.Add(employee1); employees.Add(employee2); employees.Add(employee3);
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