using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacosIterativos
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0; i<5; i++)
            {
                Console.WriteLine("Valor de i é: "+i);
            }

            int contador = 3;
            while(contador < 10)
            {
                Console.WriteLine(contador);
                contador++;
            }
            double j = 10;
            do
            {
                Console.WriteLine(j);
                j = j * 1.5;
            } while (j < 100);

            // Percorre todos 
            int[] conjunto = { 1, 2, 3, 4 };
            foreach(int numero in conjunto)
            {
                Console.WriteLine("Esse elemento do conjunto tem valor "+ numero + "Somando esse valor a 10 temos "+ (numero + 10));
            }
        }
    }
}
