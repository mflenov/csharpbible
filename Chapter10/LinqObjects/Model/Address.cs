using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqObjects.Model
{
    internal class Address
    {
        public int AddressID { get; set; }

        public int PersonID { get; set; }

        public string Name { get; set; }
    }
}
