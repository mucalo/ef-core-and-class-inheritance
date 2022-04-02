using EFCoreInheritanceTests.Commons.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreInheritanceTests.Models
{
    public class Motorbike : Vehicle
    {
        public RacingClass RacingClass { get; set; }
    }
}
