namespace Assessment2.Facade
{
    public class PaymentService
    {
        public Subscription ProcessPayment(string refId)
        {
            //for the sake of simplicity, just return an active subsciption
            return new Subscription() { IsActive = true };
        }
    }
}
