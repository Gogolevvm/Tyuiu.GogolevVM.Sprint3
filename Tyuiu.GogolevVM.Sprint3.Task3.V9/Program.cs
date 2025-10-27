using Tyuiu.GogolevVM.Sprint3.Task3.V9.Lib;
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
        Console.WriteLine("* Вариант #9                                                                              *");
        Console.WriteLine("* Выполнил: Гоголев Вcеволод Михайлович | АСОиУБ-25-1                                      *");
        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
        Console.WriteLine("* Используя цикл foreach заменить цифры на букву w в строке: 56hy vfe4r4 vf45b             *");
        Console.WriteLine("*                                                                                          *");
        Console.WriteLine("*                                                                                          *");

        Console.WriteLine("********************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                                          *");
        Console.WriteLine("********************************************************************************************");

        string str = "56hy vfe4r4 vf45b";
        char chr = 'w';

        Console.WriteLine("Исходная строка:" + str);
        Console.WriteLine("Исходная буква" + chr);

        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");

        Console.WriteLine("Вышло:" + ds.ReplaceNumOnChar(str,chr));

    }
}