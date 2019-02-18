using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insure_It_All
{
    class Policy
    {
        public string PolicyID { get; set; }
        public string HolderTitle { get; set; }
        public string HolderName { get; set; }
        public DateTime PolicyStart { get; set; }
        public double Premium { get; set; }
        public List<Driver> Drivers = new List<Driver>();

        public Policy() { }
    }
}
