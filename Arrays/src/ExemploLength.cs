using System;
namespace Arrays{
    public class ExemploLength
    {
        public static void main()
        {
            double[] numeros = { 1.1, 3.2, 5.2, 5.6 };
            double soma = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }

            Console.WriteLine("Soma: " + soma);
        }
    }
}