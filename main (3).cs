using System;

namespace ConsoleApp4 
{
    class Program 
    {
        static void Main(String[] args) 
        {
            int normal;
            int estudante;
            int acessivel;
            int publicoTotal;
            
            Console.WriteLine("Quantos ingressos do grupo Normal foram vendidos?");
            normal = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantos ingressos do grupo Estudante foram vendidos?");
            estudante = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantos ingressos do grupo Acessível foram vendidos?");
            acessivel = int.Parse(Console.ReadLine());
            
            publicoTotal = normal + estudante + acessivel;
            Console.WriteLine("O publico total do evento é de " + publicoTotal);
            
        }
    }
}