using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ContosoPizza.Models;
using ContosoPizza.Services;
using System;

namespace ContosoPizza.Controllers
{
    /// <summary>
    /// Класс контроллера для обработки запросов
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class FoodController : ControllerBase
    {
        /// <summary>
        /// Экземпляр класса службы данных
        /// </summary>

        readonly private IFoodItemSender<Food> _foodSender;
        /// <summary>
        /// Конструктор
        /// </summary>
        public FoodController(IFoodItemSender<Food> foodSender)
        {
            _foodSender = foodSender;
        }
        /// <summary>
        /// Получение коллекции объетов Pizza
        /// </summary>
        [HttpPost]
        public ActionResult<IEnumerable<Food>> GetAll()
        {
            return _foodSender.GetAll().ToList();
        }
        
        /// <summary>
        /// Получение объекта Pizza по id
        /// </summary>
        [HttpGet("{id}")]
        public ActionResult<Food> Get(int id)
        {
            Food food = _foodSender.Get(id);
            if(food is null)
            {
                return NoContent();
            }
            return food;
        }
        
    }
}