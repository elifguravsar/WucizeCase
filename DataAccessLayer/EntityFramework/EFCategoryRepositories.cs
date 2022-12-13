using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFCategoryRepositories : GenericRepositories<Category>, ICategoryDal
    {
        public List<Category> GetCategoriesWithLanguage()
        {
            using(var c = new Context())
            {
                return c.Categories.Where(x => x.LanguageID == 1).ToList();
            }
        }

       
    }
}
