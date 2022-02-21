using System;

namespace _01conceitos 
{
    class Program 
    {
        static void Main(string[]args)
        {
            // Instanciar um objeto
            Pessoa obj = new Pessoa();
            obj.nome = "Kondo";
            obj.idade = 20;
            obj.mensagem();
        }
    }
}