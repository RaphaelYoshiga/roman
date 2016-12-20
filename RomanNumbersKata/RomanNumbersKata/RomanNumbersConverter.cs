using System.Collections.Generic;
using System.Linq;

namespace RomanNumbersKata
{
    public class RomanNumbersConverter
    {
        private static Dictionary<int, string> numbersToRoman = new Dictionary<int, string>
        {
            { 1, "I"},
            { 4, "IV" },
            { 5, "V"},
            { 9, "IX"},
            { 10, "X" },
            { 40, "XL" },
            { 50, "L"},
            { 90, "XC" },
            { 100, "C" },
            { 300, "CCC" },
            { 400, "CD"},
            { 500, "D"},
            { 900, "CM" },
            { 1000, "M" }
        };

        public static string Convert(int number)
        {
            if (number == 0)
                return string.Empty;

            return BiggestIndexPlusTheRest(GetDenominator(number), number);
        }

        private static int GetDenominator(int number)
        {
            var orderedKeys = numbersToRoman.OrderByDescending(p => p.Key).Select(p => p.Key).ToArray();
            foreach (var key in orderedKeys)
            {
                if (number >= key)
                    return key;
            }
            return 0;
        }

        private static string BiggestIndexPlusTheRest(int biggestIndex, int number)
        {
            return numbersToRoman[biggestIndex] + Convert(number - biggestIndex);
        }
    }
}