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


        //private bool isTaxable()
        //{
        //    return Type == System.Type.Other;
        //}
        //private double CalcTax()
        //{
        //    if (_isImported)
        //        _importedTax += Math.Ceiling(Price * 0.05 * 20) / 20;
        //    return _importedTax + _basicTax;
        //}
        //public void CalcTotal()
        //{
        //    var tax = CalcTax();            
        //    Total = Math.Round((tax + Price)*Quantity,2);
        //    _totalTax = tax * Quantity;
        //}

        //public string PrintLineProduct()
        //{
        //    var quantityString = "";
        //    if (Quantity > 1)
        //        quantityString = $" ({ Quantity} @ { Math.Round(Price + _basicTax + _importedTax, 2)})";
        //    return $"{Description}: {string.Format("{0:F2}", Total)}{quantityString}";
        //}


    }
}
