using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabriken
{
    internal class Machine : Warehouse
    {
        public void Wheel()
        {
            Console.WriteLine("one Wheel produced and stored in warehouse");
            Rubber.Remove(1);
           

            //foreach (var item in test)
            //{
            //    foreach (var item1 in Metal)
            //    {
            //        if (item > 1 && item1 > 1)
            //        {
            //            Console.WriteLine("one Wheel produced and stored in warehouse");
            //            Wheel1.Add(1);
            //            Metal.Remove(1);
            //            Rubber.Remove(1);
            //        }
            //        else
            //        {
            //            Console.WriteLine("No availabe item");
            //        }
            //    }
            //}
            //return new List<int>();
        }

    }

    //public int bicycle(int rubber, int metal)
    //{
    //    return 0;
    //}
    //public int Table(int wood, int metal)
    //{
    //    return 0;
    //}

}

