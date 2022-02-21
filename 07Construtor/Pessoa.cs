using System;

class Pessoa 
{

    // Construtor (público)

    public Pessoa()
    {
        Console.WriteLine("Construtor executado");
    }


    public Pessoa(string nome)
    {
        Console.WriteLine("Olá "+nome);
    }

}