using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MertBayraktar.Homeworks.Week._2._1.AttributesAndReflection
{
    [Table(Name = "Urun")]
    public class Product
    {
        [Column(Name = "Id", Type = "int", Required = "zorunlu")]
        public int Id { get; set; }
    }
}
