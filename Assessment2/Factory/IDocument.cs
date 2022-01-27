using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment2.Factory
{
    public interface IDocument
    {
        string Description { get; set; }
        string Print();
    }
}
