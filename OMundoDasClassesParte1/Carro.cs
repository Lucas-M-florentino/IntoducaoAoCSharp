using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMundoDasClassesParte1
{
    public class Carro
    {
        // atributos cridos apenas com metodo get permite que os valores sejam atribuidos quando criado o objeto
        public Cor Cor { get; }
        public int Portas { get; }
        public string Modelo { get; }
        private bool ligado = false;

        // propriedade: define uma maneira de acessar os atributos
        public bool Ligado
        {
            get
            {
                return ligado;
            }
        }

        public Carro(Cor cor, int portas, string modelo)
        {
            Cor = cor;
            Portas = portas;
            Modelo = modelo;
        }

        //comportamento do carro
        public string Ligar()
        {
            ligado = true;
            return "O carro foi ligado.";
        }

        public string Desligar()
        {
            ligado = false;
            return "O carro foi desligado.";
        }

        public string Andar()
        {
            return "O carro está andando.";
        }

    }
}
