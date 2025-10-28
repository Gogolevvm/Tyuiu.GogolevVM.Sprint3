using Tyuiu.GogolevVM.Sprint3.Task7.V14.Lib;
internal class Program
{
    private static void Main(string[] args)
    {

        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил: Гоголев В.М | АСОиУБ-25-1";
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* Спринт #3                                                                                *");
        Console.WriteLine("* Тема:Добавление к решению итоговых проектов по спринту                 м                 *");
        Console.WriteLine("* Задание #7                                                                               *");
        Console.WriteLine("* Вариант #14                                                                              *");
        Console.WriteLine("* Выполнил: Гоголев Вcеволод Михайлович | АСОиУБ-25-1                                      *");
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
        Console.WriteLine("* Напишите программу, которая выводит таблицу значений функции (произвести табулирование)  *");
        Console.WriteLine("* y = 2 * x - 4 + ((2 * x - 1) / (Sin(x) + 1)) на диапазоне [-5;5] с шагом 1               *");
        Console.WriteLine("*                                                                                          *");

        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                                          *");
        Console.WriteLine("********************************************************************************************");

        int startValue = -5;
        int stopValue = 5;



        Console.WriteLine("Старт шага  - " + startValue);
        Console.WriteLine("Конец шага  - " + stopValue);

        int len = ds.GetMassFunction(startValue, stopValue).Length;

        double[] valueArray;
        valueArray = new double[len];

        valueArray = ds.GetMassFunction(startValue, stopValue);

        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");

        Console.WriteLine("+----------+----------+");
        Console.WriteLine("|    X     |   f(X)   |");
        Console.WriteLine("+----------+----------+");
        for (int i = 0; i <= len - 1; i++)
        {
            Console.WriteLine("|{0,5:d}    |  {1,6:f2}   |", startValue, valueArray[i]);
            startValue++;
        }

        Console.WriteLine("+----------+----------+");


    }
}