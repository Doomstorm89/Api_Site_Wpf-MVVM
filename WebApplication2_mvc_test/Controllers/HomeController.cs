#region

using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication2_mvc_test.Data;
using WebApplication2_mvc_test.Entitys;
using WebApplication2_mvc_test.Models;

#endregion

namespace WebApplication2_mvc_test.Controllers
{
    public class HomeController : Controller
    {
        private readonly NewsApi _newsApi;

        public HomeController(NewsApi newsApi)
        {
            _newsApi = newsApi;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ConcreteNews(News.NewsType type)
        {
            var model = new NewsModel
            {
                Type = type,
                GetNews = _newsApi.GetNews().Where(x => x.Type == type.ToString())
            };

            return View(model);
        }
    }
}