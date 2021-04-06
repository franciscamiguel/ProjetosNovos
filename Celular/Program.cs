using System;

namespace Celular
{
    class Program
    {
        static void Main(string[] args)
        {
            string modelo;
            string marca;
            string cor;
            string peso;
            string memoria;
            Console.WriteLine("informe o modelo");
            modelo = Console.ReadLine();

            Console.WriteLine("informe a marca");
            marca = Console.ReadLine();

            Console.WriteLine("informe a cor");
            cor = Console.ReadLine();

            Console.WriteLine("informe o peso");
            peso = Console.ReadLine();

            Console.WriteLine("informe a memoria");
            memoria = Console.ReadLine();

            Console.WriteLine(" modelo: "+ modelo+ " marca: "+ marca+ " cor "+ cor+ " peso: " +
            peso+ " memoria: "+ memoria);
            Console.ReadKey();

        }
    }
}
