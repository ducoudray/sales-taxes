using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTaxes.ReceiptFolder
{
    public class ReceiptSourceFromConsole : IReceiptSource
    {
        public ReceiptSourceFromConsole()
        {

        }
        public List<string> GetReceiptFromSource(string line)
        {            
            List<string> lines = new List<string>();

            while (!string.IsNullOrEmpty(line))
            {
                line = Console.ReadLine();
                if (!string.IsNullOrEmpty(line)) lines.Add(line);
            }
            return lines;
        }
    }
}
