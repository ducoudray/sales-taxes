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
            Console.WriteLine("Hi welcome the the Sales Taxes program");
            Console.WriteLine("Please enter your Sales Lines");
            Console.WriteLine("At the end just hit enter to execute the sales program");
            while (!string.IsNullOrEmpty(line))
            {
                line = Console.ReadLine();
                if (!string.IsNullOrEmpty(line)) lines.Add(line);
            }
            return lines;
        }
    }
}
