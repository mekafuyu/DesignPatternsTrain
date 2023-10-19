
public class SumComposition : IComposition
{
    public double Calculate(List<Function> fs, double x)
    {
        double sum = 0;
        foreach (Function f in fs)
            sum += f[x];
        return sum;            
    }

    public Function Derive(List<Function> fs)
    {
        CompositeFunction g = new CompositeFunction();
        g.Composition = new SumComposition();
        foreach (Function function in fs)
            g.Functions.Add(function.Derive());
        return g;
    }
}