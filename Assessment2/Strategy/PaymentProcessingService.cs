namespace Assessment2.Strategy
{
    //strategy context
    public class PaymentProcessingService
    {
        IPaymentProcessor _paymentProcessor;
        public PaymentProcessingService(IPaymentProcessor paymentProcessor)
        {
            _paymentProcessor = paymentProcessor;
        }

        public string ProcessPayment()
        {
            return _paymentProcessor.Process();
        }
    }
}
