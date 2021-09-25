using SalesTaxes.ProductsFolder;


namespace SalesTaxes.TaxEngineFolder
{
    public class TaxEngineFactory
    {
        public TaxEngineFactory()
        {

        }

        public static ITaxEngine CreateTaxEngine(Product product)
        {
            if (product.Type == ProductType.Book) return new BookTaxEngine();
            if (product.Type == ProductType.Medical) return new MedicalTaxEngine();
            if (product.Type == ProductType.Food) return new FoodTaxEngine();
            return new GenericTaxEngine();
        }
    }
}
