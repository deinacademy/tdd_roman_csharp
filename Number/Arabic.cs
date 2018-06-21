using System;

namespace Number
{
    public class Arabic
    {
        public string ConvertToRoman(int number)
        {
            if (number == 1)
            {
                return "I";
            }
            else
            {
                return "II";
            }
            throw new NotImplementedException();
        }
    }
}
