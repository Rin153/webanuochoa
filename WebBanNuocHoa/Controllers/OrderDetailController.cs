using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanNuocHoa.Models;

namespace WebBanNuocHoa.Controllers
{
    public class OrderDetailController : Controller
    {
        WebBanNuocHoaEntities database = new WebBanNuocHoaEntities();

        // GET: OrderDetail
        public ActionResult GroupByTop5()
        {
            List<OrderDetail> orderD = database.OrderDetails.ToList();
            List<Product> prolist = database.Products.ToList();
            var query = from od in orderD join p in prolist on od.IDProduct equals p.ProductID into tbl
                        group od by new
                        {
                            idPro = od.IDProduct,
                            namePro = od.Product.NamePro,
                            imagePro = od.Product.ImagePro,
                            price = od.Product.Price
                        } into gr
                        orderby gr.Sum(s => s.Quantity) descending
                        select new ViewModel
                        {
                            IDPro = gr.Key.idPro,
                            NamePro = gr.Key.namePro,
                            ImgPro = gr.Key.imagePro,
                            pricePro = (decimal)gr.Key.price,
                            Sum_Quantity = gr.Sum(s => s.Quantity)
                        };
            return View(query.Take(5).ToList());

        }
    }
}