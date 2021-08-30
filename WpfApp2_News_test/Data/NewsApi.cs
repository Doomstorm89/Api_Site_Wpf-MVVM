using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Net.Http;
using WpfApp2_News_test.Entities;


namespace WpfApp2_News_test
{
    public class NewsApi
    {
        private const string url = @"https://localhost:5001/api/news";

        public NewsApi()
        {
            httpClient = new HttpClient();
        }

        private HttpClient httpClient { get; }

        public void AddNews(News news)
        {
            var r = httpClient.PostAsync(
                url,
                new StringContent(JsonConvert.SerializeObject(news),
                    Encoding.UTF8,
                    "application/json")
            ).Result;
        }

        public IEnumerable<News> GetNews()
        {
            var json = httpClient.GetStringAsync(url).Result;
            return JsonConvert.DeserializeObject<IEnumerable<News>>(json);
        }
    }
}