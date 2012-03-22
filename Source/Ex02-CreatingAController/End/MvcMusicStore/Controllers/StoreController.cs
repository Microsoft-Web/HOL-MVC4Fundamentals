using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        public string Index()
        {
            return "Hello from Store.Index()";
        }

        public string Browse()
        {
            return "Hello from Store.Browse()";
        }

        public string Details()
        {
            return "Hello from Store.Details()";
        }
    }
}
