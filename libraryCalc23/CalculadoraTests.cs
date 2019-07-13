using System;
using Xunit;

namespace libraryCalc23
{
    public class CaculadoraTests
    {
        [Fact]
        [Theory] // verificar 
        [InlineData(1, 2)]
        [InlineData(10, 30)]
        [InlineData(200, 4)]
        [InlineData(1, 20)]
        [InlineData(740, 3)]

        public void Test1( int x, int y)
        {
            var Calculadora = new Calculadora();

        }
    }
}
