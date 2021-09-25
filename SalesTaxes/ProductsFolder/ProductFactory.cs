using System;
using System.Collections.Generic;
using System.Text;

namespace SalesTaxes.ProductsFolder
{

    public class ProductFactory
    {
        public ProductFactory()
        {

        }
        public static Product CreateProduct(string line)
        {
            var inputArray = line.Split(' ');
            var quantity = int.Parse(inputArray[0]);
            var price = double.Parse(inputArray[^1]);
            var description = inputArray[1];
            var isImported = description.ToUpper() == "IMPORTED";                        
            for (int i = 2; i < inputArray.Length - 2; i++)
            {
                description += " " + inputArray[i];
            }
            var type = GetProductType(description);

            return new Product(quantity,price,description,isImported, type);
        }

        private static ProductType GetProductType(string description)
        {
            if (description.ToUpper().Contains("BOOK"))
                return ProductType.Book;
            else if (description.ToUpper().Contains("PILLS"))
                return ProductType.Medical;
            else if (description.ToUpper().Contains("CHOCOLATE"))
                return ProductType.Food;
            return ProductType.Other;
        }
    
}

}