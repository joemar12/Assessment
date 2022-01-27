using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment2.Facade
{
    public interface ISubscriptionService
    {
        void ProcessSubscription(int custId, string paymentRefId);
    }
}
