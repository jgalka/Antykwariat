using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Antykwariat.Models;

namespace Antykwariat.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        AntykwariatEntities storeDB = new AntykwariatEntities();

        public ActionResult Index()
        {
            // Get most popular albums
            var albums = GetTopSellingAlbums(5);

            return View(albums);
        }

        private List<Ksiazka> GetTopSellingAlbums(int count)
        {
            // Group the order details by album and return
            // the albums with the highest count

            return storeDB.Ksiazki
                .OrderByDescending(a => a.OrderDetails.Count())
                .Take(count)
                .ToList();
        }
    }
}