using Tyuiu.GogolevVM.Sprint3.Task6.V10.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил: Гоголев В.М | АСОиУБ-25-1";
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* Спринт #3                                                                                *");
        Console.WriteLine("* Тема: Обработка целочисленной информацией                                                *");
        Console.WriteLine("* Задание #6                                                                               *");
        Console.WriteLine("* Вариант #10                                                                               *");
        Console.WriteLine("* Выполнил: Гоголев Вcеволод Михайлович | АСОиУБ-25-1                                      *");
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
        Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих числовому отрезку      *");
        Console.WriteLine("* [20, 32] сумму всех делителей больше 12                                                  *");
        Console.WriteLine("*                                                                                          *");

        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                                          *");
        Console.WriteLine("********************************************************************************************");
        int startValue = 20;
        int stopValue = 32;

        Console.WriteLine("Начало отрезка = " + startValue);
        Console.WriteLine("Конец отрезка = " + stopValue);

        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");

        Console.WriteLine("Сумма делителей = " + ds.GetSumTheDivisors(startValue, stopValue));
    }
}