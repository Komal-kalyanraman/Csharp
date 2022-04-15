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
        
        public async Task<string> Get(string url)
        {
            return await Call("GET", url, new Dictionary<string, string>());
        }

        public async Task<string> Put(string url, Dictionary<string, string> data)
        {
            string full_URL = url + "control"; 
            return await Call("PUT", full_URL, data);
        }

        private async Task<string> Call(string method, string url, Dictionary<string, string> data)
        {
            var content = new FormUrlEncodedContent(data);
            HttpResponseMessage response;

            switch (method)
            {
                case "GET":
                    retval = await client.GetStringAsync(url);
                    break;

                case "PUT":
                    response = await client.PutAsync(url, content);
                    break;

                default:
                    retval = "ERROR";
                    break;
            }
            return retval;
        }
    }
}
