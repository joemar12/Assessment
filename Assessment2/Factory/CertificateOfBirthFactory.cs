namespace Assessment2.Factory
{
    public class CertificateOfBirthFactory : IDocumentFactory
    {
        public IDocument CreateDocument()
        {
            return new CertificateOfBirth();
        }
    }
}
