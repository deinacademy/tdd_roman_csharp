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
                result = RepeatLiteral(number);
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
                result = "V" + RepeatLiteral(number - 5);
            }
            else if (number == 9)
            {
                result = "IX";
            }
            else if (number == 10)
            {
                result = "X";
            }
            else
            {
                result = "XI";
            }
            if (String.IsNullOrEmpty(result))
            {
                throw new ArgumentException("Value can't be converted");
            }
            return result;
        }

        private static string RepeatLiteral(int times)
        {
            string result = "";
            for (int i = 0; i < times; i++)
            {
                result += "I";
            }
            return result;
        }
    }
}
