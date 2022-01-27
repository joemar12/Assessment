namespace Assessment2.Models
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
