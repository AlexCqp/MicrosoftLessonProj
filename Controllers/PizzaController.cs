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
    public class PizzaController : ControllerBase 
    {
        /// <summary>
        /// Получение коллекции объетов Pizza
        /// </summary>
       [HttpGet]
       public ActionResult<List<Pizza>> GetAll() => 
            PizzaService.GetAll();
        
        /// <summary>
        /// Получение объекта Pizza по id
        /// </summary>
        [HttpGet("{id}")]
        public ActionResult<Pizza> Get(int id)
        {
            var pizza = PizzaService.Get(id);
            if (pizza == null)
            {
                return NotFound();
            }

            return pizza;
        }
        /// <summary>
        /// Создание объекта Pizza
        /// </summary>
        [HttpPost]
        public IActionResult Create(Pizza pizza)
        {            
            PizzaService.Add(pizza);
            return CreatedAtAction(nameof(Create), new { id = pizza.Id }, pizza);
        }
        /// <summary>
        /// Обновление объекта Pizza по id
        /// </summary>
        [HttpPut("{id}")]
        public IActionResult Update(int id, Pizza pizza)
        {
            if (id != pizza.Id)
            {
                return BadRequest();
            }

            var existingPizza = PizzaService.Get(id);
            if (existingPizza is null)
            {
                return NotFound();
            }

            PizzaService.Update(pizza);           

            return NoContent();
        }
        /// <summary>
        /// Удаление объекта Pizza по id
        /// </summary>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var pizza = PizzaService.Get(id);

            if (pizza is null)
            {
                return NotFound();
            }

            PizzaService.Delete(id);

            return NoContent();
        }
    }
}