namespace BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calculator = new SalaryCalculatorBuilder()
            .AddTaxes(10)
            .AddBonus(20)
            .AddTransportation(1000)
            .AddEducationPackage(2000)
            .Build();

            var finalSalary = calculator.Calculate(10000);
            Console.WriteLine(finalSalary);
        }
    }
}
