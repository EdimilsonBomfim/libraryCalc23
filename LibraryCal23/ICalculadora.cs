using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCal23
{

    /// <summary>
    /// Interface para calcular valores com as 4 operaçoes
    /// </summary>
    public interface ICalculadora
    {

        /// <summary>
        /// Metdo para somar 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        int somar(int x, int y);


        /// <summary>
        /// metodo para subtrair
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        int subtrair(int x, int y);


        /// <summary>
        /// metodo para mutiplicar
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        int multiplicar(int x, int y);

        /// <summary>
        /// metodo para dividir
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        int dividir(int x, int y);

    }
}
