using System;
using System.Collections.Generic;
using System.Text;

namespace Veiculo
{
    public class Veiculo
    {
        public void ImprimirVeiculo()
        {
            string nome;
            string fabricante;
            string cor;
            string potencia;
            string proprietario;

            Console.WriteLine("informe o nome ");
            nome = Console.ReadLine();

            Console.WriteLine("informe o fabricante");
            fabricante = Console.ReadLine();

            Console.WriteLine("informe a cor");
            cor = Console.ReadLine();

            Console.WriteLine("informe a potencia");
            potencia = Console.ReadLine();

            Console.WriteLine("informe o proprietario");
            proprietario = Console.ReadLine();

            Console.WriteLine(" o nome é: " + nome + " fabricante: " + fabricante
                + " cor: " + cor + " potencia; " + potencia + " proprietario: " + proprietario);
            Console.ReadKey();
        }
    }
}
