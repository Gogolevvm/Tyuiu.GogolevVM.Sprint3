using Tyuiu.GogolevVM.Sprint3.Task1.V28.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил: Гоголев В.М | АСОиУБ-25-1";
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* Спринт #0                                                                                *");
        Console.WriteLine("* Тема: Оператор цикла for                                                                 *");
        Console.WriteLine("* Задание #1                                                                               *");
        Console.WriteLine("* Вариант #28                                                                               *");
        Console.WriteLine("* Выполнил: Гоголев Вcеволод Михайлович | АСОиУБ-25-1                                      *");
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
        Console.WriteLine("* Написать программу используя цикл for, которая вычисляет сумму ряда по формуле,при a=0,5 *");
        Console.WriteLine("* и печатает результат на экране, вычисляет результат по формуле и печатает его на экране. *");
        Console.WriteLine("*                                                                                          *");

        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                                          *");
        Console.WriteLine("********************************************************************************************");

        double value = 0.5;
        int startValue = 1;
        int stopValue = 18;

        Console.WriteLine("Переменная X = " + value);
        Console.WriteLine("Старт шага = " + startValue);
        Console.WriteLine("Конец шага = " + stopValue);


        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");

        Console.WriteLine("Сумма ряда = " + ds.GetSumSeries(value, startValue, stopValue));


    }
}