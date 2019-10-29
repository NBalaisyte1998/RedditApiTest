using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace RedditAPITest.RedditAPI_Service.HTTP_Manager
{
    class RedditCallManager
    {
        readonly IRestClient restClient;
        public IRestResponse restResponse;
        public RedditCallManager()
        {
            restClient = new RestClient(RedditConfig.BaseUrl);
        }

        public string GetNeuroNews()
        {
            // Generate a new request based on the values set in the config
            var request = new RestRequest("/r/neuro.json");
            var response = restClient.Execute(request, Method.GET);
            restResponse = response;
            return response.Content;
        }
    }
}