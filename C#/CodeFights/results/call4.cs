using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        ulong number = ulong.Parse(Console.ReadLine());

        ulong[] result = FibonacciSolution(number);

        if (result[2])
        {
            Console.WriteLine("{0} = {1} * {2}", number, result[0], result[1]);
        }
        else
        {
            Console.WriteLine("{0} = {1} * {2}", number, result[0], result[1]);
            Console.WriteLine("{0} * {1} = {2} > {3}", result[0], result[1], result[0] * result[1], number);
        }
    }

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
        // binary search to find the smallest i such that F(i)*F(i+1) > number
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
}
