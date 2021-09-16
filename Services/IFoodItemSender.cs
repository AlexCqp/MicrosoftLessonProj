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
    public interface IFoodItemSender<T> 
        where T: class
    {
        /// <summary>
        /// Получение всех объектов
        /// </summary>
        public List<T> GetAll();
        /// <summary>
        /// Получение Объекта по id
        /// </summary>
        public T Get(int id);
        /// <summary>
        /// Удаление объекта по id
        /// </summary>
    }
}
