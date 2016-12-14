
namespace RomanNumbersKata.UnitTests
{
    using System.Collections.Generic;

    using FluentAssertions;

    using NUnit.Framework;

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
    }

    public class RomanNumbersConverter
    {
        public static string Convert(int number)
        {
            var numbersToRoman = new Dictionary<int, string>
                                     {
                                         {1, "I"},
                                         {5, "V"},
                                     };
            if (number == 0)
            {
                return string.Empty;
            }
            if (number < 4)
            {
                return numbersToRoman[1] + Convert(number - 1);
            }
            if (number == 4)
            {
                return numbersToRoman[1] + numbersToRoman[5];
            }
            if (number < 9)
            {
                return numbersToRoman[5] + Convert(number - 5);
            }

            return "";
        }

    }
}
