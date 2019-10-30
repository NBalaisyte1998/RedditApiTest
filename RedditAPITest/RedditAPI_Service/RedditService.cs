using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedditAPITest.RedditAPI_Service.Data_Handling;
using RedditAPITest.RedditAPI_Service.HTTP_Manager;
using Newtonsoft.Json.Linq;

namespace RedditAPITest.RedditAPI_Service
{
    class RedditService
    {
        // We need DTO
        public RedditDTO redditDTO = new RedditDTO();
        // We need Call Manager
        public RedditCallManager redditCallManager = new RedditCallManager();
        // We need JObject
        public JObject RedditJSON;
        public RedditService()
        {
            // Deserialize the response from the call manager
            redditDTO.DeserializeNeuroNews(redditCallManager.GetNeuroNews());
            RedditJSON = JObject.Parse(redditCallManager.GetNeuroNews());
        }
    }
}
