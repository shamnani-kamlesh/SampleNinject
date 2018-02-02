using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using Contracts;

namespace BLL
{
    public class FruitBLL : IFruitBLL
    {
        private IFruitRepository _fruitRefpository;

        public FruitBLL(IFruitRepository fruitRefpository)
        {
            _fruitRefpository = fruitRefpository;
        }

        public List<Fruit> GetFruits()
        {
            return _fruitRefpository.GetFruits();
        }
    }
}
