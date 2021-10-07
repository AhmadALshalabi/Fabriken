using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabriken
{
    internal class Warehouse
    {
        public List<int> Glass { get; set; } = new List<int>();
        public List<int> Wood { get; set; } = new List<int>();
        public List<int> Metal { get; set; } = new List<int>(3);
        public List<int> Rubber { get; set; } = new List<int>(3);


        //finished products

        public List<int> Wheel1 { get; set; } = new List<int>();
        public int Table { get; set; }
        public int Bicycle { get; set; }
        public int Car { get; set; }

    }
}
