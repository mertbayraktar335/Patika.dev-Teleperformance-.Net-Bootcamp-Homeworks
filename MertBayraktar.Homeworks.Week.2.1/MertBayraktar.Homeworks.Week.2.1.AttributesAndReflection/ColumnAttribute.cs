using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MertBayraktar.Homeworks.Week._2._1.AttributesAndReflection
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnAttribute : Attribute
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Required { get; set; }


    }
}
