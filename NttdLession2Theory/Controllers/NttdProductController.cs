using Microsoft.AspNetCore.Mvc;
using NttdLession2Theory.Models;

namespace NttdLession2Theory.Controllers
{
    public class NttdProductController : Controller
    {
        public IActionResult NttdIndex()
        {
            ViewBag.name = "Nguyễn Trần Thành Đạt";
            ViewData["productVD"] = "Laptop Dell ";
            TempData["UNI"] = "Trường Đại học Nguyễn Trãi - NTU";
            return View();
        }
        public IActionResult GetProduct()
        {
            // Tạo mock data product
            NttdProduct tvcProduct = new NttdProduct()
            {
                ProductID = " 2410900020",
                ProductName = "Nguyễn Trần Thành Đạt",
                YearRelease = 1999,
                Price = 1000
            };

            ViewBag.product = NttdProduct;
            ViewData["product"] = NttdProduct;

            return View("product");
        }
    }
}
