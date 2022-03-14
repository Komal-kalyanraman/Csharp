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


        /// <summary>
        /// Call a REST API with GET.
        /// <summary>
        /// <param name="url">URL for the REST API</param>
        /// <returns>Returns the stringified form of the return value of the API</returns>
        public async Task<string> Get(string url)
        {
            return await Call("GET", url, new Dictionary<string, string>());
        }


        /// <summary>
        /// Call a REST API with a POST
        /// <summary>
        /// <param name="url">URL for the REST API</param>
        /// <param name="data">POST data</param>
        /// <returns>Returns the stringified form of the return value of the API</returns>
        public async Task<string> Post(string url, Dictionary<string, string> data)
        {
            return await Call("POST", url, data);
        }


        /// <summary>
        /// Call a REST API with a PUT
        /// <summary>
        /// <param name="url">URL for the REST API</param>
        /// <param name="data">PUT data</param>
        /// <returns>Returns the stringified form of the return value of the API</returns>
        public async Task<string> Put(string url, Dictionary<string, string> data)
        {
            //string key = ToString().data[0];
            //Console.WriteLine("key: value", data.Keys, data.Values);
            return await Call("PUT", url, data);
        }


        /// <summary>
        /// Call a REST API with the specified method and URL
        /// <summary>
        /// <param name="method">Method for API - POST, GET or PUT</param>
        /// <param name="url">URL for the REST API</param>
        /// <param name="data">Query data for POST, PUT and GET in the form of a dictionary</param>
        /// <returns>Returns the stringified form of the return value of the API</returns>
        private async Task<string> Call(string method, string url, Dictionary<string, string> data)
        {
            var content = new FormUrlEncodedContent(data);
            string retval = "";
            HttpResponseMessage response;


            switch (method)
            {
                case "POST":
                    response = await client.PostAsync(url, content);
                    retval = await response.Content.ReadAsStringAsync();
                    break;


                case "GET":
                    // Get does not use the data sent to us. The query parameters will have
                    // to be given along with the url: http://<server>:<port>/api?param1=hello&param2=world
                    retval = await client.GetStringAsync(url);
                    break;


                case "PUT":
                    response = await client.PutAsync(url, content);
                    retval = await response.Content.ReadAsStringAsync();
                    break;


                default:
                    retval = "ERROR";
                    break;
            }

            return retval;
        }
    }
}
