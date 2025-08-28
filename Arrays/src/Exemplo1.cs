using System;
namespace Arrays
{
    public class Exemplo1
    {
        public static void main()
        {
            // Declarando:
            int[] arrayA;
            int[] arrayB; // Em C# não usamos a sintaxe "int arrayB[]"

            // Instanciando:
            arrayA = new int[5];
            int[] arrayC = new int[5]; // declaração + instancia

            // Inicialização:
            int[] arrayD = { 1, 2, 3, 4, 5 };       // instancia implícita
                                                    // arrayB = {1,2,3,4,5};                // Não podemos inicializar assim fora da declaração

            char[] arrayChar = new char[3];
            double[] arrayDouble = new double[3];
            bool[] arrayBoolean = new bool[3]; // Em C# é "bool" em vez de "boolean"

            Console.WriteLine("array inteiro é inicializado com " + arrayA[0]);
            Console.WriteLine("array de caracter é inicializado com '" + arrayChar[0] + "'"); // Char vazio
            Console.WriteLine("array decimal é inicializado com " + arrayDouble[0]);
            Console.WriteLine("array boolean é inicializado com " + arrayBoolean[0]);

            // Atribuição:
            arrayB = arrayD;        // Se for para receber um array já inicializado, não precisa instanciar o array
            arrayD[3] = 100;        // alterar arrayD significa alterar arrayB

            Console.WriteLine("ArrayB: " + arrayB[0] + ", " + arrayB[1] + ", " + arrayB[2] + ", " + arrayB[3] + ", " + arrayB[4]);
            Console.WriteLine("ArrayD: " + arrayD[0] + ", " + arrayD[1] + ", " + arrayD[2] + ", " + arrayD[3] + ", " + arrayD[4]);
        }
    }
}