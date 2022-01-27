namespace Assessment2.Models
{
    public class CertificateOfEmployment : IDocument
    {
        public string Description { get; set; }
        public string Print()
        {
            return $"Certificate Of Employment - {Description}";
        }
    }
}
