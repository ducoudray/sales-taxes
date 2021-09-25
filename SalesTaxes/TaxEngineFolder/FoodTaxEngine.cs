using SalesTaxes.ProductsFolder;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTaxes.TaxEngineFolder
{
    public class FoodTaxEngine : ITaxEngine
    {        
        public FoodTaxEngine()
        {            
        }

        public double CalcTaxBase(Product product)
        {
            return 0;
        }

        public double CalcTaxImported(Product product)
        {
            return product.IsImported ? Math.Ceiling(product.Price * 0.05 * 20) / 20 : 0;
        }
    }
}
