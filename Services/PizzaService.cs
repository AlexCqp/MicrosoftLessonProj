using ContosoPizza.Models;
using System.Linq;
using System.Collections.Generic;

namespace ContosoPizza.Services
{
    /// <summary>
    /// Класс службы данных для Pizza
    /// </summary>
    public class PizzaService : FoodItemSender<Pizza>
    {
        /// <summary>
        /// Коллекция объектов Pizza
        /// </summary>
        List<Pizza> Pizzas { get; }
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
        public override List<Pizza> GetAll() => Pizzas;

        /// <summary>
        /// Возвращает объект класса Pizza по id
        /// </summary>
        public override Pizza Get(int id) => Pizzas.FirstOrDefault(p => p.Id == id);

    }
}