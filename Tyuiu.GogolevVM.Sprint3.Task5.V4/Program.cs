using Tyuiu.GogolevVM.Sprint3.Task5.V4.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил: Гоголев В.М | АСОиУБ-25-1";
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* Спринт #3                                                                                *");
        Console.WriteLine("* Тема: Оператор цикла do-while                                                            *");
        Console.WriteLine("* Задание #5                                                                               *");
        Console.WriteLine("* Вариант #4                                                                               *");
        Console.WriteLine("* Выполнил: Гоголев Вcеволод Михайлович | АСОиУБ-25-1                                      *");
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
        Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение функции              *");
        Console.WriteLine("* y=(cos(x)/x)+3 При х = 0 прервать цикл. Полученные значения перемножать.                 *");
        Console.WriteLine("*                                                                                          *");

        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                                          *");
        Console.WriteLine("********************************************************************************************");

        int x = 5;
        int startValue1 = 1;
        int stopValue1 = 13;
        int startValue2 = 1;
        int stopValue2 = 3;

        Console.WriteLine("Переменная X = " + x);
        Console.WriteLine("Старт шага первой суммы ряда - " + startValue1);
        Console.WriteLine("Конец шага первой суммы ряда - " + stopValue1);
        Console.WriteLine("Старт шага второй суммы ряда - " + startValue2);
        Console.WriteLine("Конец шага второй суммы ряда - " + stopValue2);

        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");

        Console.WriteLine("Сумма ряда = " + ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));

    }
}