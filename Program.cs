using System;

namespace NomeCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string Nome;
            string Sobrenome;
            String NomeCompleto;
            string nomeCatalogo;
            
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Veja seu nome em diferentes perpectivas");
            Console.WriteLine("---------------------------------------");
            
            Console.Write("Digite seu nome:");
            Nome = Console.ReadLine();

            Console.Write("Digite seu sobrenome:");
            Sobrenome = Console.ReadLine();

            NomeCompleto = $"{Nome} {Sobrenome}";
            nomeCatalogo = $"{Sobrenome.ToUpper()} , {Nome}";

            Console.WriteLine($"Nome completo: {NomeCompleto}");
            Console.WriteLine($"Nome de Catálogo: {nomeCatalogo}");



        }
    }
}
