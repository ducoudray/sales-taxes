using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTaxes.ReceiptFolder
{
    public interface IReceiptSource
    {
        public List<string> GetReceiptFromSource(string line);
    }
}
