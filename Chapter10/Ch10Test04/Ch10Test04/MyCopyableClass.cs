using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10Test04
{
    class MyCopyableClass
    {
        public string Name { get; set; }

        public MyCopyableClass GetCopy()
        {
            return (MyCopyableClass)MemberwiseClone();
        }
    }
}
