using Assessment2.Models;

namespace Assessment2.Factory
{
    public class TaxReportFactory : IDocumentFactory
    {
        public IDocument CreateDocument()
        {
            return new TaxReport();
        }
    }
}
