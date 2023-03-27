namespace _06_conversion_tipos;
class Program
{
    static void Main(string[] args)
    {
        string a = "5";
        string b = "8";
        string total = a + b;
        Console.WriteLine("El total es: " + total);
        //string a un int
        int a_numero = Convert.ToInt32(a);
        int b_numero = Convert.ToInt32(b);
        double total_numero = a_numero + b_numero;
        Console.WriteLine("El total es: " + total_numero);

        string a_string = "0.465";
        string b_string = "9.476";
        double a_decimal = Convert.ToDouble(a_string);
        double b_decimal = Convert.ToDouble(b_string);
        int total_decimal = Convert.ToInt32(a_decimal + b_decimal);
        Console.WriteLine("El total es: " + total_decimal);

        string si_no = args[0];
        bool es_mayor_de_edad = si_no == "s";
        Console.WriteLine("El valor recibido es:" + es_mayor_de_edad);

        int numero_uno = 5;
        double numero_dos = 7;
        Console.WriteLine("El primero valor es " + numero_uno.ToString() + " el segundo valor es " + numero_dos.ToString());
    }
}
