using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace CSHttpClient.NetworkTransfer
{
    public interface IHttpTransfer : System.IDisposable
    {
        public string TestConnection(System.String connection, System.String message);
        public TData SendRequest<TData>(Dictionary<string, object> request_body, string resourse);
    }

    public class HttpTransfer : System.Object, NetworkTransfer.IHttpTransfer
    {
        private IHttpClientFactory ClientFactory { get; set; } = default!;
        private string ConnectionPath { get; set; } = default!;
        public HttpTransfer(IHttpClientFactory factory)
        {
            ConnectionPath = ConfigurationManager.ConnectionStrings["Project"].ConnectionString;

            if (factory == null) throw new Exception("Фабрика не создана");
            this.ClientFactory = factory;
        }

        public TData SendRequest<TData>(Dictionary<string, object> request_body, string resourse)
        {
            HttpClient httpClient = ClientFactory.CreateClient();

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get, Content = JsonContent.Create(request_body),
                RequestUri = new Uri($@"{this.ConnectionPath}/{resourse}"),
            };
            using HttpResponseMessage response = httpClient.SendAsync(request).Result;
            return response.Content.ReadFromJsonAsync<TData>().Result!;
        }

        public void Dispose() { }

        [System.ObsoleteAttribute]
        public string TestConnection(string connection,  string message)
        {
            var httpClient = ClientFactory.CreateClient();
            using HttpResponseMessage response = httpClient.PostAsync(connection, new StringContent(message)).Result;

            return response.Content.ReadAsStringAsync().Result;
        }

    }
}
