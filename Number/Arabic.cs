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
            else if (number >= 6 && number <= 8)
            {
                result = "V";
                for (int i = 5; i < number; i++)
                {
                    result += "I";
                }
            }
            else if (number == 9)
            {
                result = "IX";
            }
            else
            {
                result = "X";
            }
            if (String.IsNullOrEmpty(result))
            {
                throw new ArgumentException("Value can't be converted");
            }
            return result;
        }
    }
}
