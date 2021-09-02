using ContosoPizza.Models;
using System.Linq;
using System.Collections.Generic;

namespace ContosoPizza.Services
{
    /// <summary>
    /// Класс службы данных для Pizza
    /// </summary>
    public class PizzaService : IFoodItemSender<Pizza>
    {
        /// <summary>
        /// Коллекция объектов Pizza
        /// </summary>
        List<Pizza> Pizzas { get; }
        /// <summary>
        /// Начальный индекс для последующего добавления
        /// </summary>
        int nextId = 3;
        /// <summary>
        /// Конструктор. Инициализирует коллекцию объектов Pizza
        /// </summary>
        public PizzaService()
        {
            Pizzas = new List<Pizza>{
                new Pizza {Id = 1, Name = "Classic Italian", IsGlutenFree = false},
                new Pizza {Id = 2, Name = "Veggie", IsGlutenFree = true }
            };
        }
        /// <summary>
        /// Возвращает коллекцию объектов Pizza
        /// </summary>
        /// <returns></returns>
        public List<Pizza> GetAll() => Pizzas;

        /// <summary>
        /// Возвращает объект класса Pizza по id
        /// </summary>
        public Pizza Get(int id) => Pizzas.FirstOrDefault(p => p.Id == id);

        /// <summary>
        /// Удаляет объект класса Pizza по id
        /// </summary>
        public void Delete(int Id)
        {
            var pizza = Get(Id);
            if (pizza is null)
            {
                return;
            }
            Pizzas.Remove(pizza);
        }
    }
}