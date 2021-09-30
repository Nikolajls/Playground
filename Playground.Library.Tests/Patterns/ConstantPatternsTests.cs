using FluentAssertions;
using Playground.Library.Patterns;
using System;
using Xunit;

namespace Playground.Library.Tests
{
    public class ConstantPatternsTests
    {
        private readonly ConstantPatterns _sut;
        public ConstantPatternsTests()
        {
            _sut = new();
        }

        [Fact]
        public void ItShould_MapNumbers_WhenValuesWithinRange()
        {
            _sut.GetNumberName(1).Should().Be("One");
            _sut.GetNumberName(2).Should().Be("Two");
            _sut.GetNumberName(3).Should().Be("Three");
            _sut.GetNumberName(4).Should().Be("Four");
            _sut.GetNumberName(5).Should().Be("Five");
        }

        [Fact]
        public void ItShould_ThrowException_WhenValueNotInRange()
        {
           Assert.Throws<ArgumentException>(() => _sut.GetNumberName(6));

            Action act = () => _sut.GetNumberName(6);

            act.Should().Throw<ArgumentException>();

        }
    }
}
