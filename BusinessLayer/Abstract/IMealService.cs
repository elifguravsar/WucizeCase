using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMealService
    {
        List<Meal> GetMealAll();
        Meal GetByID(int id);
        void AddMeal(Meal meal);
        void DeleteMeal(Meal meal);
        void UpdateMeal(Meal meal);

        List<Meal> GetListWithCategory();
        List<Meal> GetListWithCategoryAndLanguage();


    }
}
