using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoPizza.Models;

namespace ContosoPizza.Services
{
    class PancakeService : FoodItemSender<Pancake>
    {
        /// <summary>
        /// Коллекция объектов Pancake
        /// </summary>
        public List<Pancake> Pancakes { get; }

        /// <summary>
        /// Конструктор. Инициализирует коллекцию объектов Pancake
        /// </summary>
        public PancakeService()
        {
            Pancakes = new List<Pancake>
            {
                new Pancake {Id = 1, Name = "Pancake1", IsGlutenFree = false },
                new Pancake {Id = 2, Name = "Pancake2", IsGlutenFree = true }
            };

        }
        /// <summary>
        /// Возвращает все объекты класса Pancake
        /// </summary>
        public override List<Pancake> GetAll() => Pancakes;

        /// <summary>
        /// Возвращает объект класса Pancake по id
        /// </summary>
        public override Pancake Get(int id) => Pancakes.FirstOrDefault(p => p.Id == id);
    }
}
