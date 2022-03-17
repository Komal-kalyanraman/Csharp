using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD_Day6
{
    public class Http
    {
        private static readonly HttpClient client = new HttpClient();
        public string retval = "";        
        DataCollection SensorData = new DataCollection();

        public async Task<string> Get(string url)
        {
            return await Call("GET", url, new Dictionary<string, string>());
        }

        public async Task<string> Post(string url, Dictionary<string, string> data)
        {
            return await Call("POST", url, data);
        }

        public async Task<string> Put(string url, Dictionary<string, string> data)
        {
            string full_URL = url + "control"; 
            //string key = ToString().data[0];
            //Console.WriteLine("key: value", data.Keys, data.Values);
            return await Call("PUT", full_URL, data);
        }

        private async Task<string> Call(string method, string url, Dictionary<string, string> data)
        {
            var content = new FormUrlEncodedContent(data);
            HttpResponseMessage response;

            switch (method)
            {
                case "POST":
                    response = await client.PostAsync(url, content);
                    retval = await response.Content.ReadAsStringAsync();
                    break;


                case "GET":
                    SensorData.SensorValue = await client.GetStringAsync(url);
                    Console.WriteLine(SensorData.SensorValue);
                    break;


                case "PUT":
                    response = await client.PutAsync(url, content);
                    //retval = await response.Content.ReadAsStringAsync();
                    break;

                default:
                    retval = "ERROR";
                    break;
            }
            return retval;
        }
    }
}
