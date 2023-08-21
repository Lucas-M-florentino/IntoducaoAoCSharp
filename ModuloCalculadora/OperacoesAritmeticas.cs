using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloCalculadora
{
    /// <summary>
    /// Classe com as operações matemáticas básicas de adição, subtração, multiplicação e divisão.
    /// </summary>
    public static class OperacoesAritmeticas //Classes estáticas: não podem ser instanciadas, não pode herdar nem ser herdada, só pode conter membros estáticos
    {
        /// <summary>
        /// Operacao básica de adição
        /// </summary>
        /// <param name="parcela1">A primeira parcela</param>
        /// <param name="parcela2">A segunda parcela</param>
        /// <returns>A soma dos números informados</returns>
        public static double Adicao(double parcela1, double parcela2)
        {
            return parcela1 + parcela2;
        }

        /// <summary>
        /// Operação básica de subtração
        /// </summary>
        /// <param name="minuando">O minuendo</param>
        /// <param name="subtraendo">O subtraendo</param>
        /// <returns>A subtração dos números informados</returns>
        public static double Subtracao(double minuando, double subtraendo)
        {
            return minuando - subtraendo;
        }

        /// <summary>
        /// Operação básica de Multiplicação
        /// </summary>
        /// <param name="multiplicando">O multiplicando</param>
        /// <param name="multiplicador">O multiplicador</param>
        /// <returns>A Multiplicação dos números informados</returns>
        public static double Multiplicacao(double multiplicando, double multiplicador)
        {
            return multiplicando * multiplicador;
        }

        /// <summary>
        /// Operação básica de Divisão
        /// </summary>
        /// <param name="multiplicando">O dividendo</param>
        /// <param name="multiplicador">O divisor</param>
        /// <returns>A Divisão dos números informados</returns>
        public static double Divisao(double dividendo, double divisor)
        {
            return dividendo / divisor;
        }
    }
}
