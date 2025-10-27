using Tyuiu.GogolevVM.Sprint3.Task2.V19.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил: Гоголев В.М | АСОиУБ-25-1";
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* Спринт #0                                                                                *");
        Console.WriteLine("* Тема: Оператор цикла do-while                                                            *");
        Console.WriteLine("* Задание #3                                                                               *");
        Console.WriteLine("* Вариант #19                                                                              *");
        Console.WriteLine("* Выполнил: Гоголев Вcеволод Михайлович | АСОиУБ-25-1                                      *");
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
        Console.WriteLine("* Написать программу используя цикл for, которая вычисляет сумму ряда по формуле,          *");
        Console.WriteLine("* и печатает результат на экране, вычисляет результат по формуле и печатает его на экране. *");
        Console.WriteLine("*                                                                                          *");

        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                                          *");
        Console.WriteLine("********************************************************************************************");

        
        int startValue = 1;
        int stopValue = 10;

        
        Console.WriteLine("Старт шага = " + startValue);
        Console.WriteLine("Конец шага = " + stopValue);


        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");

        Console.WriteLine("Сумма равна = " + ds.GetSumSeries( startValue, stopValue));


    }
}