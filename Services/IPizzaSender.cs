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
    public interface IPizzaSender
    {
        /// <summary>
        /// Получение всех объектов
        /// </summary>
        public List<Pizza> GetAll();
        /// <summary>
        /// Получение Объекта по id
        /// </summary>
        public Pizza Get(int id);
        /// <summary>
        /// Добавление объекта
        /// </summary>
        public void Add(Pizza pizza);
        /// <summary>
        /// Удаление объекта по id
        /// </summary>
        public void Delete(int Id);
        /// <summary>
        /// Обновление объекта
        /// </summary>
        public void Update(Pizza pizza);
    }
}
