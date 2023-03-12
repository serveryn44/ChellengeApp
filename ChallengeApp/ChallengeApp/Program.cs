using System.ComponentModel.Design;

var name = "Ewa";
var age = 33;
char gender = 'F';



if (gender == 'F' && age <= 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");

}
else if (name == "Ewa" && age == 33 && gender == 'F')
{
    Console.WriteLine("Ewa Lat 33");
}

 else if ( age < 18 && gender != 'F')
{
    Console.WriteLine("niepełnoletni mężczyzna");
}
else if (age > 33 && gender == 'F')
{
    Console.WriteLine("Nieznana Kobieta po 30-tce");
}
else
{
    Console.WriteLine(name + age + gender);
}






