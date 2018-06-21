using Number;
using System;
using Xunit;

namespace Number.Test
{
    public class ArabicTest
    {
        [Fact]
        public void Arabic_WhenConvertValue1_ShouldReturnValueI()
        {
            // Arrange
            Arabic arabic = new Arabic();
            string expected = "I";
            //Act
            string actual = arabic.ConvertToRoman(1);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
