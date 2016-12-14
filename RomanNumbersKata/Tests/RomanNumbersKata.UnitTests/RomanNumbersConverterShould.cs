
namespace RomanNumbersKata.UnitTests
{
    using FluentAssertions;

    using NUnit.Framework;

    [TestFixture]
    public class RomanNumbersConverterShould
    {
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        public void ReturnI_WhenConverting_GivenInputIs1(int number, string expectedRoman)
        {
            var roman = RomanNumbersConverter.Convert(number);

            roman.Should().Be(expectedRoman);
        }        
    }

    public class RomanNumbersConverter
    {
        public static string Convert(int number)
        {
            if (number == 2)
            {
                return "II";
            }

            return "I";
        }
    }
}
