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
        [Test]
        public void DistCheck()
        {
            Assert.AreEqual(25, redditService.redditDTO.redditApiRoot.data.dist);
        }
        [Test]
        public void Kind1Check()
        {
            string[] correctKind = new string[]
            { "t1", "t2", "t3", "t4", "t5"};

            Assert.Contains(redditService.redditDTO.redditApiRoot.data.children[0].kind, correctKind);
        }
        [Test]
        public void Aprroved_at_UTC_Check()
        {

            Assert.IsNull(redditService.redditDTO.redditApiRoot.data.children[0].data.approved_at_utc);
        }
        [Test]
        public void SubredditCheck()
        {

            Assert.AreEqual("neuro", redditService.redditDTO.redditApiRoot.data.children[0].data.subreddit);
        }

    }

}
