using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.GogolevVM.Sprint3.Task3.V9.Lib
{
    public class DataService : ISprint3Task3V9
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            string result = "";
            foreach (char chr in value)
            {
                if (Char.IsDigit(chr))
                {
                    value = value.Replace(chr, item);
                    result = value;
                }
            }
            return result;
        }
    }
}
