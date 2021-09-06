using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoPizza.Models;
namespace ContosoPizza.Services
{
    public class WokService : FoodItemSender<Wok>
    {
        public string Type { get; } = "Wok";
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
        public override List<Wok> GetAll() => Woks;

       
        public override Wok Get(int id) => Woks.FirstOrDefault(p => p.Id == id);

        public void Delete(int Id) {
            var wok = Get(Id);
            if(wok is null)
            {
                return;
            }
            Woks.Remove(wok);
        }

       
    }
}
