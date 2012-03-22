using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MvcMusicStore.ViewModels;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        public ActionResult Index()
        {
            // Create a list of genres
            var genres = new List<string> { "Rock", "Jazz", "Country", "Pop", "Disco" };

            // Create our view model
            var viewModel = new StoreIndexViewModel { 
                NumberOfGenres = genres.Count(),
                Genres = genres
            };

            return View(viewModel);
        }

        public string Browse(string genre)
        {
            string message = HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);
            
            return message;
        }

        public string Details(int id)
        {
            string message = "Store.Details, ID = " + id;

            return message;
        }
    }
}
