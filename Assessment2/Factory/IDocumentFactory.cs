using Assessment2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment2.Factory
{
    public interface IDocumentFactory
    {
        IDocument CreateDocument();
    }
}
