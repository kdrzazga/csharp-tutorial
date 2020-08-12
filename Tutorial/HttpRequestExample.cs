using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace Tutorial
{
    class HttpRequestExample
    {
        private static readonly HttpClient client = new HttpClient();
        private static readonly String url = "http://localhost:8081/";

        public Task<HttpResponseMessage> CreateBook(string author, string title, int publishingYear)
        {
            /*Please start webservice first*/
            var content = new FormUrlEncodedContent(new Dictionary<string, string>());
            
            var request = url + "createBook/" + author + "/" + title + "/" + publishingYear;
            var response = client.PostAsync(request, content);
            return response;
        }

        public Task<HttpResponseMessage> GetBook(int id)
        {
            /*Please start webservice first*/
            var request = url + "readBook/" + id.ToString();
            var response = client.GetAsync(request);
            return response;
        }
        /*TODO
        public Task<HttpResponseMessage> PutBook(string book)
        {
            var body = HttpContent();

            var response = client.PutAsync(url, );
            return response;
                
        }
        */
    }
}
