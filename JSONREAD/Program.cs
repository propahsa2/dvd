// See https://aka.ms/new-console-template for more information
using JSONREAD;
using System.Net.Http;
using System.Text.Json;

//Console.WriteLine("Hello, World!");
//string text = "C:\\Users\\student\\Documents\\ISP20\\Vtitbid.ISP20.Sava\\JSONREAD\\responseHHru.json";
//string jsonstring = File.ReadAllText(text);
//Info? info = JsonSerializer.Deserialize<Info>(jsonstring);
HttpClient client = new HttpClient();
var httpResponse = await client.GetAsync("http://opendata.trudvsem.ru/api/v1/vacancies/region/6100000000000", HttpCompletionOption.ResponseContentRead); // hh https://api.hh.ru/vacancies?area=1535 // труд всем http://opendata.trudvsem.ru/api/v1/vacancies/region/6100000000000
var content = httpResponse.Content.ReadAsStringAsync() ;

Console.WriteLine(content.Result);
