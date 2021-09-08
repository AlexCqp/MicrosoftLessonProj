using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoPizza.Models;
namespace ContosoPizza.Services
{
    /// <summary>
    /// Класс, реализующий интерфейс IFoodItemSender
    /// </summary>
    public class FoodItemSender<T> : IFoodItemSender<T>
        where T : Food
    {
        /// <summary>
        /// Коллекция объектов класса Food
        /// </summary>
        IEnumerable<T> foodCollection;
        /// <summary>
        /// Взятие объекта класса Food по id
        /// </summary>
        public virtual T Get(int id) => foodCollection.FirstOrDefault(p => p.Id == id);
        /// <summary>
        /// Возвращает всю коллекцию объектов класса Food
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerable<T> GetAll() => foodCollection;

    }
}
