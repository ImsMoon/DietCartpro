using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DietCart.Entity
{
   public class FoodTable
    {
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public double FoodPrice { get; set; }
        public string FoodQuantity { get; set; }
        public string FoodStatus { get; set; }
    }
}
