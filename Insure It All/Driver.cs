using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insure_It_All
{
    class Driver
    {
        public string Name { get; set; }
        public string Occupation { get; set; }
        public DateTime DOB { get; set; }
        public List<Claim> Claims = new List<Claim>();

        public Driver() { }
    }
}
