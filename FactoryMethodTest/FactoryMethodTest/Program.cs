using FactoryMethodTest.Creator;
using FactoryMethodTest.ConcreteCreator;
using FactoryMethodTest.Product;
using System;

namespace FactoryMethodTest
{
    class Program
    {
        static void Main(string[] args)
        {
            
            RefriFactory refriFactory = null;

            Console.Write("Olá, tudo bem? Temos refrigerante em lata e na garrafa... Qual você deseja? ");
            string console = Console.ReadLine()!;
            Console.Write("Qual o sabor? ");
            string sabor = Console.ReadLine()!;
            Console.Write("Quantos você deseja? ");
            int quantidade = int.Parse(Console.ReadLine()!);
            

            switch (console.ToLower())
            {
                case "garrafa":
                    refriFactory = new GarrafaFactory("2L", sabor, quantidade, 10);               
                    break;
                case "lata":
                    refriFactory = new LataFactory("300ml", sabor, quantidade, 5);
                    break;
                default:
                    break;
            }
            //chamar o concrete creator
            //a partir dele que o produto será criado
            Refrigerante refrigerante = refriFactory.SolicitarRefrigerante();
            Console.WriteLine("\nOs detalhes do seu pedido estão abaixo: \n");
            Console.WriteLine("Refrigerante em {0}\nTamanho: {1}\nSabor: {2}\nQuantidade: {3}\nTotal: {4}",
                refrigerante.TipoRecipiente, refrigerante.TamanhoRecipiente, refrigerante.SaborRefrigerante, refrigerante.QuantidadeRefrigerante,
                refrigerante.ValorTotal);

        }
    }
}