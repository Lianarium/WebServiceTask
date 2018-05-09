using RestSharp;
using System.Collections.Generic;

namespace RequestBuilderPattern
{
    public class Request
    {

       public RestClient RestClient { get; set; }

        public RestRequest RestRequest { get; set; }

        public IRestResponse RestResponse { get; set; }

        //public List<Parameter> RequestHeaders { get; set; }

        public string RequestBody { get; set; }

        public string ResponseContent { get; set; }

    }
}