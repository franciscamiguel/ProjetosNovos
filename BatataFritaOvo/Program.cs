using System;

namespace BatataFritaOvo
{
    class Program
    {
        static void Main(string[] args)
        {

            string pegoubatata;
            string pegouovo;
            string lavei;
            string cascou;              
            string cortei;
            string secou;
            string fritou;
            string colocounopapeltoalha;
            string comeu;

            Console.WriteLine("informe a batata");
            pegoubatata = Console.ReadLine();

            Console.WriteLine("informe o ovo");
            pegouovo = Console.ReadLine();

          
            Console.WriteLine("informe lavei");
            lavei = Console.ReadLine();

            Console.WriteLine("informe cortei");
            cortei = Console.ReadLine();

            Console.WriteLine("informe secou");
            secou = Console.ReadLine();

            Console.WriteLine("informe fritou");
            fritou = Console.ReadLine();
            Console.WriteLine("colocounopapeltoalha");
            colocounopapeltoalha = Console.ReadLine();

            Console.WriteLine("informe comeu");
            comeu = Console.ReadLine();

            Console.WriteLine(" pegoubatata: " + pegoubatata + " pegouovo " + pegouovo +
                 " lavei" + lavei + " cortei" + cortei + " secou " + secou + " fritou " + fritou +
                " colocounopapeltoalha" + colocounopapeltoalha + " comeu " + comeu );
            Console.ReadKey();




        }
    }
}
