using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroAnimaisExercicio.Entidades
{
    public class Animal
    {
        public string Nome { get; private set; }
        public string Especie { get; private set; }
        public int Idade { get; private set; }
        public Tutor Tutor { get; private set; }

        public Animal(string nome, string especie, int idade, Tutor tutor)
        {
            Nome = nome;
            Especie = especie;
            Idade = idade;
            Tutor = tutor ?? throw new ArgumentNullException(nameof(tutor));
        }

        public void AlterarIdade(int novaIdade)
        {
            if (novaIdade < 0)
            {
                Console.WriteLine("Idade inválida. A idade não pode ser negativa.");
                return;
            }

            Idade = novaIdade;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Animal cadastrado {Nome} - {Especie} - {Idade} anos");
            if (Tutor != null)
            {
                Console.WriteLine($"Tutor: {Tutor.Nome} - Telefone: {Tutor.Telefone}");
            }
        }

        public void EmitirSom()
        {
            Console.WriteLine(Nome + " está emitindo um som.");
        }
    }
}

