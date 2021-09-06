using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoPizza.Models;
namespace ContosoPizza.Services
{
    public class FoodItemSender<T> : IFoodItemSender<T>
        where T : Food
    {
        public string Type { get; }
        IEnumerable<Food> foodCollection;
        public void Delete(int Id)
        {
            
        }

        public virtual T Get(int id) => (T)foodCollection.FirstOrDefault(p => p.Id == id);


        public virtual IEnumerable<T> GetAll() => (IEnumerable<T>)foodCollection;

    }
}
