using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoPizza.Models
{
    /// <summary>
    /// Класс модели для объектов Food
    /// </summary>
    public abstract class Food
    {
        /// <summary>
        /// Номер объекта
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Флаг, указывающий на наличие глютена
        /// </summary>
        public bool IsGlutenFree { get; set; }
    }
}
