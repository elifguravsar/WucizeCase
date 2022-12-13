using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Meal
    {
        [Key]
        public int MealID { get; set; }

        public string MealName { get; set; }

        public string MealMaterials { get; set; }

        public string MealPicture { get; set; }

        public string MealPrice { get; set; }

        public int CategoryID { get; set; }

        public Category Category { get; set; }  
    }
}
