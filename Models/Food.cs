using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoPizza.Models
{
    public abstract class Food
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsGlutenFree { get; set; }
    }
}
