using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroAnimaisExercicio.Entidades
{
    public class Animal
    {
        public string Nome;
        public string Especie;
        public int Idade;

        public void ExibirDados() 
        {
            Console.WriteLine("Animal cadastrado " + Nome + " - " + Especie + " - " + Idade + " anos");
        }
    }
}
