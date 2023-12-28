using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Convertor {
    internal class Program {
        static async Task Main(string[] args) {
            string result;
            while(true) {
            Console.Clear();
            Console.WriteLine($"1)Курс доллара к евро");
            Console.WriteLine($"2)Курс доллара к фунтам стерлинга");
            Console.WriteLine($"3)Курс доллара к канадскому доллару");
            Console.WriteLine($"4)Курс доллара к польскому злоту");
            Console.WriteLine($"5)Курс доллара к российскому рублю");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch(choose) {
                case 1:
                    Console.Clear();
                    result = await Convertor.GetVal("EUR");
                    Console.Write("1$ = ");
                    await Console.Out.WriteLineAsync(result + " EUR");
                    Console.WriteLine("ENTER чтобы выйти");
                    while(Console.ReadKey().Key != ConsoleKey.Enter);
                break;
                case 2:
                    Console.Clear();
                    result = await Convertor.GetVal("GBP");
                    Console.Write("1$ = ");
                    await Console.Out.WriteLineAsync(result + " GBP");
                    Console.WriteLine("ENTER чтобы выйти");
                    while(Console.ReadKey().Key != ConsoleKey.Enter) ;
                break;
                case 3:
                    Console.Clear();
                    result = await Convertor.GetVal("CAD");
                    Console.Write("1$ = ");
                    await Console.Out.WriteLineAsync(result + " CAD");
                    Console.WriteLine("ENTER чтобы выйти");
                    while(Console.ReadKey().Key != ConsoleKey.Enter) ;
                break;
                case 4:
                    Console.Clear();
                    result = await Convertor.GetVal("PLN");
                    Console.Write("1$ = ");
                    await Console.Out.WriteLineAsync(result + " PLN");
                    Console.WriteLine("ENTER чтобы выйти");
                    while(Console.ReadKey().Key != ConsoleKey.Enter) ;
                break;
                case 5:
                    Console.Clear();
                    result = await Convertor.GetVal("RUB");
                    Console.Write("1$ = ");
                    await Console.Out.WriteLineAsync(result + " RUB");
                    Console.WriteLine("ENTER чтобы выйти");
                    while(Console.ReadKey().Key != ConsoleKey.Enter) ;
                break;
                default:
                break;
            }
            }
        }
        /*
        static async Task Request() {
            string apiKey = "7b3d2592ff63cfe17482338f63ceee87";
            string apiUrl = "http://api.currencylayer.com/live?access_key=7b3d2592ff63cfe17482338f63ceee87";
            using(HttpClient client = new HttpClient()) {
                client.DefaultRequestHeaders.Add("Autorization",$"Bearer{apiKey}");
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if(response.IsSuccessStatusCode) {
                    string responseData = await response.Content.ReadAsStringAsync();
                    Console.Write(responseData);
                } else {
                    Console.WriteLine($"Ошибка: {response.StatusCode}");
                }
            }
        }
        static void Main() {
            Request();
        }
        */
    }
}
