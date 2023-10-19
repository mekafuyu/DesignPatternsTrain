public interface IAggregation
{
    double Calculate(Function f, double d);
    Function Derive(Function f);
}
