using SalesTaxes.ProductsFolder;

namespace SalesTaxes
{
    public interface ITaxEngine
    {        
        public double CalcTaxImported(Product product);
        public double CalcTaxBase(Product product);
    }
}
