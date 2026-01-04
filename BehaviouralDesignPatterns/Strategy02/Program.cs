namespace Strategy02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var discountService = new DiscountService(new NoDiscountStrategy());
            Console.WriteLine(discountService.GetFinalPrice(50));

            discountService = new DiscountService(new PercentageDiscountStrategy());
            Console.WriteLine(discountService.GetFinalPrice(50));

            discountService = new DiscountService(new FixedDiscountStrategy());
            Console.WriteLine(discountService.GetFinalPrice(50));

        }
        
    }
}
