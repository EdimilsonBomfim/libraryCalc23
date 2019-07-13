using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCal23
{
    public class Calculadora : ICalculadora
    {
        public int dividir(int x, int y)
        {
            return x / y;
        }

        public int multiplicar(int x, int y)
        {
            return x * y;
        }

        public int somar(int x, int y)
        {
            return x + y;
        }

        public int subtrair(int x, int y)
        {
            return x - y;
        }
    }
}
