namespace _15_listas;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new List<int>(){
            1,4,5,6
        };
        numeros.Add(5);
        numeros.Add(5);
        numeros.Add(9);
        numeros.Add(20);

        List<int> numeros_dos = new List<int>(){100, 200, 300};
        numeros.AddRange(numeros_dos);

        int valor_0 = numeros[0];
        numeros[0] = 7;

        Console.WriteLine(string.Join(',', numeros));

        numeros.RemoveAll(x=>x == 5);
        Console.WriteLine(string.Join(',', numeros));

        numeros.RemoveAt(4);

        //numeros.Count;
        numeros.Count();
        
        List<List<int>> lista_anidada = new List<List<int>>{
            new List<int>(){
                2,4,6,7
            },
            new List<int>(){
                9,6,2,6
            }
        };

        Console.WriteLine(lista_anidada[0][0]);
        Console.WriteLine(numeros[numeros.Count - 1]);
        List<Estudiante> estudiantes = new List<Estudiante>();
    }
}

class Estudiante
{
    public int id { get; set; }
    public string nombre { get; set; }
}
