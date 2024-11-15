using tyuiu.cources.programming.interfaces.Sprint1;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.MasalimovTR.Sprint1.Task6.V18.Lib
{
    public class DataService: ISprint1Task6V18
    {
        public bool CheckNumber(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return false;
            }

            foreach (char x in value)
            {
                if (!char.IsDigit(x))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
