using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoPizza.Models;
namespace ContosoPizza.Services
{
    public class WokService : FoodItemSender<Wok>
    {
        /// <summary>
        /// Коллекция объектов Wok
        /// </summary>
        public List<Wok> Woks { get; }
        /// <summary>
        /// Конструктор
        /// </summary>
        public WokService()
        {
            Woks = new List<Wok>
            {
                new Wok {Id = 1, Name = "Wok1", IsGlutenFree = false }
            };

        }
        /// <summary>
        /// Возвращает коллекцию объектов класса Wok
        /// </summary>
        public override List<Wok> GetAll() => Woks;

        /// <summary>
        /// Возвращает объект класса Wok по id
        /// </summary>
        public override Wok Get(int id) => Woks.FirstOrDefault(p => p.Id == id);       
    }
}
