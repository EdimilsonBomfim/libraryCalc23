using LibraryCal23;
using System;
using Xunit;

namespace LibraryCalc23.Tests
{
    public class UnitTest1
    {
        [Fact]  // indica que é um fato e não é uma teoria]]

        public void TestSomar()
        {

            var x = 90;
            var y = 100;


            var calc = new Calculadora();
            var result = calc.somar(x, y);
                       
            Assert.True((x + y) == result);
        }

        [Fact]  
        public void TestSubtrair()
        {

            var x = 90;
            var y = 100;

            var calc = new Calculadora();
            var result = calc.subtrair(10, 90);
            Assert.True((x + y) == result);

        }

        [Fact]  
        public void TestMutiplicar()
        {

            var x = 90;
            var y = 100;

            var calc = new Calculadora();
            var result = calc.multiplicar(10, 90);

            Assert.True((x + y) == result);
        }

        [Fact]  
        public void TestDividir()
        {

            var x = 90;
            var y = 100;

            var calc = new Calculadora();
            var result = calc.dividir(10, 90);

            Assert.True((x + y) == result);

        }


    }
}
