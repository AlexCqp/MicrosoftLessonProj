using ContosoPizza.Models;
using System.Linq;
using System.Collections.Generic;

namespace ContosoPizza.Services
{
    /// <summary>
    /// ����� ������ ������ ��� Pizza
    /// </summary>
    public class PizzaService : FoodItemSender<Pizza>
    {
        /// <summary>
        /// ��������� �������� Pizza
        /// </summary>
        List<Pizza> Pizzas { get; }
        /// <summary>
        /// �����������. �������������� ��������� �������� Pizza
        /// </summary>
        public PizzaService()
        {
            Pizzas = new List<Pizza>{
                new Pizza {Id = 1, Name = "Classic Italian", IsGlutenFree = false},
                new Pizza {Id = 2, Name = "Veggie", IsGlutenFree = true }
            };
        }
        /// <summary>
        /// ���������� ��������� �������� Pizza
        /// </summary>
        /// <returns></returns>
        public override List<Pizza> GetAll() => Pizzas;

        /// <summary>
        /// ���������� ������ ������ Pizza �� id
        /// </summary>
        public override Pizza Get(int id) => Pizzas.FirstOrDefault(p => p.Id == id);

    }
}