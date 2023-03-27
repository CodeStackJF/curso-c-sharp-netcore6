namespace _17_palindromo;
class Program
{
    static void Main(string[] args)
    {
        string palabra = args[0];
        bool remove_whitespaces = args.Count() == 2 && args[1] == "/w"; 
        Console.WriteLine(esPalindromo(palabra, remove_whitespaces));
    }

    public static bool esPalindromo(string word, bool remove_whitespaces = false)
    {
        //return word == word.Reverse().ToString();
        word = word.Trim();
        word = remove_whitespaces ? word.Replace(" ", ""):word;
        string drow = "";
        for(int i = word.Count() - 1; i >= 0; i--)
        {
            drow += word[i];
        }
        return word == drow;
    }
}

//anona
//ana
//anita lava la tina