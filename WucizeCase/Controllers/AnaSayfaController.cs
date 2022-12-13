using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WucizeCase.Controllers
{
    public class AnaSayfaController : Controller
    {
        CategoryManager cm = new CategoryManager(new EFCategoryRepositories());
        public IActionResult Index()
        {
            var values = cm.GetCategoriesWithLanguage();
            return View(values);
        }

    }
}
