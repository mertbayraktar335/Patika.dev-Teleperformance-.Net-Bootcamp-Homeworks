using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mert.Bayraktar.Homeworks.Week._2._1.DependencyInversionAndInterfaceSegregation.Abstracts;

namespace Mert.Bayraktar.Homeworks.Week._2._1.DependencyInversionAndInterfaceSegregation.Concretes
{
    public class Worker : IEatable, IRestable, IWorkable, ISalary
    {
        public void Eat()
        {

        }

        public void Rest()
        {

        }

        public void SendSalary()
        {

        }

        public void Work()
        {

        }
    }
}
