using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ContosoPizza.Models;
using ContosoPizza.Services;

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
        private readonly IFoodItemSender<Wok> _wokSender;
        private readonly IFoodItemSender<Pancake> _pancakeSender;
        /// <summary>
        /// Конструктор
        /// </summary>
        public FoodController(
            IFoodItemSender<Pizza> pizzaSender = null, 
            IFoodItemSender<Wok> wokSender = null, 
            IFoodItemSender<Pancake> pancakeSender = null)
        {
            _pizzaSender = pizzaSender;
            _wokSender = wokSender;
            _pancakeSender = pancakeSender;
        }
        /// <summary>
        /// Получение коллекции объетов Pizza
        /// </summary>
        [HttpGet("{source:int}")]
        public ActionResult<List<Food>> GetAll(FoodSource source)
        {
            IEnumerable<Food> food = null;
            switch (source)
            {
                case FoodSource.Pizza:
                    {
                        food = _pizzaSender.GetAll();
                        break;
                    }
                case FoodSource.Wok:
                    {
                        food = _wokSender.GetAll();
                        break;
                    }
                case FoodSource.Pancake:
                    {
                        food = _pancakeSender.GetAll();
                        break;
                    }
                default:
                    {
                        return NotFound();
                    }
            }
            return food.ToList();
        }
        
        /// <summary>
        /// Получение объекта Pizza по id
        /// </summary>
        [HttpGet("{source:int}/{id}")]
        public ActionResult<Food> Get(FoodSource source, int id)
        {
            Food food = null;
            switch (source)
            {
                case FoodSource.Pizza:
                    {
                        food = _pizzaSender.Get(id);
                        break;
                    }
                case FoodSource.Wok:
                    {
                        food = _wokSender.Get(id);
                        break;
                    }
                case FoodSource.Pancake:
                    {
                        food = _pancakeSender.Get(id);
                        break;
                    }
                default:
                    {
                        return NotFound();
                        break;
                    }
            }
      
            if (food == null)
            {
                return NotFound();
            }

            return food;
        }
        
        /// <summary>
        /// Удаление объекта Pizza по id
        /// </summary>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var pizza = _pizzaSender.Get(id);

            if (pizza is null)
            {
                return NotFound();
            }

            _pizzaSender.Delete(id);

            return NoContent();
        }
    }
}