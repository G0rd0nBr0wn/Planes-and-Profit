using System;

namespace HelloWorld{
    class Program{
        static void Main(string[] args){
            var httpClient= new HttpClient();
            httpClient.BaseAddress = new Uri("https://yfapi.net/");

        }
    }
}