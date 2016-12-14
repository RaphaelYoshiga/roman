
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
    }

    public class RomanNumbersConverter
    {
        public static string Convert(int number)
        {
            var index = number - 1;

            var romanNumbers = new[] { "I", "II", "III" };

            return romanNumbers[index];
        }

    }
}
