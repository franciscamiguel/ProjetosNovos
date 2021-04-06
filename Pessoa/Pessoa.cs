using System;
using System.Collections.Generic;
using System.Text;

namespace Pessoa
{
    public class Pessoa
    {
        public void ExibirPessoa()
        {
            string nome;
            int idade;
            string sexo;
            Console.WriteLine("informe o seu nome ");
            nome = Console.ReadLine();
            Console.WriteLine("informe a sua idade");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("informe seu sexo");
            sexo = Console.ReadLine();
            Console.WriteLine("o nome é:" + nome + "idade é:" + idade + "sexo é:" + sexo);
            Console.ReadKey();
        }

    }
}
