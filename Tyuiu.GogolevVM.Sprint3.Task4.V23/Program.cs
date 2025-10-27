using Tyuiu.GogolevVM.Sprint3.Task4.V23.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил: Гоголев В.М | АСОиУБ-25-1";
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* Спринт #0                                                                                *");
        Console.WriteLine("* Тема: Оператор цикла do-while                                                            *");
        Console.WriteLine("* Задание #4                                                                               *");
        Console.WriteLine("* Вариант #23                                                                               *");
        Console.WriteLine("* Выполнил: Гоголев Вcеволод Михайлович | АСОиУБ-25-1                                      *");
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
        Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение функции              *");
        Console.WriteLine("* y=(cos(x)/x)+3 При х = 0 прервать цикл. Полученные значения перемножать.                 *");
        Console.WriteLine("*                                                                                          *");

        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                                          *");
        Console.WriteLine("********************************************************************************************");

        int startValue = -5;
        int stopValue = 5;

        Console.WriteLine("Старт шага = " + startValue);
        Console.WriteLine("Конец шага = " + stopValue);


        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");

        Console.WriteLine("Сумма ряда" + ds.Calculate(startValue, stopValue));

    }
}