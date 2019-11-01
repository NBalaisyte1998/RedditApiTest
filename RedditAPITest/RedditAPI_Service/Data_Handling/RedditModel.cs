using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace RedditAPITest.RedditAPI_Service.Data_Handling
{
    public class RedditApiRoot
    {
        public string kind { get; set; }
        public Data data { get; set; }
    }

    public class Data
    {
        public string modhash { get; set; }
        public int dist { get; set; }
        public IList<RedditApiRoot> children { get; set; }
        public string after { get; set; }
        public string before { get; set; }

        public string approved_at_utc { get; set; }
        public string subreddit { get; set; }
        public string selftext { get; set; }
        public string author_fullname { get; set; }
        public bool saved { get; set; }
        public string mod_reason_title { get; set; }
        public int gilded { get; set; }
        public bool clicked { get; set; }
        public string title { get; set; }
        public IList<List1> link_flair_richtext { get; set; }
        public string subreddit_name_prefixed { get; set; }
        public bool hidden { get; set; }
        public string pwls { get; set; }
        public string link_flair_css_class { get; set; }
        public int downs { get; set; }
        public bool hide_score { get; set; }
        public string name { get; set; }
        public bool quarantine { get; set; }
        public string link_flair_text_color { get; set; }
        public string author_flair_background_color { get; set; }
        public string subreddit_type { get; set; }
        public int ups { get; set; }
        public int total_awards_received { get; set; }
        public Media_embed media_Embed { get; set; }
        public string author_flair_template_id { get; set; }
        public bool is_original_content { get; set; }
        public IList<List2> user_reports { get; set; }
        public string secure_media { get; set; }
        public bool is_reddit_media_domain { get; set; }
        public bool is_meta { get; set; }
        public string category { get; set; }
        public Secure_media_embed secure_media_embed { get; set; }
        public string link_flair_text { get; set; }
        public bool can_mod_post { get; set; }
        public int score { get; set; }
        public string approved_by { get; set; }
        public string thumbnail { get; set; }
        public bool edited { get; set; }
        public string author_flair_css_class { get; set; }
        public IList<List3> steward_reports { get; set; }
        public IList<List4> author_flair_richtext { get; set; }
        public Gildings gildings { get; set; }
        public bool content_categories { get; set; }
        public bool is_self { get; set; }
        public string mod_note { get; set; }
        public float created { get; set; }
        public string link_flair_type { get; set; }
        public string wls { get; set; }
        public string banned_by { get; set; }
        public string author_flair_type { get; set; }
        public string domain { get; set; }
        public bool allow_live_comments { get; set; }
        public string selftext_html { get; set; }
        public string likes { get; set; }
        public string suggested_sort { get; set; }
        public string banned_at_utc { get; set; }
        public string view_count { get; set; }
        public bool archived { get; set; }
        public bool no_follow { get; set; }
        public bool is_crosspostable { get; set; }
        public bool pinned { get; set; }
        public bool over_18 { get; set; }
        public IList<List4> all_awardings { get; set; }
        public IList<List5> awarders { get; set; }
        public bool media_only { get; set; }
        public bool can_gild { get; set; }
        public bool spoiler { get; set; }
        public bool locked { get; set; }
        public string author_flair_text { get; set; }
        public bool visited { get; set; }
        public string num_reports { get; set; }
        public string distinguished { get; set; }
        public string subreddit_id { get; set; }
        public bool mod_reason_by { get; set; }
        public bool removal_reason { get; set; }
        public string link_flair_background_color { get; set; }
        public string og_title { get; set; }
        public string id { get; set; }
        public bool is_robot_indexable { get; set; }
        public string report_reasons { get; set; }
        public string author { get; set; }
        public string discussion_type { get; set; }
        public int num_comments { get; set; }
        public bool send_replies { get; set; }
        public string whitelist_status { get; set; }
        public string og_description { get; set; }
        public bool contest_mode { get; set; }
        public IList<List5> mod_reports { get; set; }
        public bool author_patreon_flair { get; set; }
        public string author_flair_text_color { get; set; }
        public string permalink { get; set; }
        public string parent_whitelist_status { get; set; }
        public bool stickied { get; set; }
        public string url { get; set; }
        public float subreddit_subscribers { get; set; }
        public double created_utc { get; set; }
        public float num_crossposts { get; set; }
        public string media { get; set; }
        public bool is_video { get; set; }

        public class List1 { }
        public class List2 { }
        public class List3 { }
        public class List4 { }
        public class List5 { }
        public class Media_embed { }
        public class Secure_media_embed { }
        public class Gildings { }
    }

 
            
 }
