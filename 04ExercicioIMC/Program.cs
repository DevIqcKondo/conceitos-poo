using System;

namespace _04ExercicioIMC
{
    class Program 
    {
        static void Main(string[]args)
        {
            // Instanciar um objeto

            Pessoa p = new Pessoa();
            p.peso = 60;
            p.altura = 1.76;
            p.mensagem();
        }
    }
}