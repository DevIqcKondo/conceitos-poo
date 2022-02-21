using System;

namespace _11Polimorfismo
{
    class Program 
    {
        static void Main(string[]args)
        {
            // Instanciar Estagiario

            Imposto objetoE = new Estagiario();
            objetoE.valeAlimentacao(1000);
            objetoE.valeTranporte(1000);
            Console.WriteLine("-----------------");

            // Instanciar Atendente

            Imposto objetoG = new Gerente();
            objetoG.valeAlimentacao(5000);
            objetoG.valeTranporte(5000);
            Console.WriteLine("-----------------");

            // Instanciar Gerente

            Imposto objetoA = new Atendente();
            objetoA.valeAlimentacao(2000);
            objetoA.valeTranporte(2000);
            Console.WriteLine("-----------------");

        }
    }
}