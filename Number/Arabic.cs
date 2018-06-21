using System;

namespace Number
{
    public class Arabic
    {
        public string ConvertToRoman(int number)
        {
            string result = "";
            int tens = number / 10 % 10;
            int ones = number / 1 % 10;

            result += PlaceValues(tens, new string[] { "X", "L", "C" });
            result += PlaceValues(ones, new string[] { "I", "V", "X" });

            if (String.IsNullOrEmpty(result))
            {
                throw new ArgumentException("Value can't be converted");
            }
            return result;
        }

        private static string PlaceValues(int number, string[] symbols)
        {
            string result = "";
            if (number <= 3)
            {
                result = RepeatLiteral(number, symbols[0]);
            }
            else if (number == 4)
            {
                result = symbols[0] + symbols[1];
            }
            else if (number == 5)
            {
                result = symbols[1];
            }
            else if (number >= 6 && number <= 8)
            {
                result = symbols[1] + RepeatLiteral(number - 5, symbols[0]);
            }
            else if (number == 9)
            {
                result = symbols[0] + symbols[2];
            }
            return result;
        }

        private static string RepeatLiteral(int times, string symbol)
        {
            string result = "";
            for (int i = 0; i < times; i++)
            {
                result += symbol;
            }
            return result;
        }
    }
}
