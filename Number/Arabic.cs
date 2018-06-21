using System;

namespace Number
{
    public class Arabic
    {
        public string ConvertToRoman(int number, Roman roman)
        {
            string result = "";
            int hundreds = number / 100 % 10;
            int tens = number / 10 % 10;
            int ones = number / 1 % 10;

            result += PlaceValues(hundreds, roman.GetSymbol("hundreds"));
            result += PlaceValues(tens, roman.GetSymbol("tens"));
            result += PlaceValues(ones, roman.GetSymbol("ones"));

            if (String.IsNullOrEmpty(result))
            {
                throw new ArgumentException("Value can't be converted");
            }
            return result;
        }

        private static string PlaceValues(int number, Symbol symbol)
        {
            string result = "";
            if (number <= 3)
            {
                result = RepeatLiteral(number, symbol.one);
            }
            else if (number == 4)
            {
                result = symbol.one + symbol.five;
            }
            else if (number == 5)
            {
                result = symbol.five;
            }
            else if (number >= 6 && number <= 8)
            {
                result = symbol.five + RepeatLiteral(number - 5, symbol.one);
            }
            else if (number == 9)
            {
                result = symbol.one + symbol.ten;
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
