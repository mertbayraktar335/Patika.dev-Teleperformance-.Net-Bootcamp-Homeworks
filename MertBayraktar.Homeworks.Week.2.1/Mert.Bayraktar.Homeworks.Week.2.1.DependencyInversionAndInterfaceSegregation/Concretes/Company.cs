using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mert.Bayraktar.Homeworks.Week._2._1.DependencyInversionAndInterfaceSegregation.Abstracts;

namespace Mert.Bayraktar.Homeworks.Week._2._1.DependencyInversionAndInterfaceSegregation.Concretes
{
    public class Company : ISalary
    {
        private List<ISalary> salaries;
        public Company(List<ISalary> salaries)
        {
            this.salaries = salaries;
        }

        public void SendSalary()
        {
            foreach (var salary in salaries)
            {
                salary.SendSalary();
            }
        }
    }
}
