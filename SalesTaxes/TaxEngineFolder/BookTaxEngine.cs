using SalesTaxes.ProductsFolder;
using System;


namespace SalesTaxes.TaxEngineFolder
{
    public class BookTaxEngine : ITaxEngine
    {
        //private Product _product;
        public BookTaxEngine()
        {            
        }

        public double CalcTaxBase(Product product)
        {
            return 0;
        }

        public double CalcTaxImported(Product product)
        {
            return product.IsImported?Math.Ceiling(product.Price * 0.05 * 20) / 20  : 0;
        }
    }
}
