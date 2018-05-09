using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestBuilderPattern
{
   public class DataSource
    {
        private static string url = "https://jsonplaceholder.typicode.com";

        private static string resource = "/posts";

        private static Method method = Method.POST;

        public static string Url { get => url; set => url = value; }

        public static string Resource { get => resource; set => resource = value; }

        public static Method Method { get => method; set => method = value; }
    }
    
}
