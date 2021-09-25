using SalesTaxes.ProductsFolder;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTaxes.ReceiptFolder
{
    public class ReceiptFactory
    {
        public ReceiptFactory()
        {

        }

        public static Receipt CreateReceipt(List<string> lines) 
        {
            var receipt = new Receipt();
            lines.ForEach(line =>
               {                   
                   var product = ProductFactory.CreateProduct(line);                   
                   receipt.AddProduct(product);
               });

            return receipt;
        }

       
    }
}
