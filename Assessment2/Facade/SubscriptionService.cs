namespace Assessment2.Facade
{
    // the facade class
    public class SubscriptionService : ISubscriptionService
    {
        private CustomerRepository _customerRepository;
        private PaymentService _paymentService;
        public SubscriptionService(CustomerRepository customerRepository, PaymentService paymentService)
        {
            _customerRepository = customerRepository;
            _paymentService = paymentService;
        }

        public void ProcessSubscription(int custId, string paymentRefId)
        {
            var customer = _customerRepository.GetCustomer(custId);
            if (customer != null)
            {
                var subscription = _paymentService.ProcessPayment(paymentRefId);
                customer.Subscription = subscription;
                _customerRepository.UpdateCustomer(customer);
            }
        }
    }
}
