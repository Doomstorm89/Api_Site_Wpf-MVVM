using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Data;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    [ ApiController ]
    [ Route( "api/[controller]" ) ]
    public class NewsController : ControllerBase
    {
        private DataManager dataManager;

        public NewsController()
        {
            dataManager = new DataManager();
        }
        
        [ HttpGet ]
        public IEnumerable<INews> Get()
        {
            return dataManager.GetAllNews();
        }
        
        [HttpPost]
        public void Post([FromBody] News value)
        {
            dataManager.AddData( value );
            dataManager.SaveDb();
        }
    }
}