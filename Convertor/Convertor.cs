using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace Convertor {
    internal class Convertor {
        private static string AccessKey = "7b3d2592ff63cfe17482338f63ceee87";
        private readonly static string ApiLive = "http://apilayer.net/api/live";
        private readonly static string ApiConvert = "http://api.currencylayer.com/convert";
        public static async Task<string> GetVal(string valute) {
        string queryParams = $"?access_key={AccessKey}&currencies={valute}&source=USD&format=1";
            using (HttpClient client = new HttpClient())
                {
                HttpResponseMessage responseMessage = await client.GetAsync(ApiLive + queryParams);
                if(responseMessage.IsSuccessStatusCode)
                {
                    string responseData = await responseMessage.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<DeconversionDataLive>(responseData);
                    switch(valute)
                        {
                        case "EUR":
                             return data.Quotes.USDEUR.ToString();
                        case "GBP":
                             return data.Quotes.USDGBP.ToString();
                        case "CAD":
                             return data.Quotes.USDCAD.ToString();
                        case "PLN":
                             return data.Quotes.USDPLN.ToString();
                        case "RUB":
                             return data.Quotes.USDRUB.ToString();
                        default:
                             return null;
                    }
                } 
                else
                {
                    return "Error Message";
                }
            }
        }
        public static async Task<string> Convert(string valute,double amount) {
            string queryConvert = $"?access_key={AccessKey}&from=USD&to={valute}&amount={amount}&format=1";
            using (HttpClient client = new HttpClient()) {
                HttpResponseMessage responseMessage = await client.GetAsync(ApiConvert + queryConvert);
                if(responseMessage.IsSuccessStatusCode) {
                    string responseData = await responseMessage.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<DeconversionDataConvert>(responseData);
                    if(data.Success) {
                        return data.Result.ToString();
                    } else {
                        return $"Error: {data.Success.ToString()}";
                    }
                } else {
                    return "Error message";
                }
            }
        }
    }
}
