namespace _05_manejo_tipos_datos;
using System;
class Program
{
    static void Main(string[] args)
    {
        int a = Convert.ToInt32(args[0]);
        int b = Convert.ToInt32(args[1]);

        int total = a + b;
        Console.WriteLine("El total es: " + total);
    }
}
