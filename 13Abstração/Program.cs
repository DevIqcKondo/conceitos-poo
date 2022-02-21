using System;

namespace _12Estatico
{
    class Program 
    {
        static void Main(string[]args)
        {
           // é uma classe que pode conter métodos obrigatóris para todas as classes que a herdarem;
           // é possível criar métodos convencionais (ñ obrigatório), para que as classes que herdem consigam utilizar;
           // Não é possível instanciar uma classe abstrata, exemplo: Produto prod = New Produto();
           //Padrão utilizado em projetos com muitos desenvolvedores pois garante uma estrutura pré-moldada com ações que podem ser realizadas;
           //Como é utilizada a herança , cada classe pode herdar apenas uma classe abstrata:
           //class Produto : PadraoProduto > Ok
           //class Produto : PadraoProduto, CalculoImpostos > Falha
           

           PessoaFisica pf = new PessoaFisica();
           pf.taxaEmprestimo(1000);

           PessoaJuridica pj =new PessoaJuridica();
           pj.taxaEmprestimo(1000);
        }
    }
}