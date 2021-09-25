namespace SalesTaxes.ProductsFolder
{
   
   
    public class Product
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        
        public bool IsImported;

        public ProductType Type;
        public Product(int quantity, double price, string description, bool isImported, ProductType type)
        {
            Quantity = quantity;
            Price = price;
            Description = description;
            IsImported = isImported;
            Type = type;
        }      

        public string PrintProductLine(double totalItem)
        {
            var quantityString = "";
            if (Quantity > 1)
                quantityString = $" ({Quantity} @ { totalItem })";
            return $"{Description}: {string.Format("{0:F2}", totalItem * Quantity)}{quantityString}";            
        }
    }
}
