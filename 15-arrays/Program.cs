namespace _14_arrays;
class Program
{
    //Array.Resize(ref arr, 10);
    static void Main(string[] args)
    {
        int[] lista = new int[3];
        lista[0] = 50;
        lista[1] = 100;
        lista[2] = 300;
        /*lista[3] = 500;
        lista[4] = 600;*/

        string[] letras = new string[]{ "A", "B", "C", "D" };
        letras[3] = "E";

        estudiante est = new estudiante();
        object[] diferentes_tipos = new object[] {1,  "hola", true, 2.53, est};
        int indice_uno = (int)diferentes_tipos[0];
        string indice_dos = (string)diferentes_tipos[1];

        int[,] multidimensional = new int[,] { {1,2,4,5}, {3,6,7,5}, {2,5,5,6} };
        int valor = multidimensional[0, 1];

        int[,,] multidimensional_2 = new int[,,] { {{1}, {3}} };

        int[][] jagged_array = new int[4][];
        jagged_array[0] = new int[]{3,5,7};
        jagged_array[1] = new int[]{9,0,4};
    }
}


class estudiante
{
    public int id { get; set; }
    public string nombre { get; set; }
}