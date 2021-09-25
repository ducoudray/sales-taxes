using SalesTaxes.ReceiptFolder;
using System;
using System.Collections.Generic;

namespace SalesTaxes
{
    class Program
    {

        static void Main(string[] args)
        {

            var _receiptSource = new ReceiptSourceFromConsole();
            var salesTaxes = new SalesTaxes(_receiptSource.GetReceiptFromSource("Hi"));
            var _receipt = salesTaxes.Apply();

            Console.WriteLine(_receipt.Print());
            
        
        }
    }
}
