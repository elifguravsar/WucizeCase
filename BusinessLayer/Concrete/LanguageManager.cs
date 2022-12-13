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
    public class LanguageManager : ILanguageService
    {
        ILanguageDal _languageDal;
        public LanguageManager(ILanguageDal languageDal)
        {
            _languageDal = languageDal;

        }
        public void AddLanguage(Language language)
        {
            _languageDal.Insert(language);
        }

        public void DeleteLanguage(Language language)
        {
            _languageDal.Delete(language);
        }

        public Language GetByID(int id)
        {
            return _languageDal.GetByID(id);
        }

        public List<Language> GetLanguagesAll()
        {
            return _languageDal.GetListAll();
        }

        public void UpdateLanguage(Language language)
        {
           _languageDal.Update(language);
        }
    }
}
