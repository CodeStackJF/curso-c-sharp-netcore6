namespace _16_dictionary;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new List<int>(){
            0,1,2,3,4,5
        };
        int a = numeros[0];
        
        Dictionary<string, int> mi_diccionario = new Dictionary<string, int>(){
            {"A", 5},
            {"B", 8}
        };

        int valor = mi_diccionario["A"];
        mi_diccionario.Add("C", 7);
        mi_diccionario.Remove("A");
        Console.WriteLine(string.Join(',', mi_diccionario));

        Dictionary<int, string> estudiantes = new Dictionary<int, string>(){
            {1, "José"},
            {2, "Juan"},
            {3, "Carlos"},
            {4, "Pedro"},
        };

        foreach(KeyValuePair<int, string> estudiante in estudiantes)
        {
            Console.WriteLine($"{estudiante.Key} - {estudiante.Value}");
        }

        for(int i = 0; i <= estudiantes.Count - 1; i++)
        {
            Console.WriteLine($"{estudiantes.ElementAt(i).Key} - {estudiantes.ElementAt(i).Value}");
        }
    }
}
