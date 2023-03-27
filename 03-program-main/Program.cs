namespace _03_program_main;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine(Saludar("José"));
    }

    static string Saludar(string nombre)
    {
        return "Hola, " + nombre;
    }
}
