using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoPizza.Models;

namespace ContosoPizza.Services
{
    /// <summary>
    /// Интерфейс зависимости для PizzaService
    /// </summary>
    public interface IFoodItemSender<out T> 
        where T: class
    {
        public string Type { get; }
        /// <summary>
        /// Получение всех объектов
        /// </summary>
        public IEnumerable<T> GetAll();
        /// <summary>
        /// Получение Объекта по id
        /// </summary>
        public T Get(int id);
        /// <summary>
        /// Удаление объекта по id
        /// </summary>
        public void Delete(int Id);
    }
}
