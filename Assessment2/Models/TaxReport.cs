namespace Assessment2.Models
{
    public class TaxReport : IDocument
    {
        public string Description { get; set; }
        public string Print()
        {
            return $"Tax Report - {Description}";
        }
    }
}
