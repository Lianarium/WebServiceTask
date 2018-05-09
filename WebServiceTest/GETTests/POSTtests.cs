using NUnit.Framework;
using RequestBuilderPattern;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace POSTtests

{
    [TestFixture]
    public class POSTtests
    {
        RequestComposer requestComposer;
        RequestBuilder builder;
        Request postRequest;


        [SetUp]
        public void TestInit()
        {
            requestComposer = new RequestComposer();
            builder = new PostRequestBuilder();
            postRequest = requestComposer.ComposeRequest(builder);
             
        }

        [Test]
        public void  CreatePostTest()
        {
            string expectedStatusCode = "Created";
            Assert.AreEqual(expectedStatusCode, postRequest.RestResponse.StatusCode.ToString(), "New post wasn't created");
        }
  
    }
}
