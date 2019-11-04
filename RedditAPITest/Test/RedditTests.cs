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
        [Test]
        public void SelfTextCheck()
        {

            Assert.IsNotNull(redditService.redditDTO.redditApiRoot.data.children[0].data.selftext);
        }
        [Test]
        public void AuthorCheck()
        {
            string authorreferencelenght = redditService.redditDTO.redditApiRoot.data.children[0].data.author_fullname.ToString();
            Assert.AreEqual(11, authorreferencelenght.Length);
        }
        [Test]
        public void SavedCheck()
        {
            Assert.IsFalse(redditService.redditDTO.redditApiRoot.data.children[0].data.saved);
        }
        [Test]
        public void Mod_reason_titleCheck()
        {

            Assert.IsNull(redditService.redditDTO.redditApiRoot.data.children[0].data.mod_reason_title);
        }
        [Test]
        public void GildedCheck()
        {

            Assert.AreEqual(0,redditService.redditDTO.redditApiRoot.data.children[0].data.gilded);
        }
        [Test]
        public void ClickedCheck()
        {

            Assert.IsFalse(redditService.redditDTO.redditApiRoot.data.children[0].data.clicked);
        }
        [Test]
        public void TitleCheck()
        {

            Assert.IsNotNull(redditService.redditDTO.redditApiRoot.data.children[0].data.title);
        }
        [Test]
        public void List1Check()
        {

            Assert.IsEmpty(redditService.redditDTO.redditApiRoot.data.children[0].data.link_flair_richtext);
        }
        [Test]
        public void SubredditprefixCheck()
        {

            Assert.AreEqual("r/neuro",redditService.redditDTO.redditApiRoot.data.children[0].data.subreddit_name_prefixed);
        }
        [Test]
        public void HiddenCheck()
        {

            Assert.IsFalse(redditService.redditDTO.redditApiRoot.data.children[0].data.hidden);
        }
        [Test]
        public void PwlsCheck()
        {

            Assert.IsNull(redditService.redditDTO.redditApiRoot.data.children[0].data.pwls);
        }
        [Test]
        public void LinkFlairClassCheck()
        {

            Assert.IsNull(redditService.redditDTO.redditApiRoot.data.children[0].data.link_flair_css_class);
        }



    }

}
