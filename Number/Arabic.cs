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
            else
            {
                result = "V";
            }
            if (String.IsNullOrEmpty(result))
            {
                throw new ArgumentException("Value can't be converted");
            }
            return result;
        }
    }
}
