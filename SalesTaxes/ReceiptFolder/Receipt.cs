
using SalesTaxes.ProductsFolder;
using SalesTaxes.TaxEngineFolder;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTaxes.ReceiptFolder
{
    public class Receipt
    {
        public IDictionary<string, Product> _products = new Dictionary<string, Product>();
        private double _total;
        private double _taxes;        
        public Receipt()
        {                        
        }

        public void AddProduct(Product product)
        {
            if (_products.ContainsKey(product.Description))
            {
                product = _products[product.Description];
                product.Quantity++;             
            }
            
            _products[product.Description] = product;
        }

        public string Print()
        {
            var result = "";
            
            foreach (KeyValuePair<string, Product> item in _products)
            {
                var taxEngine = TaxEngineFactory.CreateTaxEngine(item.Value);
                var basicTax = taxEngine.CalcTaxBase(item.Value);
                var importedTax = taxEngine.CalcTaxImported(item.Value);
                var totalItemTax = basicTax + importedTax;
                var totalItem = item.Value.Price + totalItemTax;

                _total += Math.Round(totalItem * item.Value.Quantity,2);
                _taxes += Math.Round(totalItemTax * item.Value.Quantity,2);
                result += PrintLineProduct(item.Value, totalItem) + "\n";
                
            }
            result += $"Sales Taxes: {string.Format("{0:F2}", _taxes)}\nTotal: {string.Format("{0:F2}", _total)}";
            return result;
        }        

        private string PrintLineProduct(Product product, double totalItem)
        {
            
            var quantityString = "";            
            if (product.Quantity > 1)
                quantityString = $" ({product.Quantity} @ { totalItem })";
            return $"{product.Description}: {string.Format("{0:F2}", totalItem * product.Quantity)}{quantityString}";            
        }

        
    }
}
