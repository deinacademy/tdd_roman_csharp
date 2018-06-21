using Number;
using System;
using Xunit;

namespace Number.Test
{
    public class ArabicTest
    {
        [Theory]
        [InlineData("I", 1)]
        [InlineData("II", 2)]
        public void Arabic_WhenConvertIntegerValue_ShouldReturnRomanString(string expected, int value)
        {
            // Arrange
            Arabic arabic = new Arabic();
            //Act
            string actual = arabic.ConvertToRoman(value);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
