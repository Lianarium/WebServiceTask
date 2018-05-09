using GETTests;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 


namespace Runner
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Post post = new Post();
            post.UserId = "1234";
            post.Id = "12345";
            post.Title = "Title1";
            post.Body = "Body1";


            JsonSerializer serializer = new JsonSerializer();
            serializer.Converters.Add(new JavaScriptDateTimeConverter());
            serializer.NullValueHandling = NullValueHandling.Ignore;
            
            StreamWriter sw = new StreamWriter(@"c:\New\json.txt");
            JsonWriter writer = new JsonTextWriter(sw);

            using (sw)
            using (writer)
            {
                serializer.Serialize(writer, post);
               
            }

            var client = new RestClient("https://jsonplaceholder.typicode.com");
            var request = new RestRequest("/posts", Method.POST);
            request.AddHeader("Connection", "Keep-Alive");
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(new { id = "123", title = "title" });
            var response = client.Execute(request);
            Console.WriteLine(response.StatusCode);
            Console.WriteLine(response.Content.ToString());
        }
    }
}
