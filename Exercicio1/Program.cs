using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro ("Chevrolet", "Camaro", "FLZ1234", "Amarelo", 00, true, 50, 240, 100000.00);
            Carro c2 = new Carro();
            Console.WriteLine("Hello World!");
            c1.status();
            Console.WriteLine("--------------------------------------------------------------");
            c2.status();


            c1.pintar("Amarelo");
            Console.WriteLine("--------------------------------------------------------------");
            c1.abastecer(50);
            Console.WriteLine("--------------------------------------------------------------");
            c1.status();
            Console.WriteLine("---------------------------------------------------------------");
            c2.status();
        }
    }
}
