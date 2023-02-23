public static class RomanNumeralConverter
{
    private static readonly string[] RomanNumerals =
    {
        "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"
    };

    private static readonly int[] DecimalValues =
    {
        1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1
    };

    public static string ConvertToRoman(int number)
    {
        if (number < 1 || number > 3999)
        {
            throw new ArgumentOutOfRangeException(nameof(number), "Roman numerals can only represent integers between 1 and 3999.");
        }

        var result = new StringBuilder();

        for (var i = 0; i < RomanNumerals.Length; i++)
        {
            while (number >= DecimalValues[i])
            {
                result.Append(RomanNumerals[i]);
                number -= DecimalValues[i];
            }
        }

        return result.ToString();
    }

    public static int ConvertFromRoman(string romanNumeral)
    {
        if (string.IsNullOrEmpty(romanNumeral))
        {
            throw new ArgumentException("Input string cannot be null or empty.", nameof(romanNumeral));
        }

        romanNumeral = romanNumeral.ToUpperInvariant();

        var result = 0;
        var i = 0;

        while (i < romanNumeral.Length)
        {
            var currentSymbol = romanNumeral[i];

            if (!IsRomanNumeral(currentSymbol))
            {
                throw new ArgumentException($"Invalid character '{currentSymbol}' in input string.", nameof(romanNumeral));
            }

            var currentDecimalValue = GetDecimalValue(currentSymbol);

            if (i == romanNumeral.Length - 1 || currentDecimalValue >= GetDecimalValue(romanNumeral[i + 1]))
            {
                result += currentDecimalValue;
                i++;
            }
            else
            {
                result += GetDecimalValue(romanNumeral[i + 1]) - currentDecimalValue;
                i += 2;
            }
        }

        if (result < 1 || result > 3999)
        {
            throw new ArgumentOutOfRangeException(nameof(romanNumeral), "Roman numerals can only represent integers between 1 and 3999.");
        }

        return result;
    }

    private static bool IsRomanNumeral(char symbol)
    {
        return symbol switch
        {
            'I' => true,
            'V' => true,
            'X' => true,
            'L' => true,
            'C' => true,
            'D' => true,
            'M' => true,
            _ => false
        };
    }

    private static int GetDecimalValue(char symbol)
    {
        return symbol switch
        {
            'I' => 1,
            'V' => 5,
            'X' => 10,
            'L' => 50,
            'C' => 100,
            'D' => 500,
            'M' => 1000,
            _ => throw new ArgumentException($"Invalid character '{symbol}' in input string.")
        };
    }
}
