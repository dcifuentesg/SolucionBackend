//Punto 1
int year;

Console.WriteLine("Ingrese año");
year = Convert.ToInt32(Console.ReadLine());

if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
{
    Console.WriteLine($"El año {year} es bisiesto");
}
else
{
    Console.WriteLine($"El año {year} no es bisiesto");
}