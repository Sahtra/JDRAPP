using JDRApplication.data.Entities;
using Newtonsoft.Json;
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


        public static List<CharacterEntity> GetAll()
        {
            RestClient client = new RestClient(connectionString);
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("x-apikey", "ba77b40bf106652ec24b73f0c92e4fbb9f66f");
            request.AddHeader("content-type", "application/json");
            IRestResponse response = client.Execute(request);
            List<CharacterEntity> ret = new List<CharacterEntity>(); 
            try
            {
                ret = JsonConvert.DeserializeObject<List<CharacterEntity>>(response.Content);
            }
            catch(Exception e)
            {

            }
            return ret;
        }

        public static void Insert()
        {
            var client = new RestClient("https://jdrcharacters-f0a4.restdb.io/rest/characters");
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("x-apikey", "ba77b40bf106652ec24b73f0c92e4fbb9f66f");
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", "{\"field1\":\"xyz\",\"field2\":\"abc\"}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
        }

        public static void Update()
        {
            var client = new RestClient("https://jdrcharacters-f0a4.restdb.io/rest/characters/(ObjectID)");
            var request = new RestRequest(Method.PUT);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("x-apikey", "ba77b40bf106652ec24b73f0c92e4fbb9f66f");
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", "{\"field2\":\"new value\"}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
        }

        public static void Delete()
        {
            var client = new RestClient("https://jdrcharacters-f0a4.restdb.io/rest/characters/(ObjectID)");
            var request = new RestRequest(Method.DELETE);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("x-apikey", "ba77b40bf106652ec24b73f0c92e4fbb9f66f");
            request.AddHeader("content-type", "application/json");
            IRestResponse response = client.Execute(request);
        }

    }
}
