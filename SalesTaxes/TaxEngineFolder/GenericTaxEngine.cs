using SalesTaxes.ProductsFolder;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTaxes.TaxEngineFolder
{
    public class GenericTaxEngine : ITaxEngine
    {        
        public GenericTaxEngine()
        {     
        }

        public double CalcTaxBase(Product product)
        {
            return Math.Ceiling(product.Price * 0.10 * 20) / 20;
        }

        public double CalcTaxImported(Product product)
        {
            return product.IsImported ? Math.Ceiling(product.Price * 0.05 * 20) / 20 : 0;
        }
    }
}
