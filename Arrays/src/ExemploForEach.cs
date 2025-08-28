using System;
namespace Arrays
{

    public class Exemploforeach
    {
        public static void main()
        {
            int[] array = { 23, 12, 43, 51, 67, 86, 18, 42, 76, 98 };

            // Percorrendo com um for
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "-");
            }
            Console.WriteLine(); 

            // Percorrendo com um while
            int j = 0;
            while (j < array.Length)
            {
                Console.Write(array[j] + "-");
                j++;
            }
            Console.WriteLine();

            // Percorrendo com foreach
            foreach (int elemento in array)
            {
                Console.Write(elemento + "-");
            }
            Console.WriteLine();



            // Podemos utilizar var no lugar do tipo
            foreach (var elemento in array)
            {
                Console.Write(elemento + "-");
            }
            Console.WriteLine();
        }
    }
}
