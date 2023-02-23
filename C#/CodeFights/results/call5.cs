public static int PersistenceSolution(long n)
{
    if (n < 10)
    {
        return 0;
    }
    long product = 1;
    while (n > 0)
    {
        product *= n % 10;
        n /= 10;
    }
    return 1 + PersistenceSolution(product);
}