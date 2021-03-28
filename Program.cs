using System;

namespace Exerc_cio_JurosSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Double Capital, Juros, Tempo, Juros_Simples, Result, Result2, Result3, Result4, Result5, Montante; 

            // Capital = c. 
            // Juros = i.
            // Tempo = t. 

            Console.WriteLine("Vamos calcular o montante final de juros simples (J), por favor digite as formações pedidas abaixo:"); 
        
            Console.WriteLine("Coloque o numero que sera utilizado no capital (C)");
            Capital = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Coloque o numero para ser utilizado na taxa de juros, em porcentgem (J)");
            Juros  = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Coloque um numero para utilizar o tempo, em meses (T)"); 
            Tempo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(); 

            Console.WriteLine("Juros simples, formula: j = c . i . t");

            Result = Capital;
            Result2 = Juros /100; 
            Result3 = Tempo;  

            Console.WriteLine($"J= {Result} . {Result2} . {Result3}");

            Result4 = Result * Result2; 
            Result5 = Result4 * Result3;

            Console.WriteLine($"J= {Result5}"); 

            Juros_Simples = Result5; 

            Console.WriteLine(); 

            Console.WriteLine("Vamos calcular o montante"); 
            Console.WriteLine("Montante, Formula: M = c + j");

            Montante = Result + Result5; 

            Console.WriteLine();

            Console.WriteLine($"M= {Montante}"); 


             











        }
    }
}
