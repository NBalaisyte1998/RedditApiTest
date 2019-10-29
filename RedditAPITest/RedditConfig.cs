using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace RedditAPITest
{
    class RedditConfig
    {
        public static readonly String BaseUrl = ConfigurationManager.AppSettings["base_url"];
    }
}
