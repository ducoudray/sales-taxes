using SalesTaxes.ProductsFolder;

namespace SalesTaxes
{
    public interface ITaxEngine
    {      

        public double CalcTaxImported(Product product);
        //{
        //    return Math.Ceiling(product.Price * 0.05 * 20) / 20;            
        //}
        public double CalcTaxBase(Product product);
        //{
        //    return Math.Ceiling(product.Price * 0.10 * 20) / 20;
        //}
    }
}
