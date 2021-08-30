using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication.Models;

namespace WebApplication.Data
{
    public class DataManager : IData<News>
    {
        private DataContext DataContext { get; }

        public DataManager()
        {
            DataContext = new DataContext();
        }

        public IEnumerable<INews> GetAllNews()
        {
            return DataContext.GetNews;
        }

        public IEnumerable<INews> GetConcreteNewsType(string newsType)
        {
            return Enum.TryParse(newsType, out News.NewsType type)
                ? DataContext.GetNews.Where(x => x.Type == type.ToString())
                : null;
        }

        public void SaveDb()
        {
            DataContext.SaveChanges();
        }

        public void AddData(News news)
        {
            DataContext.GetNews.Add(news);
        }
    }
}