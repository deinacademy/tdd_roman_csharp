using Number;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Number.Tests
{
    public class ArabicTest
    {
        public Roman _roman = new Roman();
        public ArabicTest()
        {
            _roman.AddPlaceValue("ones", new Symbol("I", "V", "X"));
            _roman.AddPlaceValue("tens", new Symbol("X", "L", "C"));
            _roman.AddPlaceValue("hundreds", new Symbol("C", "D", "M"));
        }

        [Theory]
        [InlineData("I", 1)]
        [InlineData("II", 2)]
        [InlineData("III", 3)]
        [InlineData("IV", 4)]
        [InlineData("V", 5)]
        [InlineData("VI", 6)]
        [InlineData("VII", 7)]
        [InlineData("VIII", 8)]
        [InlineData("IX", 9)]
        [InlineData("X", 10)]
        [InlineData("XI", 11)]
        [InlineData("XX", 20)]
        [InlineData("LVIII", 58)]
        [InlineData("C", 100)]
        [InlineData("D", 500)]
        [InlineData("CMXCVIII", 998)]
        public void Arabic_WhenConvertIntegerValue_ShouldReturnRomanString(string expected, int value)
        {
            // Arrange
            Arabic arabic = new Arabic();
            //Act
            string actual = arabic.ConvertToRoman(value, _roman);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Arabic_WhenCantConvertValue_ShouldRiseAnException()
        {
            // Arrange
            Arabic arabic = new Arabic();
            //Act
            Action actual = () => arabic.ConvertToRoman(0, _roman);
            //Assert
            Assert.Throws<ArgumentException>(actual);
        }
    }
}
