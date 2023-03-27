namespace _09_estructura_if;
class Program
{
    static void Main(string[] args)
    {
        int edad = Convert.ToInt32(args[0]);
        string genero = args[1]; //M, F
        if (edad >= 18 && genero == "F")
        {
            Console.WriteLine("Es mayor de edad y es de genero femenino");
        }
        else if(edad >= 18 && genero == "M")
        {
            Console.WriteLine("Es mayor de edad y es de genero másculino.");  
        }
        else if(edad < 18 && genero == "F")
        {
            Console.WriteLine("Es menor de edad y es de genero femenino.");  
        }
        else if(edad < 18 && genero == "M")
        {
            Console.WriteLine("Es menor de edad y es de genero másculino.");  
        }
        else
        {
            Console.WriteLine("No se cumple ninguna de las anteriores condiciones.");
        }
        calcularDescuento();
    }

    public static void calcularDescuento()
    {
        double precio = 10;
        double descuento = 0;
        string dia = "Domingo";
        int edad = 9;
        //dependiendo del dia de la semana vamos a aplicar un descuento diferente
        // si es lunes 5%
        // si es martes o jueves 15%
        // si es domingo y la persona es menor de edad tendra el 20%
        if(dia == "Lunes")
        {
            descuento = 0.05;
        }
        else if(dia == "Martes" || dia == "Jueves")
        {
            descuento = 0.15;
        }
        else if(dia == "Domingo" && edad < 18)
        {
            descuento = 0.20;
        }

        double total_pagar = precio - (precio * descuento);
        Console.WriteLine($"El precio del producto es {precio} y el descuento aplicado es de {descuento} asi que su total a pagar es {total_pagar}");
    }
}
// > mayor que
// < menor que
// <> distinto != 
// >= mayor o igual
// <= menor o igual
// == igual

/*
if, switch
while, do while, for, foreach
*/