public static string AlphabetSolution(string text)
{
    string result = "";
    foreach (char c in text.ToLower())
    {
        if (c >= 'a' && c <= 'z')
        {
            int position = c - 'a' + 1;
            result += position + " ";
        }
    }
    // remove the trailing space if any
    if (result.Length > 0 && result[result.Length - 1] == ' ')
    {
        result = result.Substring(0, result.Length - 1);
    }
    return result;
}