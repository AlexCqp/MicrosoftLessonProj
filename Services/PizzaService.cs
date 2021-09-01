using ContosoPizza.Models;
using System.Linq;
using System.Collections.Generic;

namespace ContosoPizza.Services
{
    /// <summary>
    /// ����� ������ ������ ��� Pizza
    /// </summary>
    public class PizzaService : IPizzaSender
    {
        /// <summary>
        /// ��������� �������� Pizza
        /// </summary>
        List<Pizza> Pizzas {get;}
        /// <summary>
        /// ��������� ������ ��� ������������ ����������
        /// </summary>
        int nextId = 3;
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
        public List<Pizza> GetAll()=>Pizzas;
        /// <summary>
        /// ���������� ������ ������ Pizza �� id
        /// </summary>
        public Pizza Get(int id) => Pizzas.FirstOrDefault(p => p.Id == id);
        /// <summary>
        /// ������ ����� ������ ������ Pizza
        /// </summary>
        public void Add(Pizza pizza){
            pizza.Id = nextId++;
            Pizzas.Add(pizza);
        }
        /// <summary>
        /// ������� ������ ������ Pizza �� id
        /// </summary>
        public void Delete(int Id){
            var pizza = Get(Id);
            if (pizza is null)
            {
                return;
            }
            Pizzas.Remove(pizza);
        }
        
        /// <summary>
        /// ��������� ������ ������ �����
        /// </summary>
        /// <param name="pizza"></param>
        public void Update(Pizza pizza){
            var index = Pizzas.FindIndex(p=>p.Id==pizza.Id);
            if (index == -1)
            {
                return;
            }
            Pizzas[index] = pizza;

        }
    }
}