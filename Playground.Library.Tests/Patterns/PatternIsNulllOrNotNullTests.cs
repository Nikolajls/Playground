using FluentAssertions;
using Playground.Library.Patterns;
using System;
using Xunit;

namespace Playground.Library.Tests
{
    public class PatternIsNulllOrNotNullTests
    {
        private readonly PatternIsNulllOrNotNull _sut;
        public PatternIsNulllOrNotNullTests()
        {
            _sut = new();
        }

        [Fact]
        public void ItShould_ReturnTrue_WhenTestingForNullAndNull()
        {
            var res = _sut.IsNull(null);
            res.Should().BeTrue();
        }

        [Fact]
        public void ItShould_ReturnFalse_WhenTestingForNullAndHasValue()
        {
            var res = _sut.IsNull(1);
            res.Should().BeFalse();
        }

        [Fact]
        public void ItShould_ReturnTrue_WhenTestingForValueAndValueProvided()
        {
            var res = _sut.IsNotNull(1);
            res.Should().BeTrue();
        }

        [Fact]
        public void ItShould_ReturnFalse_WhenTestingForValueAndValueNull()
        {
            var res = _sut.IsNotNull(null);
            res.Should().BeFalse();
        }
    }
}
