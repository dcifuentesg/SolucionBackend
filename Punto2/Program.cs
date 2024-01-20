//Punto 2
static int Fib(int n)
{
    if (n <= 1)
    {
        return n;
    }
    else
    {
        return Fib(n - 2) + Fib(n - 1);
    }
}

Console.WriteLine("ingrese un numero");
int numero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Fib(numero));
