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
        [InlineData("III", 3)]
        [InlineData("IV", 4)]
        [InlineData("V", 5)]
        public void Arabic_WhenConvertIntegerValue_ShouldReturnRomanString(string expected, int value)
        {
            // Arrange
            Arabic arabic = new Arabic();
            //Act
            string actual = arabic.ConvertToRoman(value);
            //Assert
            Assert.Equal(expected, actual);
        }

        public void Arabic_WhenCantConverValue_ShouldRiseAnException()
        {
            // Arrange
            Arabic arabic = new Arabic();
            //Act
            Action actual = () => arabic.ConvertToRoman(0);
            //Assert
            Assert.Throws<ArgumentException>(actual);
        }
    }
}
