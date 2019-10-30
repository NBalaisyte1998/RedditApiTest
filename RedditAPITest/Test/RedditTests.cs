using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RedditAPITest.RedditAPI_Service;

namespace RedditAPITest.Test
{
    [TestFixture]
    class RedditTests
    {
        RedditService redditService = new RedditService();

        public RedditTests()
        {
        }
        [Test]
        public void KindCheck()
        {
            Assert.AreEqual("Listing", redditService.redditDTO.redditApiRoot.kind);
        }
        [Test]
        public void ModhashCheck()
        {
            Assert.AreEqual("",redditService.redditDTO.redditApiRoot.data.modhash);
        }
    }
}
