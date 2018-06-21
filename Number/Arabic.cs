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
            else if (number == 2)
            {
                return "II";
            }
            else
            {
                return "III";
            }
            throw new NotImplementedException();
        }
    }
}
