namespace FunctionProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            FibonacciSeries fibonacciSeries = new FibonacciSeries();
            fibonacciSeries.Print(4);
            PerfectNumber perfectNumber = new PerfectNumber();
            perfectNumber.Check(4);
        }
    }
}