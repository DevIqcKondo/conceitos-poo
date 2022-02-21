using System;

class Pessoa
{
    // Atrubuto 

    private string nome = "Kondo";

    // Construtor

    public Pessoa(string nome)
    {
        Console.WriteLine(nome);
        Console.WriteLine(this.nome);
    }
}