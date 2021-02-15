using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace JDRApplication.data
{



    public class DataAccess
    {
        private static string connectionString = "https://jdrcharacters-f0a4.restdb.io/rest/characters";
        private static string apiKey = "ba77b40bf106652ec24b73f0c92e4fbb9f66f";


        public static void GetAll()
        {
            RestClient client = new RestClient(connectionString);
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("x-apikey", "ba77b40bf106652ec24b73f0c92e4fbb9f66f");
            request.AddHeader("content-type", "application/json");
            IRestResponse response = client.Execute(request);
        }

    }
}
