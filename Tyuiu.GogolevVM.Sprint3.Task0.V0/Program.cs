using Tyuiu.GogolevVM.Sprint3.Task0.V0.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        double x, y;
        x = -4;
        y = Math.Round(2 * x - 4 + ((2 * x - 1) / (Math.Sin(x) + 1)),2  );
        Console.WriteLine(y);

    }
}