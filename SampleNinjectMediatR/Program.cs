using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Contracts;
using BLL;

namespace SampleNinjectMediatR
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel(new Core.NinjectBindings());
            var fruitsBLL = kernel.Get<IFruitBLL>();

            fruitsBLL.GetFruits();

            Console.ReadLine();
        }
    }
}
