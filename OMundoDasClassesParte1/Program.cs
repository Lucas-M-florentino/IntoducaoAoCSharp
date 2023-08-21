using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMundoDasClassesParte1
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro(Cor.Branco, 4, "Gol G6");

            Console.WriteLine("O carro é um " + carro.Modelo + " de cor " + carro.Cor + " e tem " + carro.Portas + " portas.");

            Console.WriteLine(carro.Ligar());
            Console.WriteLine("Ligado? "+ carro.Ligado);
            Console.WriteLine(carro.Andar());

       

            Console.WriteLine(carro.Desligar());
            Console.WriteLine("Ligado? "+ carro.Ligado);
        }
    }
}
