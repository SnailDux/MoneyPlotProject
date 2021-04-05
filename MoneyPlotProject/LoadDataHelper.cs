using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Net.Http;

namespace MoneyPlotProject
{
    public class LoadDataHelper
    {
        //zwraca Task<Money> bo tak trzeba przy asyncu, po wywolaniu mozna podstawic pod wartosc typu Money normalnie 
        //(patrz From1.cs button1_Click) w petli
        public async Task<Money> Load(int year)
        {

            string call = "https://openexchangerates.org/api/historical/" + year.ToString() + "-01-01.json?app_id=72a8ed46e61f49c09af2017a0c3dd6a5&symbols=PLN,EUR,GBP";
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(call);
            Money m = JsonConvert.DeserializeObject<Money>(response);
            return m;
        }
    }
}
