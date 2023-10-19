public static class Compositions
{
    private static SumComposition sum = null;
    public static SumComposition Sum
    {
        get
        {
            if (sum is null)
                sum = new();
            return sum;
        }
    }
    private static MultiComposition multi = null;
    public static MultiComposition Multi
    {
        get
        {
            if (multi is null)
                multi = new();
            return multi;
        }
    }
    private static LinearFunction line = null;
    public static LinearFunction Line
    {
        get
        {
            if (line is null)
                line = new();
            return line;
        }
    }
}