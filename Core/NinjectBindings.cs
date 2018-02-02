using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using BO;
using Contracts;
using BLL;
using DAL;

namespace Core
{
    public class NinjectBindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IFruitRepository>().To<FruitRepository>();
            Bind<IFruitBLL>().To<FruitBLL>();
        }
    }
}
