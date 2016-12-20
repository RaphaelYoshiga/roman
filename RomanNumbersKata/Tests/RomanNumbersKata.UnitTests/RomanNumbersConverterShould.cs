using System.Security.Cryptography.X509Certificates;
using FluentAssertions;
using NUnit.Framework;

namespace RomanNumbersKata.UnitTests
{
    [TestFixture]
    public class RomanNumbersConverterShould
    {
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        public void ReturnRoman_WhenConverting_GivenInputIsArabic(int number, string expectedRoman)
        {
            var roman = RomanNumbersConverter.Convert(number);

            roman.Should().Be(expectedRoman);
        }

        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(7, "VII")]
        [TestCase(8, "VIII")]
        public void ReturnRoman_WhenConverting_GivenInputIsGreaterThanThree(int number, string expectedRoman)
        {
            var roman = RomanNumbersConverter.Convert(number);

            roman.Should().Be(expectedRoman);
        }

        [TestCase(9, ExpectedResult = "IX")]
        [TestCase(10, ExpectedResult = "X")]
        [TestCase(11, ExpectedResult = "XI")]
        [TestCase(12, ExpectedResult = "XII")]
        [TestCase(13, ExpectedResult = "XIII")]
        [TestCase(14, ExpectedResult = "XIV")]
        [TestCase(20, ExpectedResult = "XX")]
        [TestCase(30, ExpectedResult = "XXX")]
        public string ReturnRoman_WhenConverting_GivenInputIsGreaterThanEight(int number)
        {
            return RomanNumbersConverter.Convert(number);
        }

        [TestCase(40, ExpectedResult = "XL")]
        [TestCase(41, ExpectedResult = "XLI")]
        [TestCase(50, ExpectedResult = "L")]
        [TestCase(60, ExpectedResult = "LX")]
        [TestCase(80, ExpectedResult = "LXXX")]
        public string ReturnRoman_WhenConverting_GivenInputIsGreaterThanThirtyNine(int number)
        {
            return RomanNumbersConverter.Convert(number);
        }

        [TestCase(90, ExpectedResult = "XC")]
        [TestCase(99, ExpectedResult = "XCIX")]
        [TestCase(100, ExpectedResult = "C")]
        [TestCase(130, ExpectedResult = "CXXX")]
        public string ReturnRoman_WhenConverting_GivenInputIsGreaterThanNinety(int number)
        {
            return RomanNumbersConverter.Convert(number);
        }

        [TestCase(400, ExpectedResult = "CD")]
        [TestCase(800, ExpectedResult = "DCCC")]
        public string ReturnRoman_WhenConverting_GivenInputIsGreaterThanFourHundred(int number)
        {
            return RomanNumbersConverter.Convert(number);
        }

        [TestCase(900, ExpectedResult = "CM")]
        [TestCase(1000, ExpectedResult = "M")]
        [TestCase(1300, ExpectedResult = "MCCC")]
        public string ReturnRoman_WhenConverting_GivenInputIsGreaterThanNineHundred(int number)
        {
            return RomanNumbersConverter.Convert(number);
        }

        [TestCase(846, ExpectedResult = "DCCCXLVI")]
        [TestCase(1999, ExpectedResult = "MCMXCIX")]
        [TestCase(2008, ExpectedResult = "MMVIII")]
        public string ReturnRoman_WhenConverting_TestResults(int number)
        {
            return RomanNumbersConverter.Convert(number);
        }
    }
}
