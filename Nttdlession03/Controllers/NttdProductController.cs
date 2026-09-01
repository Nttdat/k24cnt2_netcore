using Microsoft.AspNetCore.Mvc;
using Nttdlession03.Models;

namespace Nttdlession03.Controllers
{
    [Route("/danh-sach-san-pham")]
    public class NttdProductController : Controller
    {
        // Mock data
        private readonly List<NttdProduct> _product = new()
        {
            new NttdProduct
            {
                NttdProductId = "TVC-MB-001",
                NttdProductName = "iPhone 15 Pro Max 256GB",
                NttdYearRelease = 2023,
                NttdPrice = 29990000m
            },
            new NttdProduct
            {
                NttdProductId = "TVC-MB-002",
                NttdProductName = "Samsung Galaxy S24 Ultra 512GB",
                NttdYearRelease = 2024,
                NttdPrice = 31490000m
            },
            new NttdProduct
            {
                NttdProductId = "TVC-MB-003",
                NttdProductName = "Xiaomi 14 Ultra 5G",
                NttdYearRelease = 2024,
                NttdPrice = 27990000m
            },
            new NttdProduct
            {
                NttdProductId = "TVC-MB-004",
                NttdProductName = "Google Pixel 8 Pro 128GB",
                NttdYearRelease = 2023,
                NttdPrice = 21500000m
            },
            new NttdProduct
            {
                NttdProductId = "TVC-MB-005",
                NttdProductName = "OPPO Find N3 Flip 256GB",
                NttdYearRelease = 2023,
                NttdPrice = 19990000m
            },
            new NttdProduct
            {
                NttdProductId = "TVC-MB-006",
                NttdProductName = "Samsung Galaxy Z Fold5 512GB",
                NttdYearRelease = 2023,
                NttdPrice = 34990000m
            },
            new NttdProduct
            {
                NttdProductId = "TVC-MB-007",
                NttdProductName = "iPad Pro M4 11-inch Wi-Fi 256GB",
                NttdYearRelease = 2024,
                NttdPrice = 28990000m
            },
            new NttdProduct
            {
                NttdProductId = "TVC-MB-008",
                NttdProductName = "Samsung Galaxy Tab S9 Ultra",
                NttdYearRelease = 2023,
                NttdPrice = 25490000m
            },
            new NttdProduct
            {
                NttdProductId = "TVC-MB-009",
                NttdProductName = "ASUS ROG Phone 8 Pro 512GB",
                NttdYearRelease = 2024,
                NttdPrice = 28490000m
            },
            new NttdProduct
            {
                NttdProductId = "TVC-MB-010",
                NttdProductName = "Vivo X100 Pro 5G 256GB",
                NttdYearRelease = 2024,
                NttdPrice = 22990000m
            }

        };
        public IActionResult Index()
        {
            return Json(_product);
        }
        // Collection => view
        [Route("all")]
        public IActionResult NttdGetAllProduct()
        {
            ViewData["products"] = _product;
            return View();
        }
    }
}
