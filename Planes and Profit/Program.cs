using System;
using Aletheia.Service;
using Aletheia.Service.StockData;


namespace Fetch {
    class Program {
        //only 5,000 requests a month
        static void Main(string[] args) {
            GetStock("MSFT");
            
        }
        static AletheiaService CallApi(){
            // Aletheia is called
            AletheiaService service = new AletheiaService("7FA4842C273E480E82BBDD69723301C4");
            return service;
        }
        static void GetStock(string stockCode) {
            AletheiaService service = CallApi();
            try {
                //request is made
                StockData quote = service.GetStockDataAsync(stockCode, true, true).Result;
                Console.WriteLine(quote.SummaryData.Name);
            }
            catch (Exception ex) {
                //the error thrown will be an outside code error
                Console.WriteLine(ex.Message);
            }
        }
    }   
}        
