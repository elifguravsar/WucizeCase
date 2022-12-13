using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        public string CategoryPicture { get; set; }

        public int LanguageID { get; set; }

        public Language Language { get; set; }  

        public List<Meal> Meals { get; set; }   
    }
}
