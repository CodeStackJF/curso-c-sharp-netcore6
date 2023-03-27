namespace _07_metodos_funciones;
class Program
{
    static void Main(string[] args)
    {
        Saludar("karla", "guevara", "de urbina");
        Saludar("jairo", "campos");
        int total = Suma(4, 7);
        Console.WriteLine("La suma es: " +  total);
        Console.WriteLine("La suma es: " +  Suma(4, 7));
        int total_dos = Suma(5, 6, 8);

        int total_array = Suma(new int[] {4,6,8,3,2,7,8});
        Console.WriteLine("Total en un array: " + total_array);

        int total_array_params = Suma(4,6,3,2,5,6,8,7,8,5,3,1,4);
        Console.WriteLine("Total en un array con params: " + total_array_params);
    }

    static void Saludar(string nombre, string apellido, string apellido_casada = "")
    {
        Console.WriteLine("Hola " + nombre + " " + apellido + " " + apellido_casada);
    }

    static int Suma(int a, int b)
    {
        //int total = a + b;
        return a + b;
    }

    static int Suma(int a, int b, int c)
    {
        //int total = a + b;
        return a + b;
    }

    /*static int Suma(int[] numbers)
    {
        int total = numbers.Sum();
        return total;
    }*/

    static int Suma(params int[] numbers)
    {
        int total = numbers.Sum();
        return total;
    }
}
