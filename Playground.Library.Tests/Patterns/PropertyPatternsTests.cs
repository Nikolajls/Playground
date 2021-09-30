using FluentAssertions;
using Playground.Library.Patterns;
using Playground.Models;
using System;
using Xunit;

namespace Playground.Library.Tests
{
    public class PropertyPatternsTests
    {
        private readonly PropertyPatterns _sut;
        public PropertyPatternsTests()
        {
            _sut = new();
        }


        public class WhenIsParachuteSub100IsCalled : PropertyPatternsTests
        {

            [Fact]
            public void ItShould_ReturnTrue_WhenSquarefeetBelow100()
            {
                _sut.IsParachuteSub100(new Parachute() {Squarefeet = 80}).Should().BeTrue();
            }

            [Fact]
            public void ItShould_ReturnFalse_WhenSquarefeetAbove99()
            {
                _sut.IsParachuteSub100(new Parachute() { Squarefeet = 100 }).Should().BeFalse();
            }
        }

        public class WhenIsParachutePerformanceDesignsIsCalled : PropertyPatternsTests
        {
            [Fact]
            public void ItShould_ReturnTrue_WhenPDParachute()
            {
                _sut.IsParachutePerformanceDesigns(new Parachute() { Manufacturer = ParachuteManufacturer.PerformanceDesigns }).Should().BeTrue();
            }

            [Fact]
            public void ItShouldNot_ReturnTrue_WhenFluidWings()
            {
                _sut.IsParachutePerformanceDesigns(new Parachute() { Manufacturer = ParachuteManufacturer.FluidWings }).Should().BeFalse();
            }
        }
    }
}
