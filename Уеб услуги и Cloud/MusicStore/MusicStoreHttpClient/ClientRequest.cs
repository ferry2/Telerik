namespace MusicStoreHttpClient
{
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using Newtonsoft.Json.Linq;

    public class ClientRequest
    {
        static readonly HttpClient Client = new HttpClient();

        public ClientRequest(string baseUrl)
        {
            this.BaseUrl = baseUrl;
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private string BaseUrl { get; set; }

        public string CreateAsJson<T>(T obj, string controller)
        {
            var sent = Client.PostAsJsonAsync(BaseUrl + controller, obj).Result;

            return sent.Content.ReadAsStringAsync().Result;
        }

        public string CreateAsXml<T>(T obj, string controller)
        {
            var sent = Client.PostAsXmlAsync(BaseUrl + controller, obj).Result;

            return sent.Content.ReadAsStringAsync().Result;
        }

        public string Read(string controller)
        {
            var recieved = Client.GetAsync(BaseUrl + controller).Result;

            var recievedString = recieved.Content.ReadAsStringAsync().Result;

            JArray jsonArray = JArray.Parse(recievedString);

            return JsonArrayToString(jsonArray);
        }

        public string Read(string controller, string id)
        {
            var recieved = Client.GetAsync(BaseUrl + controller + "/" + id).Result;

            var recievedString = recieved.Content.ReadAsStringAsync().Result;

            JObject json = JObject.Parse(recievedString);

            return JsonObjectToString(json);
        }

        public string Delete(string controller, string id)
        {
            var recieved = Client.DeleteAsync(BaseUrl + controller + "/" + id).Result;

            var recievedString = recieved.Content.ReadAsStringAsync().Result;

            JObject json = JObject.Parse(recievedString);

            return JsonObjectToString(json);
        }

        public string UpdateAsJson<T>(T obj, string controller, string id)
        {
            string reqUrl = BaseUrl + controller + "/" + id;

            var sent = Client.PutAsJsonAsync(reqUrl, obj).Result;

            return sent.Content.ReadAsStringAsync().Result;
        }

        public string UpdateAsXml<T>(T obj, string controller, string id)
        {
            string reqUrl = BaseUrl + controller + "/" + id;

            var sent = Client.PutAsXmlAsync(reqUrl, obj).Result;

            return sent.Content.ReadAsStringAsync().Result;
        }

        private static string JsonObjectToString(JObject obj)
        {
            StringBuilder resultBuilder = new StringBuilder();
            resultBuilder.AppendLine("  {");
            foreach (var pair in obj)
            {
                resultBuilder.AppendFormat("    {0}: {1}\n", pair.Key, pair.Value);
            }
            resultBuilder.AppendLine("  }");

            return resultBuilder.ToString();
        }

        private static string JsonArrayToString(JArray jsonArray)
        {
            StringBuilder resultBuilder = new StringBuilder();
            resultBuilder.AppendLine("[");
            
            foreach (JObject obj in jsonArray)
            {
                resultBuilder.AppendLine("  {");
                foreach (var pair in obj)
                {
                    resultBuilder.AppendFormat("    {0}: {1}\n", pair.Key, pair.Value);
                }
                resultBuilder.AppendLine("  },");
            }

            resultBuilder.Length -= 3;

            resultBuilder.AppendLine("\n]");

            return resultBuilder.ToString();
        }
    }
}
