using System;

namespace Arrays
{

    public class ExemploVendas
    {
        public static void main()
        {
            /*
            Dados os seguintes valores:
                    |São Carlos     |Araraquara     |Rio Claro      |Ribeirão Preto |
            Panelas |        8000.00|           0.00|        1000.00|        6000.00|
            Copos   |        3000.00|        3000.00|        3000.00|        9000.00|
            Pratos  |        7000.00|        6000.00|        2000.00|        6000.00|
            Talheres|        5000.00|        1000.00|           0.00|        4000.00|
            Xícaras |        6000.00|        9000.00|        1000.00|        8000.00|

            Calcule o total de vendas por cidades e o total de vendas por produtos.
             */

            // Um array deve ter somente um tipo de informação, assim temos que quebrar a tabela em 3 partes
            // 1a parte: os valores:
            double[][] valores = new double[][]
            {
            new double[] { 8000.0, 0.0, 1000.0, 6000.0 },
            new double[] { 3000.0, 3000.0, 3000.0, 9000.0 },
            new double[] { 7000.0, 6000.0, 2000.0, 6000.0 },
            new double[] { 5000.0, 1000.0, 0.0, 4000.0 },
            new double[] { 6000.0, 9000.0, 1000.0, 8000.0 }
            };

            // 2a parte: os rótulos das colunas
            string[] cidades = { "São Carlos", "Araraquara", "Rio Claro", "Ribeirão Preto" };

            // 3a parte: os rótulos das linhas
            string[] produtos = { "Panelas", "Copos", "Pratos", "Talheres", "Xícaras" };

            // Calculando o total de vendas por cidade:
            Console.WriteLine("Total de vendas por cidade:");

            // As cidades são as colunas, então para cada coluna, vamos somar todas as linhas
            for (int coluna = 0; coluna < cidades.Length; coluna++)
            {
                Console.Write(cidades[coluna] + " : ");
                // Vamos somar todas as linhas de valores para calcular o total vendido:
                double soma = 0;
                for (int linha = 0; linha < produtos.Length; linha++)
                {
                    soma += valores[linha][coluna];
                }
                Console.WriteLine(soma.ToString("N2"));
            }

            // Calculando o total de vendas por produto
            Console.WriteLine("\nTotal de vendas por produtos:");
            for (int linha = 0; linha < produtos.Length; linha++)
            {
                Console.Write(produtos[linha] + " : ");
                // Vamos somar todas as colunas de valores para calcular o total vendido:
                double soma = 0;
                for (int coluna = 0; coluna < cidades.Length; coluna++)
                {
                    soma += valores[linha][coluna];
                }
                Console.WriteLine(soma.ToString("N2"));
            }
        }
    }
}