public static int ConvertFromRoman(string romanNumeral)
{
    if (string.IsNullOrEmpty(romanNumeral)) // handle empty input
        throw new ArgumentException("Input cannot be null or empty.", nameof(romanNumeral));

    var romanDict = new Dictionary<string, int>()
    {
        { "M", 1000 },
        { "CM", 900 },
        { "D", 500 },
        { "CD", 400 },
        { "C", 100 },
        { "XC", 90 },
        { "L", 50 },
        { "XL", 40 },
        { "X", 10 },
        { "IX", 9 },
        { "V", 5 },
        { "IV", 4 },
        { "I", 1 }
    };

    var result = 0;
    var i = 0;
    while (i < romanNumeral.Length)
    {
        if (i + 1 < romanNumeral.Length && romanDict.TryGetValue(romanNumeral.Substring(i, 2), out var value))
        {
            result += value;
            i += 2;
        }
        else if (romanDict.TryGetValue(romanNumeral.Substring(i, 1), out var value))
        {
            result += value;
            i += 1;
        }
        else
        {
            throw new ArgumentException("Input is not a valid Roman numeral.", nameof(romanNumeral));
        }
    }
    return result;
}
