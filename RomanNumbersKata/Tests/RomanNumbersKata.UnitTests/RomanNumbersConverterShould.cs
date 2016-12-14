
namespace RomanNumbersKata.UnitTests
{
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
            if (number == 4)
            {
                return "IV";
            }

            if (number == 5)
            {
                return "V";
            }

            if (number == 6)
            {
                return "VI";
            }

            var index = number - 1;

            var romanNumbers = new[] { "I", "II", "III" };

            return romanNumbers[index];
        }

    }
}
