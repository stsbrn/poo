using CadastroAnimaisExercicio.Entidades;
using System;
using System.Collections.Generic;

namespace CadastroAnimaisExercicio;

public class Aplicacao
{
    private readonly List<Animal> animais = new List<Animal>();

    public void Executar()
    {
        while (true)
        {
            ExibirMenu();
            var opcao = LerInteiro("Escolha uma opção: ");

            switch (opcao)
            {
                case 1:
                    CadastrarAnimal();
                    break;
                case 2:
                    ListarAnimais();
                    break;
                case 3:
                    BuscarAnimal();
                    break;
                case 4:
                    AlterarIdade();
                    break;
                case 5:
                    FazerAnimalEmitirSom();
                    break;
                case 0:
                    Console.WriteLine("Programa encerrado.");
                    return;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            Pausar();
        }
    }

    private static void ExibirMenu()
    {
        LimparConsole();
        Console.WriteLine("=== CADASTRO DE ANIMAIS ===");
        Console.WriteLine("1 - Cadastrar animal");
        Console.WriteLine("2 - Listar animais");
        Console.WriteLine("3 - Buscar animal");
        Console.WriteLine("4 - Alterar idade");
        Console.WriteLine("5 - Emitir som");
        Console.WriteLine("0 - Sair");
        Console.WriteLine();
    }

    private void CadastrarAnimal()
    {
        var nome = LerTexto("Digite o nome do animal: ");
        var idade = LerInteiro("Digite a idade do animal: ");
        string especie = LerTexto("Digite a espécie do animal: ");
        if (idade < 0)
        {
            Console.WriteLine("Idade inválida. O animal não pode ser cadastrado.");
            return;
        }

        var tutorNome = LerTexto("Digite o nome do tutor/responsável: ");
        var tutorTelefone = LerTexto("Digite o telefone do tutor/responsável: ");
        var tutor = new Tutor(tutorNome, tutorTelefone);

        var animal = new Animal(nome, especie, idade, tutor);
        animais.Add(animal);
        Console.WriteLine("Animal cadastrado com sucesso.");
        animal.ExibirDados();
    }

    private void ListarAnimais()
    {
        if (animais.Count == 0)
        {
            Console.WriteLine("Nenhum animal cadastrado.");
            return;
        }

        foreach (var animal in animais)
        {
            animal.ExibirDados();
        }
    }

    private void BuscarAnimal()
    {
        var nome = LerTexto("Digite o nome do animal a buscar: ");
        var achado = animais.Find(a => a.Nome.Contains(nome, StringComparison.OrdinalIgnoreCase));

        if (achado == null)
        {
            Console.WriteLine("Animal não encontrado.");
            return;
        }

        achado.ExibirDados();
    }

    private void AlterarIdade()
    {
        var nome = LerTexto("Digite o nome do animal cuja idade deseja alterar: ");
        var achado = animais.Find(a => a.Nome.Contains(nome, StringComparison.OrdinalIgnoreCase));

        if (achado == null)
        {
            Console.WriteLine("Animal não encontrado.");
            return;
        }

        var novaIdade = LerInteiro("Digite a nova idade: ");
        achado.AlterarIdade(novaIdade);
        achado.ExibirDados();
    }

    private void FazerAnimalEmitirSom()
    {
        var nome = LerTexto("Digite o nome do animal que deve emitir som: ");
        var achado = animais.Find(a => a.Nome.Contains(nome, StringComparison.OrdinalIgnoreCase));

        if (achado == null)
        {
            Console.WriteLine("Animal não encontrado.");
            return;
        }

        achado.EmitirSom();
    }

    private static string LerTexto(string mensagem)
    {
        while (true)
        {
            Console.Write(mensagem);
            var texto = Console.ReadLine()?.Trim();

            if (!string.IsNullOrWhiteSpace(texto))
            {
                return texto;
            }

            Console.WriteLine("O texto não pode ficar vazio.");
        }
    }

    private static int LerInteiro(string mensagem)
    {
        while (true)
        {
            Console.Write(mensagem);

            if (int.TryParse(Console.ReadLine(), out var numero))
            {
                return numero;
            }

            Console.WriteLine("Digite um número inteiro válido.");
        }
    }

    private static void Pausar()
    {
        Console.WriteLine("\nPressione Enter para continuar...");
        Console.ReadLine();
    }

    private static void LimparConsole()
    {
        try
        {
            Console.Clear();
        }
        catch (IOException)
        {
            // Permite executar o projeto com entrada redirecionada em testes.
        }
    }
}
