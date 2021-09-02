﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoPizza.Models;
namespace ContosoPizza.Services
{
    public class WokService : IFoodItemSender<Wok>
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
        public List<Wok> GetAll() => Woks;

       
        public Wok Get(int id) => Woks.FirstOrDefault(p => p.Id == id);

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
