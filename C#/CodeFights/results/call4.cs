public static ulong[] FibonacciSolution(ulong number)
{
    ulong prev = 0, curr = 1;
    while (curr * (curr + prev) < number)
    {
        ulong temp = curr + prev;
        prev = curr;
        curr = temp;
    }
    if (curr * (curr + prev) == number)
    {
        return new ulong[] { prev, curr, true };
    }
    
    ulong lo = curr, hi = curr + prev;
    while (lo <= hi)
    {
        ulong mid = lo + (hi - lo) / 2;
        ulong prod = mid * (mid - prev);
        if (prod == number)
        {
            return new ulong[] { prev, mid, true };
        }
        else if (prod < number)
        {
            lo = mid + 1;
        }
        else
        {
            hi = mid - 1;
        }
    }
    return new ulong[] { hi, lo, false };
}
