#region

using System.Collections.Generic;
using WebApplication2_mvc_test.Entitys;

#endregion

namespace WebApplication2_mvc_test.Models
{
    public class NewsModel
    {
        public News.NewsType Type { get; set; }
        public IEnumerable<News> GetNews { get; set; }
    }
}