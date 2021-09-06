using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoPizza.Models;

namespace ContosoPizza.Services
{
    public class PancakeService : FoodItemSender<Pancake>
    {
        /// <summary>
        /// Коллекция объектов Pancake
        /// </summary>
        public List<Pancake> Pancakes { get; }

        public string Type { get; } = "Pancake";

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
        public override List<Pancake> GetAll() => Pancakes;


        public override Pancake Get(int id) => Pancakes.FirstOrDefault(p => p.Id == id);

        public void Delete(int Id)
        {
            var Pancake = Get(Id);
            if (Pancake is null)
            {
                return;
            }
            Pancakes.Remove(Pancake);
        }
    }
}
