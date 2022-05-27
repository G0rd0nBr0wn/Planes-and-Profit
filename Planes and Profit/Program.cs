using System;

namespace HelloWorld{
    class Program{
        static async void Main(string[] args){
            var httpClient= new HttpClient();

            httpClient.BaseAddress = new Uri("https://yfapi.net/");
            httpClient.DefaultRequestHeaders.Add("X-API-KEY", "<your API key>");
            httpClient.DefaultRequestHeaders.Add("accept", "application/json");

            var response = await httpClient.GetAsync("v11 / finance / quoteSummary / AAPL ? lang = en & region = US & modules = defaultKeyStatistics % 2CassetProfile");
            var responseBody = await response.Content.ReadAsStringAsync();
        }
    }
}