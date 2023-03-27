namespace _11_estructura_while;
class Program
{
    static void Main(string[] args)
    {
        int limite = 100;
        int i = 0;
        while(i <= limite)
        {
            if(i % 2 == 0)
            {
                Console.WriteLine(i);
            }
           i++;
        }
        sumar();
        doWhile();
    }

    public static void sumar()
    {
        //el usuario va a introducir numeros, y cuando detecto algo que no es un numero dejara de pedir
        //y sumara los valores
        List<int> numeros = new List<int>();
        bool isANumber = true;
        while(isANumber)
        {
            Console.WriteLine("Ingrese un numero:");
            string? entrada = Console.ReadLine();
            int numero_temporal = 0;
            if(int.TryParse(entrada, out numero_temporal))
            {
                numeros.Add(numero_temporal);
            }
            else
            {
                isANumber = false;
            }
        }
        Console.WriteLine($"El total de los numeros ingresados es: {numeros.Sum()}");
    }

    public static void doWhile()
    {
        List<int> numeros = new List<int>();
        bool isANumber = false;
        do {
            Console.WriteLine("Ingrese un numero:");
            string? entrada = Console.ReadLine();
            int numero_temporal = 0;
            if(int.TryParse(entrada, out numero_temporal))
            {
                numeros.Add(numero_temporal);
                isANumber = true;
            }
            else
            {
                isANumber = false;
            }
        }
        while(isANumber);
        Console.WriteLine($"El total de los numeros ingresados es: {numeros.Sum()}");
    }
}
//while, do... while