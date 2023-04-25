/* Programa para calcular qual combustível está mais vantajoso no momento
Autor: Victor Freire de Carvalho
Versão: 1.0
Produção Textual Individual para a disciplina de Algoritmos e Programação 1 do curso de
Tecnologia em Análise e Desenvolvimento de Sistemas do Senac
1º Semestre - 2023 */

using System;

namespace CalculadoraCombustivel
{
    class CalculaCombustivel
    {
        static void Main(string[] args)
        {
            //Recursividade utilizada para reiniciar o programa, caso necessário
            Exec();
        }

        static void Exec()
        {
            //Método que faz a interface com o usuário e, se necessário, reinicia o programa
            
            Console.WriteLine("Calculadora de preferência de uso de combustível. \n");
            Console.WriteLine("Digite o preço do litro do etanol, separando as casas decimais por ponto: ");
            float etanol = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço do litro da gasolina, separando as casas decimais por ponto: ");
            float gasolina = float.Parse(Console.ReadLine());
            CalcComb(etanol, gasolina);
            Console.WriteLine("Deseja calcular novamente? (s, n) ");
            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "s":
                    Exec();
                    break;
                case "n":
                    break;
            }
        }
        private static void CalcComb(float etanol, float gasolina)
        {
            //Método que efetua o cálculo de vantagem a respeito do uso de combustível
            
            float resultado = etanol/gasolina;
            if (resultado < 0.7)
            {
                Console.WriteLine("É mais vantajoso utilizar etanol. \n");
            }
            else if (resultado > 0.7)
            {
                Console.WriteLine("É mais vantajoso utilizar gasolina. \n");
            }
            else
            {
                Console.WriteLine("Pode utilizar qualquer combustível. \n");
            }
        }
    }
}
