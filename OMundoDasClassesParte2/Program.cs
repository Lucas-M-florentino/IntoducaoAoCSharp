using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMundoDasClassesParte2
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Cachorro("Rex", 5);
            var g = new Gato("Ana", 3);

            Animal a = new Gato("Felix", 5); // polimorfismo

            ExibeAnimal(c); // argumento do tipo Cachorro
            ExibeAnimal(g); // tipo Gato
            ExibeAnimal(a); // tipo Animal

        }

        public static void ExibeAnimal(Animal animal)
        {
            Console.WriteLine($"Nome: {animal.Nome}");
            Console.WriteLine($"Idade: {animal.Idade}");
            Console.WriteLine($"Som emitido: {animal.SomEmitido}");
            Console.WriteLine($"Locomoção: {animal.Locomocao}");
        }
    }
}
