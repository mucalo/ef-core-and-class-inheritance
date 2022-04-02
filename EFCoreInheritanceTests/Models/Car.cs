using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreInheritanceTests.Models
{
    public class Car : Vehicle
    {
        public int TrunkSizeInCm3 { get; set; }
    }
}
