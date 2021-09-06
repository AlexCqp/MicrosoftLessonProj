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
        private readonly IFoodItemSender<Pizza> _pizzaSender;
        //private readonly IFoodItemSender<Wok> _wokSender;
        //private readonly IFoodItemSender<Pancake> _pancakeSender;
        private IFoodItemSender<Food> _foodSender;
        /// <summary>
        /// Конструктор
        /// </summary>
        public FoodController(IFoodItemSender<Food> foodSender)
        {
           // foodSender = new PizzaService();
            _foodSender = foodSender;

        }
        /// <summary>
        /// Получение коллекции объетов Pizza
        /// </summary>
        [HttpPost("{type}")]
        public ActionResult<IEnumerable<Food>> GetAll([FromBody]IFoodItemSender<Food> type)
        {
            //return BadRequest();
            _foodSender = type;
            return _foodSender.GetAll().ToList();
        }
        
        /// <summary>
        /// Получение объекта Pizza по id
        /// </summary>
        [HttpGet("{id}")]
        public ActionResult<Food> Get([FromBody] IFoodItemSender<Food> type,int id)
        {
            Food food = _foodSender.Get(id);
            if(food is null)
            {
                return NoContent();
            }
            return food;
            //switch (source)
            //{
            //    case FoodSource.Pizza:
            //        {
            //            food = _pizzaSender.Get(id);
            //            break;
            //        }
            //    case FoodSource.Wok:
            //        {
            //            food = _wokSender.Get(id);
            //            break;
            //        }
            //    case FoodSource.Pancake:
            //        {
            //            food = _pancakeSender.Get(id);
            //            break;
            //        }
            //    default:
            //        {
            //            return NotFound();
            //            break;
            //        }
            //}
      
            //if (food == null)
            //{
            //    return NotFound();
            //}

            //return food;
        }
        
        /// <summary>
        /// Удаление объекта Pizza по id
        /// </summary>
        //[HttpDelete("{id}")]
        //public IActionResult Delete(int id)
        //{
        //    var pizza = _pizzaSender.Get(id);

        //    if (pizza is null)
        //    {
        //        return NotFound();
        //    }

        //    _pizzaSender.Delete(id);

        //    return NoContent();
        //}
    }
}