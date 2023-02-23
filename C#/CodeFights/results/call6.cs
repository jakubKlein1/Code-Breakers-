public static string RangeSolution(int[] args)
{
    var ranges = new List<string>();
    var currentRange = new List<int>();

    for (var i = 0; i < args.Length; i++)
    {
        currentRange.Add(args[i]);

        if (i == args.Length - 1 || args[i + 1] - args[i] != 1)
        {
            if (currentRange.Count >= 3)
            {
                ranges.Add(currentRange.First() + "-" + currentRange.Last());
            }
            else
            {
                ranges.AddRange(currentRange.Select(x => x.ToString()));
            }

            currentRange.Clear();
        }
    }

    return String.Join(",", ranges);
}