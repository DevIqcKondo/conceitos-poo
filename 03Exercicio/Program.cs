using System;

namespace _03Exercicio
{
    class Program 
    {
        static void Main(string[]args)
        {
            // Instanciar objeto da classe Aluno

            Aluno x = new Aluno();
            x.nome = "Kondo";
            x.nota1 = 8;
            x.nota2 = 10;

            x.mensagem();
        }
    }
}