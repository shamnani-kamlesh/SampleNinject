using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using Contracts;

namespace DAL
{
    public class FruitRepository : IFruitRepository
    {
        public List<Fruit> GetFruits()
        {
            return new List<Fruit>
            {
                new Fruit { Id= 1, Name= "Apples" },
                new Fruit { Id= 2, Name= "Apricots" },
                new Fruit { Id= 3, Name= "Avocados" },
                new Fruit { Id= 4, Name= "Bananas" },
                new Fruit { Id= 5, Name= "Boysenberries" },
                new Fruit { Id= 6, Name= "Blueberries" },
                new Fruit { Id= 7, Name= "Bing Cherry" },
                new Fruit { Id= 8, Name= "Cherries" },
                new Fruit { Id= 9, Name= "Cantaloupe" },
                new Fruit { Id= 10, Name= "Crab apples" },
                new Fruit { Id= 11, Name= "Clementine" },
                new Fruit { Id= 12, Name= "Cucumbers" }
            };
        }
    }
}
