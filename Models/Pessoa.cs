using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dontnet_vsc.Models
{
    public class Pessoa
    {
        public Pessoa() // dois contrutores para um valor padrão caso o usuário ou sistema não tenha a informação ainda
        {

        }
        public Pessoa(string nome, string sobrenome) // construtor que requer a informação do user
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        private string _nome;
        private int _idade;
        public string Nome 
        { 
            get => _nome.ToUpper();
            
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            }
        }
        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}";
        public int Idade 
        { 
            get => _idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Idade não pode ser abaixo de 0");
                }
                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, idade: {_idade}");
        }
    }
}