using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace CurrencyCheckerServices
{
    public class ApiDataProcessor
    {
        private static HttpClient client = new HttpClient();

        public static List<StashTab> RequestStashTabs(string league, int numberOfPages, string startingId)
        {
            List<StashTab> tabs = new List<StashTab>();
            string currentId = startingId;
            while (numberOfPages > 0)
            {
                StashTabSet currentSet = RequestSet(currentId);
                currentId = currentSet.Next_change_id;
                tabs.AddRange(FilterStashTabs(currentSet.Stashes, (t => t.League), league));
                numberOfPages--;
            }

            return tabs;
        }

        public static StashTabSet RequestSet(string nextChangeId)
        {
            client.BaseAddress = new Uri("http://api.pathofexile.com/");
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            string query = "public-stash-tabs";
            if (nextChangeId != "")
            {
                query += "/?id=" + nextChangeId;
            }
            HttpResponseMessage m = client.GetAsync(query).Result;
            return m.Content.ReadAsAsync<StashTabSet>().Result;
        }

        public static List<StashTab> FilterStashTabs(IEnumerable<StashTab> tabs, Func<StashTab, IComparable> tabProperty, IComparable expectedValue)
        {
            List<StashTab> filteredTabs = new List<StashTab>();
            foreach(StashTab t in tabs)
            {
                if (tabProperty(t).Equals(expectedValue))
                {
                    filteredTabs.Add(t);
                }
            }
            return filteredTabs;
        }

    }
}
