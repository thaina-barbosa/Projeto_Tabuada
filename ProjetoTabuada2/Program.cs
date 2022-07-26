using System;

namespace ProjetoTabuada2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, resultado;
            
            Console.WriteLine("Digite o numero da tabuada: ");
            numero = Int16.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                resultado = numero * i;              
                Console.WriteLine(String.Format("{0} x {1} = {2}", numero, i, resultado));
            }
            
        }
    }
} 
