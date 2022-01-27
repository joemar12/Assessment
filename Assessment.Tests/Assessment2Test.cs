using Assessment2.Factory;
using Assessment2.Models;
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
    }
}
