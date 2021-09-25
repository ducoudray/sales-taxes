using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalesTaxes.ProductsFolder;
using SalesTaxes.ReceiptFolder;
using SalesTaxes.TaxEngineFolder;



namespace SalesTaxes.Test
{
    [TestClass]
    public class SalesTaxesShould
    {
        [TestMethod]        
        [DataRow("1 Book at 12.49\n1 Book at 12.49\n1 Music CD at 14.99\n1 Chocolate bar at 0.85", "Book: 24.98 (2 @ 12.49)\nMusic CD: 16.49\nChocolate bar: 0.85\nSales Taxes: 1.50\nTotal: 42.32")]
        [DataRow("1 Imported box of chocolates at 10.00\n1 Imported bottle of perfume at 47.50", "Imported box of chocolates: 10.50\nImported bottle of perfume: 54.65\nSales Taxes: 7.65\nTotal: 65.15")]
        [DataRow("1 Imported bottle of perfume at 27.99\n1 Bottle of perfume at 18.99\n1 Packet of headache pills at 9.75\n1 Imported box of chocolates at 11.25\n1 Imported box of chocolates at 11.25", "Imported bottle of perfume: 32.19\nBottle of perfume: 20.89\nPacket of headache pills: 9.75\nImported box of chocolates: 23.70 (2 @ 11.85)\nSales Taxes: 7.30\nTotal: 86.53")]
        public void ReceiptTest(string input, string output)
        {            
            var _receiptSource = new ReceiptSourceFromTest();
            var salesTaxes = new SalesTaxes(_receiptSource.GetReceiptFromSource(input));
            var receipt = salesTaxes.Apply();
            var result = receipt.Print();
            Assert.IsTrue(result == output);            
        }
        [TestMethod]
        [DataRow("2 Book at 12.49", "Book: 24.98 (2 @ 12.49)")]
        [DataRow("1 Music CD at 5.60", "Music CD: 6.20")]
        [DataRow("1 Chocolate bar at 0.85", "Chocolate bar: 0.85")]
        [DataRow("1 Imported box of chocolates at 10.00", "Imported box of chocolates: 10.50")]
        [DataRow("1 Imported bottle of perfume at 47.50", "Imported bottle of perfume: 54.65")]
        [DataRow("1 Imported bottle of perfume at 27.99", "Imported bottle of perfume: 32.19")]
        [DataRow("1 Bottle of perfume at 18.99", "Bottle of perfume: 20.89")]
        [DataRow("3 Imported box of chocolates at 11.25", "Imported box of chocolates: 35.55 (3 @ 11.85)")]
        [DataRow("1 Packet of headache pills at 9.75", "Packet of headache pills: 9.75")]
        [DataRow("1 Packet of headache pills at 9.75", "Packet of headache pills: 9.75")]
        public void ProductTest(string input, string output)
        {
            var product = ProductFactory.CreateProduct(input);
            var taxEngine = TaxEngineFactory.CreateTaxEngine(product);
            var basicTax = taxEngine.CalcTaxBase(product);
            var importedTax = taxEngine.CalcTaxImported(product);
            var totalItemTax = basicTax + importedTax;
            var totalItem = product.Price + totalItemTax;
            var result = product.PrintProductLine(totalItem);
            Assert.IsTrue(result == output);
        }

        
    }

    
}
