using ContosoPizza.Models;
using System.Linq;
using System.Collections.Generic;

namespace ContosoPizza.Services
{
    /// <summary>
    /// Класс службы данных для Pizza
    /// </summary>
    public static class PizzaService{
        /// <summary>
        /// Коллекция объектов Pizza
        /// </summary>
        static List<Pizza> Pizzas {get;}
        /// <summary>
        /// Начальный индекс для последующего добавления
        /// </summary>
        static int nextId = 3;
        /// <summary>
        /// Конструктор. Инициализирует коллекцию объектов Pizza
        /// </summary>
        static PizzaService()
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
        public static List<Pizza> GetAll()=>Pizzas;
        /// <summary>
        /// Возвращает объект класса Pizza по id
        /// </summary>
        public static Pizza Get(int id) => Pizzas.FirstOrDefault(p => p.Id == id);
        /// <summary>
        /// Создаёт новый объект класса Pizza
        /// </summary>
        public static void Add(Pizza pizza){
            pizza.Id = nextId++;
            Pizzas.Add(pizza);
        }
        /// <summary>
        /// Удаляет объект класса Pizza по id
        /// </summary>
        public static void Delete(int Id){
            var pizza = Get(Id);
            if (pizza is null)
            {
                return;
            }
            Pizzas.Remove(pizza);
        }
        
        /// <summary>
        /// Обновляет объект класса пицца
        /// </summary>
        /// <param name="pizza"></param>
        public static void Update(Pizza pizza){
            var index = Pizzas.FindIndex(p=>p.Id==pizza.Id);
            if (index == -1)
            {
                return;
            }
            Pizzas[index] = pizza;

        }
    }
}