using System;

namespace Number
{
    public class Arabic
    {
        public string ConvertToRoman(int number)
        {
            string result = "";
            if (number <= 3)
            {
                for (int i = 0; i < number; i++)
                {
                    result += "I";
                }
            }
            else if (number == 4)
            {
                result = "IV";
            }
            else if (number == 5)
            {
                result = "V";
            }
            else if (number == 6)
            {
                result = "VI";
            }
            else if (number == 7)
            {
                result = "VII";
            }
            else
            {
                result = "VIII";
            }
            if (String.IsNullOrEmpty(result))
            {
                throw new ArgumentException("Value can't be converted");
            }
            return result;
        }
    }
}
