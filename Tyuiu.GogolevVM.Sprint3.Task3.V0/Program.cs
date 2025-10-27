internal class Program
{
    private static void Main(string[] args)
    {
        string str = "12rt ojt c45";
   
        foreach (char c in str) 
        { 
            if (Char.IsDigit(c)) 
            {
                str = str.Replace(c,'i');
            }
        
        }

        Console.WriteLine(str);
    }
}