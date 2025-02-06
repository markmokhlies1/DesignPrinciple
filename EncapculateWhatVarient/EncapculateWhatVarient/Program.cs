namespace EncapculateWhatVarient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = Pizza.Order(PizzaConstants.VegeterianPizza);
            Console.WriteLine(pizza);
            Console.ReadKey();
        }
    }
}
