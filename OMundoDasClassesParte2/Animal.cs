using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMundoDasClassesParte2
{
    public abstract class Animal // não pode ser instanciada
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public abstract Som SomEmitido { get;  } // essa propriedade deverá ser implementada pela classe filha
        public virtual string Locomocao { get { return "Está andando!"; } } // essa propriedade poderá ou não ser sobreescrita nas classes filhas

        public Animal(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

    }
}
