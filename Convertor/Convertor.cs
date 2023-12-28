using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace Convertor {
    internal class Convertor {
        private static string accessKey = "7b3d2592ff63cfe17482338f63ceee87";
        private static string apiUrl = "http://apilayer.net/api/live";
        public static async Task<string> GetVal(string valute) {
        string queryParams = $"?access_key={accessKey}&currencies={valute}&source=USD&format=1";
            using (HttpClient client = new HttpClient())
                {
                HttpResponseMessage responseMessage = await client.GetAsync(apiUrl + queryParams);
                if(responseMessage.IsSuccessStatusCode)
                {
                    string responseData = await responseMessage.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<DeconversionData>(responseData);
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
    }
}
