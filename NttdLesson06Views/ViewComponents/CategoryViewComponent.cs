using NttdLesson06Views.Models;
using Microsoft.AspNetCore.Mvc;

namespace NttdLesson06Views.ViewComponents
{
    public class CategoryViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int? n)
        {
            var categories = new List<Category>
            {
                new Category { CategoryID = 1, CategoryName = "Electronics", Status = true },
                new Category { CategoryID = 2, CategoryName = "Books", Status = true },
                new Category { CategoryID = 3, CategoryName = "Clothing", Status = false },
                new Category { CategoryID = 4, CategoryName = "Home & Kitchen", Status = true }
            };
            n=n ?? 0;
            var search = categories.Where(x=>x.CategoryID >n).ToList();
            return View(search);
        }
    }
}
