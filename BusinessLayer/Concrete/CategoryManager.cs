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
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _CategoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _CategoryDal= categoryDal;
        }
        public void AddCategory(Category category)
        {
            _CategoryDal.Insert(category);
        }

        public void DeleteCategory(Category category)
        {
            _CategoryDal.Delete(category);
        }

        public Category GetByID(int id)
        {
            return _CategoryDal.GetByID(id);
        }

        public List<Category> GetCategoriesWithLanguage()
        {
            return _CategoryDal.GetCategoriesWithLanguage();
        }

        public List<Category> GetCategoryAll()
        {
            return _CategoryDal.GetListAll();
        }

        public void UpdateCategory(Category category)
        {
            _CategoryDal.Update(category);
        }
    }
}
