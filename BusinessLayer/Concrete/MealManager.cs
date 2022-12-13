using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MealManager : IMealService
    {
        IMealDal _mealDal;
        public MealManager(IMealDal mealDal)
        {
            _mealDal = mealDal;
        }
        public void AddMeal(Meal meal)
        {
            _mealDal.Insert(meal);
        }

        public void DeleteMeal(Meal meal)
        {
            _mealDal.Delete(meal);
        }

        public Meal GetByID(int id)
        {
            return _mealDal.GetByID(id);
        }

        public List<Meal> GetListWithCategory()
        {
            return _mealDal.GetListWithCategory();
        }

        public List<Meal> GetListWithCategoryAndLanguage()
        {
            return _mealDal.GetListWithCategoryAndLanguage();
        }

        public List<Meal> GetMealAll()
        {
            return _mealDal.GetListAll();
        }

        public void UpdateMeal(Meal meal)
        {
            _mealDal.Update(meal);
        }
    }
}
