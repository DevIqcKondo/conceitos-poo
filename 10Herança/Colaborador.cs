using System;

class Colaborador : Pessoa
{
    // Atributos

    private double salario;

    // Construtor

    public Colaborador(string nome, int idade, double salario)
    {
        this.nome = nome;
        this.salario = salario;
        this.idade = idade;

        mensagemPessoa();
        mensagemColaborador();
    }
    // Método

    private void mensagemColaborador()
    {
        Console.WriteLine("Salário: "+salario);
    }
}