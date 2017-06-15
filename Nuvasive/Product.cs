using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuvasive
{
    public class Product
    {
        public int ID { get; set; }

        public string SKU { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public bool IsAvailable { get; set; }
    }
}
