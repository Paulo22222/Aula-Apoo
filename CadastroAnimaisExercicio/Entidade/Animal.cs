namespace CadastroAnimaisExercicio;

public class Animal
{
	public string Nome { get; set; }
	public string Especie { get; set; }
	public int Idade { get; private set; }

	public override string ToString()
	{
		return $"{Nome} - {Especie} - {Idade} anos";
	}

	public void ExibirDados()
	{
		Console.WriteLine("Nome: " + Nome);
		Console.WriteLine("Espécie: " + Especie);
		Console.WriteLine("Idade: " + Idade + " anos");
	}


	public Animal(string nome, string especie, int idade)
	{
		Nome = nome;
		Especie = especie;
		Idade = idade;
	}

   public void EmitirSom()
    {
        Console.WriteLine($"{Nome} está emitindo um som característico da espécie {Especie}");
    }

    public void AlterarIdade(int novaIdade)
    {
        if (novaIdade >= 0)
        {
            Idade = novaIdade;
            Console.WriteLine($"A idade de {Nome} foi alterada para {Idade} anos.");
        }
        else
        {
            Console.WriteLine("A idade não pode ser negativa.");
        }
    }
}
