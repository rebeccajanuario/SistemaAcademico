using System;
using SistemaAcademico.Model;

namespace SistemaAcademico
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno objAluno = new Aluno(); //Aluno() método construtor
            Professor joao = new Professor();
            int x;            
            objAluno.cpf = 44328063870;
            objAluno.dataNascimento = DateTime.Parse("25/09/1990");
            joao.cpf = 221323;
            objAluno.nome = "Maria";
            joao.nome = "João Pedro";

            Console.WriteLine(objAluno.cpf);
            Console.WriteLine(objAluno.nome);
            Console.WriteLine(objAluno.dataNascimento.ToString("dd/MM/yyyy"));
            Console.ReadKey();
        }
    }
}
