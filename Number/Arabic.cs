using System;

namespace Number
{
    public class Arabic
    {
        public string ConvertToRoman(int number)
        {
            string result = "";
            for (int i = 0; i < number; i++)
            {
                result += "I";
            }
            if (String.IsNullOrEmpty(result))
            {
                throw new NotImplementedException();
            }
            return result;
        }
    }
}
