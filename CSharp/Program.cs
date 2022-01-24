using System;
using Interface;
using Enum;





namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa1 = (Pessoas)0;
            Pessoas pessoa2 = Pessoas.José;
            Pessoas pessoa3 = (Pessoas)4;

            Pessoa person = new Pessoa();

            person.Nome = "Leonardo";
            person.idade = 26;
            person.Estado = "ES";

            var person2 = new Pessoa();

            person2.Nome = "Julia";
            person2.idade = 25;
            person2.Estado = "SP";

            Animal animal = new Animal();

            animal.Nome = "Max";
            animal.nomeDono = "Leonardo";
            animal.Especie = "Canino";
            
            var classe = new Primeiro.Classe();
            var classe2 = new Segundo.Classe();

            Console.WriteLine(pessoa2);

        
        }
    }
}
