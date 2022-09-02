using dontnet_vsc.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "Gustavo";
p1.Sobrenome = "Soares";
p1.Idade = 18;

Pessoa p2 = new Pessoa(nome: "Edu", sobrenome: "Silvaa");
p2.Idade = 19;

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();
Console.WriteLine(cursoDeIngles.ObterQuantidadesDeAlunosMatriculados());






// Pessoa p1 = new Pessoa();
// p1.Nome = "Gustavo";
// p1.Idade = 18;

// Pessoa p2 = new Pessoa();
// p2.Nome = "Francisca";
// p2.Idade = 53;

// p1.Apresentar();
// p2.Apresentar();

