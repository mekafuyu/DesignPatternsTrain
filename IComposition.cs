public interface IComposition
{
    double Calculate(List<Function> fs, double x);
    Function Derive(List<Function> fs);
}