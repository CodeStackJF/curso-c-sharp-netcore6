namespace _12_estructura_for;
class Program
{
    static void Main(string[] args)
    {
        int j = 0; //i = iterator
        for(j = 0; j <= 10; j++)
        {
            Console.WriteLine(j);
            j++;
        }

        string[] abecedario = new string[]{"A", "B", "C", "D", "E", "F" };
        //indice desde cero a cinco
        //longitud = 6
        for(int i = 0; i <= abecedario.Length - 1; i++)
        {
            Console.WriteLine(abecedario[i]);
        }

        for(int i = abecedario.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(abecedario[i]);
        }
    }
}
