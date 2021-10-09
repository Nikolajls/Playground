using System;

namespace Playground.Models
{
    public class Parachute
    {
        public ParachuteManufacturer Manufacturer { get; set; }
        public string Name { get; set; }

        public string SerialNo { get; set; }
        public int Squarefeet { get; set; }
        public bool Crossbraced { get; set; }
    }

    public enum ParachuteManufacturer
    {
        PerformanceDesigns,
        FluidWings,
        NZ
    }
}
