using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Chips:Food
    {
        public bool IsExtraBig { get; set; }

        public bool IsWithDipps { get; set; }

        public Chips(decimal price, bool isVeg, bool isExtraBig, bool isWithDipps):base(price,isVeg)
        {
            IsExtraBig = isExtraBig;
            IsWithDipps = isWithDipps;
        }
    }
}
