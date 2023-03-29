﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HelloXUnit.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void AddTests()
        {
            Assert.Equal(4, Calculator.Add(2, 2));
        }

        [Fact]
        public void SubtractTests()
        {
            Assert.Equal(1, Calculator.Subtract(3, 2));
        }

        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        public void IsOddWhenTrue(int value)
        {
            Assert.True(Calculator.IsOdd(value));
        }

        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        public void IsOddWhenFalse(int value)
        {
            Assert.False(Calculator.IsOdd(value));
        }
    }
}
