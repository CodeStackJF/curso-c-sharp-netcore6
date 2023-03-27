namespace _10_estructura_switch;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(diaSemanaSwitch(9));
    }

    public static string diaSemana(int dia)
    {
        string nombre_dia = "";
        if(dia == 1)
        {
            nombre_dia = "Lunes";
        }
        else if(dia == 2)
        {
            nombre_dia = "Martes";
        }
        else if(dia == 3)
        {
            nombre_dia = "Miercoles";
        }
        else if(dia == 4)
        {
            nombre_dia = "Jueves";
        }
        return nombre_dia;
    }

    public static string diaSemanaSwitch(int dia)
    {
        string nombre_dia = "";
        switch(dia)
        {
            case 1:
                nombre_dia = "Lunes";
                break;
            case 2: 
                nombre_dia = "Martes";
                break;
            case 3: 
                nombre_dia = "Miércoles";
                break;
            case 4: 
                nombre_dia = "Jueves";                
                break;
            case 5:
                nombre_dia = "Viernes";
                break;
            case 6:
                nombre_dia = "Sábado";
                break;
            case 7: 
                nombre_dia = "Domingo";
                break;
            default:
                nombre_dia = "Día no válido.";
                break;
        }
        return nombre_dia;
    }
}
