using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanNuocHoa.Models;

namespace WebBanNuocHoa.Controllers
{
    public class CategoryController : Controller
    {
        WebBanNuocHoaEntities database = new WebBanNuocHoaEntities();
        // GET: Category
        public PartialViewResult CategoryPartial()
        {
            var categories = database.Categories.ToList();
            return PartialView(categories);
        }
    }
}