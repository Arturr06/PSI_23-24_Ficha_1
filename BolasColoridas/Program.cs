using System;

namespace BolasColoridas
{
    class Program
    {
        static void Main(string[] args)
        {
            Bola a = new Bola(2, new Cor(25, 37, 41));
            Bola b = new Bola(35, new Cor(27, 41, 53));
            Bola c = new Bola(12, new Cor(8, 24, 35));
            Bola d = new Bola(6, new Cor(12, 55, 43));
            Bola z = new Bola(9, new Cor(2, 5, 34));

            Console.WriteLine("A bola A foi atirada. ");
            a.Atirar();
            Console.WriteLine("A bola B foi atirada. ");
            b.Atirar();
            Console.WriteLine("A bola C foi atirada. ");
            c.Atirar();
            Console.WriteLine("A bola D foi atirada. ");
            d.Atirar();
            Console.WriteLine("A bola Z foi atirada. ");
            z.Atirar();

            Console.WriteLine("A bola A foi rebentada. ");
            a.Pop();
            Console.WriteLine("A bola B foi rebentada. ");
            b.Pop();
            Console.WriteLine("A bola C foi rebentada. ");
            c.Pop();
            Console.WriteLine("A bola D foi rebentada. ");
            d.Pop();
            Console.WriteLine("");

            Console.WriteLine("A bola A tem:");
            Console.WriteLine("");
            Console.WriteLine($"Cor: {a.GetCor()}");
            Console.WriteLine("");
            Console.WriteLine($"Raio: {a.GetRaio()}");
            Console.WriteLine("");
            Console.WriteLine("A bola B tem:");
            Console.WriteLine("");
            Console.WriteLine($"Cor: {b.GetCor()}");
            Console.WriteLine("");
            Console.WriteLine($"Raio: {b.GetRaio()}");
              Console.WriteLine("");
            Console.WriteLine("A bola C tem:");
            Console.WriteLine("");
            Console.WriteLine($"Cor: {c.GetCor()}");
            Console.WriteLine("");
            Console.WriteLine($"Raio: {c.GetRaio()}");
              Console.WriteLine("");
            Console.WriteLine("A bola D tem:");
            Console.WriteLine("");
            Console.WriteLine($"Cor: {d.GetCor()}");
            Console.WriteLine("");
            Console.WriteLine($"Raio: {d.GetRaio()}");
            Console.WriteLine("");
            Console.WriteLine("A bola Z tem:");
            Console.WriteLine("");
            Console.WriteLine($"Cor: {z.GetCor()}");
            Console.WriteLine("");
            Console.WriteLine($"Raio: {z.GetRaio()}");

        }
    }
}
