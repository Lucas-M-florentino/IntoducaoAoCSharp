using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacosCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            //int hora = 18;
            //if (hora >= 15) Console.WriteLine("Já são 15h ou mais");

           // else if (hora <= 17) Console.WriteLine("A hora é menor ou igual 17!");

            //else
            //{
            //    Console.WriteLine("Já passou das 17h!");
            //}

            PrimeiroSemestre mes = PrimeiroSemestre.Maio;
            switch(mes)
            {
                case PrimeiroSemestre.Janeiro:
                    Console.WriteLine("Estamos em Janeiro");
                    break;
                case PrimeiroSemestre.Fevereiro:
                    Console.WriteLine("Estamos em Fevereiro");
                    break;
                case PrimeiroSemestre.Março:
                    Console.WriteLine("Estamos em Março");
                    break;
                case PrimeiroSemestre.Abril:
                    Console.WriteLine("Estamos em Abril");
                    break;
                case PrimeiroSemestre.Maio:
                    Console.WriteLine("Estamos em Maio");
                    break;
            }

            
        }

        public enum PrimeiroSemestre
        {
            Janeiro, Fevereiro, Março, Abril, Maio, Junho
        }
    }
}
