using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RedditAPITest.RedditAPI_Service.Data_Handling
{
    class RedditDTO
    {
        public RedditApiRoot redditApiRoot { get; set; }
        public void DeserializeNeuroNews(String RedditApiRootResponse)
        {
            // Deserialize the response passing it to the model
            redditApiRoot = JsonConvert.DeserializeObject<RedditApiRoot>(RedditApiRootResponse);
        }
    }
}
