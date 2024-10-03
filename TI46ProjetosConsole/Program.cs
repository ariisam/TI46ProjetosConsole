using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TI46ProjetosConsole
{
    internal class Program
    {
        //private static string numerointeiro;
        //private static string numeroreal;
        //private static string caractere;

        static void Main(string[] args)
        {
            //Criando um manu com switch case

            Console.WriteLine("Escolha uma operação:");
            Console.WriteLine("1 - Programa média");
            Console.WriteLine("2 - Exercício 1 da lista");
            Console.WriteLine("3 - Exercício 2 da lista");
            Console.WriteLine("4 - Exercício 3 da lista");
            Console.WriteLine("5 - Exercício 4 da lista");
            Console.WriteLine("6 - Exercício 5 da lista");
            Console.WriteLine("7 - Exercício 6 da lista");
            Console.WriteLine("8 - primeiraQuestao");


            int escolha = Convert.ToInt32(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    exercicioMedia();
                    break;

                case 2:
                    exercicio1();
                    break;

                case 3:
                    exercicio2();
                    break;

                case 4:
                    exrcicio3();
                    break;

                case 5:
                    exercicio4();
                    break;

                case 6:
                    exercicio5();
                    break;

                case 7:
                    exercicio6();
                    break;
                    case 8:
                        primeiraQuestao();
                    break;

                default:
                    Console.WriteLine("Operação inválida.");
                    break;

            }
        }

       

        private static void exercicio6()
            {
                // Exercício 6: Conversão de Temperatura
                // Construa um algoritmo que converte temperatura de graus Celsius 
                // para Fahrenheit usando uma fórmula F = (C×95)+32.

                Console.WriteLine("Digite a temperatura em graus Celsius: ");
                double temperaturaCelsius = Convert.ToDouble(Console.ReadLine());

                double temperaturaFahrenheit = (temperaturaCelsius * 9 / 5) + 32;

                Console.WriteLine("A temperaturaFahrenheit é: {temperaturaFahrenheit}");
            }

            private static void exercicio5()
            {
                // Exercício 5: Cálculo de Desconto
                // Crie uma variável para o preço de um produto e 
                // aplique um desconto de 10 %. Mostre o valor final.

                double precoOriginal = 100.0;

                double desconto = 0.10;
                double valorDesconto = precoOriginal * desconto;
                double precoFinal = precoOriginal - valorDesconto;

                Console.WriteLine("Preço original: R$ {precoOriginal}");
                Console.WriteLine("Desconto: R$ {valorDesconto}");
                Console.WriteLine("Preço final após desconto: R$ {precoFinal}");
            }

            private static void exercicio4()
            {
                // Exercício 4: Prioridade dos Operadores
                // Calcule uma expressão:2 + 3×42 / (1−5)2 + 3×42 / (1−5 )

                double resultado = 2 + (3 * 42) / Math.Pow((1 - 5), 2) + (3 * 42) / (1 - 5);

                Console.WriteLine("O resultado da expressão é: {resultado}");
            }

            private static void exrcicio3()
            {
                // Exercício 3: Operações Aritméticas
                // Calcular a média aritmética de três números inteiros

                int numero1, numero2, numero3;

                Console.Write("Digite o primeiro número: ");
                numero1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                numero2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o terceiro número: ");
                numero3 = Convert.ToInt32(Console.ReadLine());

                double media = (numero1 + numero2 + numero3) / 3.0;

                Console.WriteLine("A média aritmética dos números {numero1}, {numero2} e {numero3} é: {media}");
            }

            private static void exercicio2()
            {
                // Exercicio 2: Constantes e Operações
                // Crie uma constante para o valor de Pi (3.14159)
                // e use-a para calcular a área de um círculo com raio.

                const double Pi = 3.14159;

                Console.Write("Digite o raio do círculo: ");
                double raio = Convert.ToDouble(Console.ReadLine());

                double area = Pi * raio * raio;

                Console.WriteLine("A área do círculo com raio {raio} é: {area}");
            }

            private static void exercicio1()
            {
                // Exercício 1: Declaração de Variáveis
                // Declarar três variáveis de tipos diferentes
                // (inteiro, real e caractere) e atributos


                int numeroInteiro = int.Parse(Console.ReadLine());
                Console.WriteLine(numeroInteiro);


                double numeroReal = double.Parse(Console.ReadLine());
                Console.WriteLine(numeroReal);


                char caractere = char.Parse(Console.ReadLine());
                Console.WriteLine(caractere);
            }


            private static void exercicioMedia()
            {
                string nome;
                decimal nota1, nota2, nota3, nota4, res;

                Console.WriteLine("Digite seu nome: ");
                nome = Console.ReadLine();
                Console.WriteLine("Seja bem vindo" + nome);

                Console.WriteLine("Digite as notas do aluno" + nome);

                nota1 = decimal.Parse(Console.ReadLine());
                nota2 = decimal.Parse(Console.ReadLine());
                nota3 = decimal.Parse(Console.ReadLine());
                nota4 = decimal.Parse(Console.ReadLine());

                res = (nota1 + nota2 + nota3 + nota4) / 4;

                Console.WriteLine("O aluno teve média final: " + res);

            }

        private static void primeiraQuestao() 
        {
            //If Simples: Verificar se o número é positivo.

            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 0) 
            {
                Console.WriteLine("Número positivo: ");
            }
        }

        private static void segundaQuestao()
        {
         Console.WriteLine("");
        }

    }
    }
