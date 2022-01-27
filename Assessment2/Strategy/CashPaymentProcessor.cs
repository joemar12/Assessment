namespace Assessment2.Strategy
{
    //concrete strategy
    public class CashPaymentProcessor : IPaymentProcessor
    {
        public string Process()
        {
            return "Paid with cash";
        }
    }
}
