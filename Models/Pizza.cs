namespace ContosoPizza.Models
{
    /// <summary>
    /// Класс модели для объекта Pizza
    /// </summary>
    public class Pizza
    {
        /// <summary>
        /// Id объекта
        /// </summary>
        public int Id {get; set; }
        /// <summary>
        /// Наименование
        /// </summary>
        public string Name {get; set;}
        /// <summary>
        /// Флаг на содержание глютена 
        /// </summary>
        public bool IsGlutenFree {get; set;}
    }
}