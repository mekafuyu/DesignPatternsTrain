public abstract class Function
{
    public double this[double x]
        => this.compute(x);

    protected abstract double compute(double x);

    public abstract Function Derive();

    public static Function operator +(Function f, Function g)
    {
        CompositeFunction h = new CompositeFunction();
        h.Composition = Compositions.Sum;
        h.Functions.Add(f);
        h.Functions.Add(g);
        return h;
    }
    public static Function operator *(Function f, Function g)
    {
        CompositeFunction h = new CompositeFunction();
        h.Composition = Compositions.Multi;
        h.Functions.Add(f);
        h.Functions.Add(g);
        return h;
    }
    public static implicit operator Function(double x)
        => new ConstantFunction(x);
}