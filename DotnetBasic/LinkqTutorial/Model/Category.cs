using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorial.Model
{
    public class Category
    {
        public String CategoryName { get; set; }    
        public int Count { get; set; }  

        public Category (String name, int count) 
        {
           this.CategoryName= name; 
            this.Count = count;

        }

        public override string ToString()
        {
            return "Category{Name : " + this.CategoryName + ",Count : Rp." + this.Count +"}";

        }

        public static List<Category> GetData() 
        {
            List<Category> categories = new List<Category>()
            {
                new Category("Nasi Kuning", 500000),
                new Category("NAsi Goreng Pedas", 25000),
                new Category("Nasi Lemas Gurih",35000 ),
            };

            return categories;
        }

        public static void SampleFilterCategory() 
        {
            List<Category> categories = GetData();

            IEnumerable<Category> categoryFilter = from item in categories
                                                   where item.Count >= 30000
                                                   select item;
            foreach (var category in categoryFilter) 
            {
                Console.WriteLine(category);
            }

        }
    }
}
