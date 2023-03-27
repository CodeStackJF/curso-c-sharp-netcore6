namespace _13_estructura_for_each;
class Program
{
    static void Main(string[] args)
    {
        //for = establecemos un limite claro
        //foreach = se va a ejecutar hasta que llegue al limite desconocido
        int[] numeros = new int[]{1,2,4,5,6,7,8};
        int i = 1;
        foreach(int numero in numeros)
        {
            Console.WriteLine($"En la posición {i} se encuentra el número {numero}");
            i++;
        }

        string nombre = "josé fuentes"; //char = caracter
        foreach(char caracter in nombre)
        {
            Console.WriteLine(caracter);
        }

        for(int j = 0; j <= nombre.Length - 1; j++)
        {
            Console.WriteLine(nombre[j]);
        }
    }
}
