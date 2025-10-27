using Tyuiu.GogolevVM.Sprint3.Task2.V0.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        int x;
        double sp = 0;
        int i = 0;
        for (x = -2; x <= 2; x++)
        {
            if (x == 0)
            {
                break;
            }
            sp = sp + (3 * x - x);
            i++;
        }
        Console.WriteLine(sp);
    }
}