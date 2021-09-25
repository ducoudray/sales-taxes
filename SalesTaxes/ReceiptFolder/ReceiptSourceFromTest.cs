using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTaxes.ReceiptFolder
{
    public class ReceiptSourceFromTest : IReceiptSource
    {
        public ReceiptSourceFromTest()
        {

        }
        public List<string> GetReceiptFromSource(string line)
        {
            return new List<string>(line.Split('\n'));             
        }
    }
}
