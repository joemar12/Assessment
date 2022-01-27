namespace Assessment2.Factory
{
    public class CertificateOfBirth : IDocument
    {
        public string Description { get; set; }
        public string Print()
        {
            return $"Certificate Of Birth - {Description}";
        }
    }
}
