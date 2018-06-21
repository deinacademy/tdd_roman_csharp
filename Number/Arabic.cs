using System;
using System.Text;

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
            StringBuilder result = new StringBuilder();
            result.Clear();
            if (number <= 3)
            {
                result.Append(RepeatLiteral(number, symbol.one));
            }
            else if (number == 4)
            {
                result.Append(symbol.one + symbol.five);
            }
            else if (number == 5)
            {
                result.Append(symbol.five);
            }
            else if (number >= 6 && number <= 8)
            {
                result.Append(symbol.five + RepeatLiteral(number - 5, symbol.one));
            }
            else if (number == 9)
            {
                result.Append(symbol.one + symbol.ten);
            }
            return result.ToString();
        }

        private static string RepeatLiteral(int times, string symbol)
        {
            StringBuilder result = new StringBuilder();
            result.Clear();
            for (int i = 0; i < times; i++)
            {
                result.Append(symbol);
            }
            return result.ToString();
        }
    }
}
