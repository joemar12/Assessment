namespace Assessment2.Strategy
{
    //concrete strategy
    public class CardPaymentProcessor : IPaymentProcessor
    {
        public string Process()
        {
            return "Paid with card";
        }
    }
}
