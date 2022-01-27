using Assessment2.AbstractFactory;
using Assessment2.Facade;
using Assessment2.Factory;
using Assessment2.Singleton;
using System;
using Xunit;
namespace Assessment.Tests
{
    public class Assessment2Test
    {
        [Fact]
        public void Singleton_Should_Return_Same_Instance()
        {
            var instance1 = Singleton.Instance();
            var instance2 = Singleton.Instance();

            Assert.Same(instance1, instance2);
        }

        [Fact]
        public void TaxReportFactory_Should_Create_TaxReport()
        {
            var factory = new TaxReportFactory();
            var doc = factory.CreateDocument();
            Assert.IsType<TaxReport>(doc);
        }

        [Fact]
        public void CertificateOfBirthFactory_Should_Create_CertificateOfBirth()
        {
            var factory = new CertificateOfBirthFactory();
            var doc = factory.CreateDocument();
            Assert.IsType<CertificateOfBirth>(doc);
        }

        [Fact]
        public void CertificateOfEmploymentFactory_Should_Create_CertificateOfEmployment()
        {
            var factory = new CertificateOfEmploymentFactory();
            var doc = factory.CreateDocument();
            Assert.IsType<CertificateOfEmployment>(doc);
        }

        [Fact]
        public void MilkywayCelestialBodyFactory_Should_Create_RedDwarf_And_GasGiant()
        {
            var client = new CelestialBodyClient(new MilkywayCelestialBodyFactory());
            var star = client.GetStar();
            var planet = client.GetPlanet();
            Assert.IsType<GasGiant>(planet);
            Assert.IsType<RedDwarf>(star);
        }

        [Fact]
        public void AndromedaCelestialBodyFactory_Should_Create_NeutronStar_And_SuperEarth()
        {
            var client = new CelestialBodyClient(new AndromedaCelestialBodyFactory());
            var star = client.GetStar();
            var planet = client.GetPlanet();
            Assert.IsType<SuperEarth>(planet);
            Assert.IsType<NeutronStar>(star);
        }

        [Fact]
        public void SubscriptionService_Should_Subscribe_Customer()
        {
            var customerRepo = new CustomerRepository();
            var subscriptionService = new SubscriptionService(customerRepo, new PaymentService());
            subscriptionService.ProcessSubscription(1, "any");
            var customer = customerRepo.GetCustomer(1);
            Assert.True(customer.Subscription.IsActive);
        }
    }
}
