using System.Dynamic;
using System.Globalization;
using c__04.Models;

Curso curso001 = new Curso();
curso001.Alunos = new List<Pessoa>();
bool menu = true;

while (menu)
{
    Console.WriteLine("Bem vindo, selecione sua opção");
    Console.WriteLine("1 - Cadastrar alunos");
    Console.WriteLine("2 - Criar Curso");
    Console.WriteLine("3 - Ver lista de alunos");
    Console.WriteLine("4 - Encerrar");
    string opção = Console.ReadLine();
    Console.Clear();

    switch (opção)
    {
        case "1": 

            Console.WriteLine("Digite seu nome");
            Pessoa pessoa01 = new Pessoa();
            pessoa01.Nome = Console.ReadLine();
            Console.WriteLine("Digite seu sobrenome");
            pessoa01.Sobrenome = Console.ReadLine();
            curso001.AdicionarAlunos(pessoa01);
        
        break;

        case "2":
            
            Console.WriteLine("Digite o nome do curso");
            curso001.Nome = Console.ReadLine();
            
        break;

        case "3":

            curso001.ListarAlunos();
        
        break;

        case "4":

            Console.WriteLine("Encerrar");
            menu = false;

        break;

        default: 

            Console.WriteLine("Opção inválida, tente novamente!");
        
        break;
        
    }

}
