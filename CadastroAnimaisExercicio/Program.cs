using System;
using CadastroAnimaisExercicio;

public class Program
{
    public static void Main()
    {
        var exemplo = new Animal("Bob", "Cachorro", 4);
        Console.WriteLine("Animal exemplo:");
        exemplo.ExibirDados();

        var aplicacao = new Aplicacao();
        aplicacao.Executar();
    }
}

public class Aplicacao
{
    public void Executar()
    {
        var animal = new Animal("Rex", "Cachorro", 3);
        animal.ExibirDados();
    }
}
