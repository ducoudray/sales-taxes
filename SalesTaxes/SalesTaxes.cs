using SalesTaxes.ReceiptFolder;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTaxes
{
    public class SalesTaxes
    {
        private readonly List<string> _lines;
        private Receipt _receipt;
        
        public SalesTaxes(List<string> lines)
        {
            _lines = lines;
        }

        public Receipt Apply()
        {
            _receipt = ReceiptFactory.CreateReceipt(_lines);
            return _receipt;
        }
    }
}
