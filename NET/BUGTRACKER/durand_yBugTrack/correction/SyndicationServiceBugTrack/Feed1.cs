using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Syndication;
using System.ServiceModel.Web;
using System.Text;

namespace SyndicationServiceBugTrack
{
    // NOTE: If you change the class name "Feed1" here, you must also update the reference to "Feed1" in App.config.
    public class Feed1 : IFeed1
    {
        public SyndicationFeedFormatter CreateFeed()
        {
            // Create a new Syndication Feed.
            SyndicationFeed feed = new SyndicationFeed("Bug Track", "Flux rss du bug track", null);
            List<SyndicationItem> items = new List<SyndicationItem>();

            // Create a new Syndication Item.

            List<DBO.Bug> list = BusinessManagement.Bug.GetLastBug(10);

            foreach (DBO.Bug itemBug in list)
            {
                SyndicationItem item = new SyndicationItem(itemBug.ProjectName + " : " + itemBug.Title, itemBug.CreateDate + " \n " + itemBug.Details, null);
                items.Add(item);
            }

            
            
            feed.Items = items;

            // Return ATOM or RSS based on query string
            // rss -> http://localhost:8731/Design_Time_Addresses/SyndicationServiceBugTrack/Feed1/
            // atom -> http://localhost:8731/Design_Time_Addresses/SyndicationServiceBugTrack/Feed1/?format=atom
            string query = WebOperationContext.Current.IncomingRequest.UriTemplateMatch.QueryParameters["format"];
            SyndicationFeedFormatter formatter = null;
            if (query == "atom")
            {
                formatter = new Atom10FeedFormatter(feed);
            }
            else
            {
                formatter = new Rss20FeedFormatter(feed);
            }

            return formatter;
        }
    }
}
