using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.View;

namespace WucizeCase.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EFCategoryRepositories());

        MealManager mm = new MealManager(new EFMealRepositories());
        public IActionResult Index()
        {
            var values = cm.GetCategoryAll();
            return View(values);
        }

        public IActionResult CategoryDetails()
        {
            var values = mm.GetListWithCategoryAndLanguage();
            return View(values);
        }

        public PartialViewResult CategoryNameNavBar()
        {
            var values = cm.GetCategoryAll();
            return PartialView(values);
        }
    }
}
