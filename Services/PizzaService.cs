using ContosoPizza.Models;
using System.Linq;
using System.Collections.Generic;

namespace ContosoPizza.Services
{
    /// <summary>
    /// ����� ������ ������ ��� Pizza
    /// </summary>
    public static class PizzaService{
        /// <summary>
        /// ��������� �������� Pizza
        /// </summary>
        static List<Pizza> Pizzas {get;}
        /// <summary>
        /// ��������� ������ ��� ������������ ����������
        /// </summary>
        static int nextId = 3;
        /// <summary>
        /// �����������. �������������� ��������� �������� Pizza
        /// </summary>
        static PizzaService()
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
        public static List<Pizza> GetAll()=>Pizzas;
        /// <summary>
        /// ���������� ������ ������ Pizza �� id
        /// </summary>
        public static Pizza Get(int id) => Pizzas.FirstOrDefault(p => p.Id == id);
        /// <summary>
        /// ������ ����� ������ ������ Pizza
        /// </summary>
        public static void Add(Pizza pizza){
            pizza.Id = nextId++;
            Pizzas.Add(pizza);
        }
        /// <summary>
        /// ������� ������ ������ Pizza �� id
        /// </summary>
        public static void Delete(int Id){
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
        public static void Update(Pizza pizza){
            var index = Pizzas.FindIndex(p=>p.Id==pizza.Id);
            if (index == -1)
            {
                return;
            }
            Pizzas[index] = pizza;

        }
    }
}