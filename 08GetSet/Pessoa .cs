using System;

class Pessoa 
{
    // Atributo nome

    private string nome;

    // Get pega o valor --- Set envia o valor
    // Todo método Get e Set é público

    public string Nome 
    {
        get{return nome;}
        set{nome=value;}
    }


}