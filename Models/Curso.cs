using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dontnet_vsc.Models
{
    public class Curso
    {
        
        private List<Pessoa> _alunos;
        public string Nome { get; set; }
        public List<Pessoa> Alunos 
        { 
            get => _alunos;

            set
            {
                if(value == null){
                    throw new ArgumentException("Não há aluno");
                }
                _alunos = value;
            }
        }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadesDeAlunosMatriculados()
        {
            int quantidade = _alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return _alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            foreach(Pessoa aluno in _alunos)
            {
                Console.WriteLine($"Nome: {aluno.NomeCompleto} | Idade: {aluno.Idade}");
            }
        }
    }
}