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
            else
            {
                result = "IV";
            }
            if (String.IsNullOrEmpty(result))
            {
                throw new NotImplementedException();
            }
            return result;
        }
    }
}
