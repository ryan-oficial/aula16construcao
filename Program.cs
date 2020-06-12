using System;

namespace Aula16Construçao
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto sapato = new Produto();

            Produto chinelo = new Produto(789);
            System.Console.WriteLine(chinelo.Codigo);

            System.Console.WriteLine();

            Produto tenis = new Produto(678, "All Star", "Couro", 45);
            System.Console.WriteLine(tenis.Codigo);
            System.Console.WriteLine(tenis.Nome);
            System.Console.WriteLine(tenis.Descricao);
            System.Console.WriteLine(tenis.Estoque);
        }
    }
}
