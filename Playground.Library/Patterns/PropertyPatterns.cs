using Playground.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Library.Patterns
{
   public  class PropertyPatterns
    {
        public bool IsParachutePerformanceDesigns(Parachute parachute) => parachute is { Manufacturer: ParachuteManufacturer.PerformanceDesigns };
        public bool IsParachuteSub100(Parachute parachute) => parachute is { Squarefeet:  < 100};
    }
}
