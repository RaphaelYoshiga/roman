
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
        [TestCase(50, ExpectedResult = "L")]
        [TestCase(60, ExpectedResult = "LX")]
        public string ReturnRoman_WhenConverting_GivenInputIsGreaterThanThirtyNine(int number)
        {
            return RomanNumbersConverter.Convert(number);
        }
    }

    public class RomanNumbersConverter
    {
        private static Dictionary<int, string> numbersToRoman = new Dictionary<int, string>
                                     {
                                         { 1, "I"},
                                         { 5, "V"},
                                         { 10, "X" },
                                         { 50, "L"}
                                     };

        public static string Convert(int number)
        {
            if (number == 0)
                return string.Empty;
            if (number < 4)
                return BiggestIndexPlusTheRest(1, number);

            if (number == 4)
                return numbersToRoman[1] + numbersToRoman[5];

            if (number < 9)
                return BiggestIndexPlusTheRest(5, number);

            if (number == 9)
                return numbersToRoman[1] + numbersToRoman[10];

            if (number < 39)
                return BiggestIndexPlusTheRest(10, number);

            if (number == 40)
                return "XL";

            return BiggestIndexPlusTheRest(50, number);
        }

        private static string BiggestIndexPlusTheRest(int biggestIndex, int number)
        {
            return numbersToRoman[biggestIndex] + Convert(number - biggestIndex);
        }
    }
}
