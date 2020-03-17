using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Net.Security;
using System;

namespace ExercicioPilaresClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var RemedioControlado = new controlado();
            RemedioControlado.nome = "Rivotril";
            RemedioControlado.preco = 100D;
            RemedioControlado.precoGoverno = 120D;
            RemedioControlado.exigeReceitaBranca = true;
            
            Console.WriteLine($"Remedio: {RemedioControlado.nome} Preco Governo {RemedioControlado.precoGoverno} Preco Praticado: {RemedioControlado.preco}");
            Console.WriteLine($"Desconto Praticado {RemedioControlado.DescontoPraticado}");
            Console.WriteLine($"Exige Receita? {PegarReceita(RemedioControlado)}");
        }

        public string PegarReceita(controlado RemedioProd)
        {
            if (RemedioProd.exigeReceitaBranca) 
            {
                return "Sim";
            }
            else
            {
                return "Não";
            }
        }
    }
}
