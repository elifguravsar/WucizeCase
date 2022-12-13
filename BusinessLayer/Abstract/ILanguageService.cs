using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ILanguageService
    {
        List<Language> GetLanguagesAll();
        Language GetByID(int id);
        void AddLanguage(Language language);
        void DeleteLanguage(Language language);
        void UpdateLanguage(Language language);
    }
}
