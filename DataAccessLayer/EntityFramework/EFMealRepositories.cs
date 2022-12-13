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
    public class EFMealRepositories : GenericRepositories<Meal>, IMealDal
    {
        public List<Meal> GetListWithCategory()
        {
            using (var c = new Context())
            {
                return c.Meals.Include(x => x.Category).ToList();
            } 
        }

        public List<Meal> GetListWithCategoryAndLanguage()
        {
            using (var c = new Context())
            {
                return c.Meals.Include(x => x.Category).Where(x=> x.Category.LanguageID == 1).ToList();
            }
        }
    }
}
