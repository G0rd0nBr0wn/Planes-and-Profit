using System;
using Aletheia.Service;
using Aletheia.Service.StockData;


namespace Fetch{
    class Program{
        static void Main(string[] args){
            //only 5,000 calls a month
            AletheiaService service = new AletheiaService("7FA4842C273E480E82BBDD69723301C4");
            StockData quote = service.GetStockDataAsync("MSFT", true, true).Result;
            Console.WriteLine(quote.SummaryData.Price.ToString("#,##0.00"));
        }
    }
}