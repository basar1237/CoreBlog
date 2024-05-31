using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace demo1.Controllers
{
    public class CategoryCotroller : Controller
    {
        CategoryManager cm=new CategoryManager(new EFCategoryRepostory());   
        public IActionResult Index()
        {
            var values = cm.GetList();
            return View( values);
        }
    }
}
