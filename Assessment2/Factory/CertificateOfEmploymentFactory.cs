namespace Assessment2.Factory
{
    public class CertificateOfEmploymentFactory : IDocumentFactory
    {
        public IDocument CreateDocument()
        {
            return new CertificateOfEmployment();
        }
    }
}
