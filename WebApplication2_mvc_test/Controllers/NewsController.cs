#region

using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApplication2_mvc_test.Data;
using WebApplication2_mvc_test.Entitys;
using WebApplication2_mvc_test.Models;

#endregion

namespace WebApplication2_mvc_test.Controllers
{
    public class NewsController : Controller
    {
        private readonly NewsApi _newsApi;

        public NewsController(NewsApi newsApi)
        {
            _newsApi = newsApi;
        }

        [HttpGet]
        public IActionResult AddNews()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNews(string heading, string imagePath, string newsText, string type)
        {
            _newsApi.AddNews(
                new News
                {
                    Heading = heading,
                    ImagePath = imagePath,
                    NewsText = newsText,
                    Type = type
                });

            return Redirect("~/");
        }

        public IActionResult AllNews()
        {
            var model = new NewsModel
            {
                GetNews = _newsApi.GetNews()
            };
            
            return View( model );
        }
    }
}