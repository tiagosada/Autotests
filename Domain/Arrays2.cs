using System;
using System.Collections.Generic;

namespace Domain
{
    public class Arrays2
    {
        public int[] Exercise1(int[] arsA, int[] arsB, bool Pswrd)
        {
            //1)Popule dois vetores com 10 valores cada. Após esta operação, troque o conteúdo dos vetores.
            var tempA = new int[arsA.Length];
            var tempB = new int[arsB.Length];
            arsA.CopyTo(tempB, 0);
            arsB.CopyTo(tempA, 0);
            var Array = Pswrd ? tempA : tempB;
            return Array;
        }
        // static void Exercise2()
        // //2. Dado um vetor qualquer com 10 números,
        // // faça um programa que informa se há ou não números repetidos nesse vetor.
        // {
        //     var arsA = new int[10];
        //     var igual = false;
        //     System.Console.WriteLine("Criando um vetor A de 10 números:");
        //     for (int i = 0; i < arsA.Length; i++)
        //    {
        //         System.Console.WriteLine($"digite o um número:");
        //         while (true)
        //         {
        //             try
        //             {
        //                 arsA[i] = int.Parse(System.Console.ReadLine());
        //                 break;
        //             }
        //             catch (System.Exception)
        //             {
        //                 System.Console.WriteLine($"digite o um número válido.");
        //             }
        //         }
        //     }
        //     for (int x = 0; x < arsA.Length; x++)
        //     { 
        //         if(igual)
        //         {
        //             break;
        //         }
        //         for (int i = x + 1; i < arsA.Length; i++)
        //         {
        //             if(igual)
        //         {
        //             break;
        //         }
        //             igual = arsA[x]== arsA[i];
                    
        //         }
        //     }
        //     if(igual)
        //     {
        //         System.Console.WriteLine("Existem números repitidos nesse vetor.");
        //     }
        //     else
        //     {
        //         System.Console.WriteLine("Não ecistem números repitidos nesse vetor.");
        //     }
        // }
        // static void Exercise3()
        // //3. Um certa empresa fez uma pesquisa para saber 
        // //se as pessoas gostaram ou não de um novo produto lançado no mercado. Para isso,
        // //forneceu-se o sexo do entrevistado e a sua resposta
        // // (sim ou não. . Sabendo-se que foram entrevistadas 10 pessoas,
        // // fazer um algoritmo que calcule e escreva:
        // //• O número de pessoas que responderam sim;
        // //• O número de pessoas que responderam não;
        // //• A percentagem de pessoas do sexo feminino que responderam sim;
        // //• A percentagem de pessoas do sexo masculino que responderam não;
        // {
        //     // var female = 0; var yesF = 0; var noF = 0;
        //     // var male = 0; var yesM = 0; var noM = 0;
        //     // var answer = "";var yes = 0;var no = 0;
        //     (int N, int yes, int no) female = (0,0,0);
        //     (int N,int yes, int no) male = (0,0,0);
            
        //     for (int i = 0; i < 10; i++)
        //     {
        //         while (true)
        //         {
                    
        //             System.Console.WriteLine("Olá, qual seu gênero ?");
        //             var gender =System.Console.ReadLine();
        //             if (gender == "feminino")
        //             {
        //                 var answer = "";
        //                 female.N++;
        //                 while (true)
        //                 {
        //                     System.Console.WriteLine("você gostou do nosso mais recente produto?");
        //                     answer =System.Console.ReadLine();
        //                     if(answer == "sim" || answer == "Sim")
        //                     {
        //                         female.yes++;
        //                         break;
        //                     }
        //                     else if(answer == "não" || answer == "Não")
        //                     {
        //                         female.no++;
        //                         break;
        //                     }
        //                     else
        //                     {
        //                         System.Console.WriteLine("digite uma resposta válida (sim ou não).");
        //                     }
        //                 }
        //                 break;
                        
        //             }
        //             else if (gender == "masculino")
        //             {
        //                 var answer = "";
        //                 male.N++;
        //                 while (true)
        //                 {
        //                     System.Console.WriteLine("você gostou do nosso mais recente produto?");
        //                     answer =System.Console.ReadLine();
        //                     if(answer == "sim" || answer == "Sim")
        //                     {
        //                         male.yes++;
        //                         break;
        //                     }
        //                     else if(answer == "não" || answer == "Não")
        //                     {
        //                         male.no++;
        //                         break;
        //                     }
        //                     else
        //                     {
        //                         System.Console.WriteLine("digite uma resposta válida (sim ou não).");
        //                     }
        //                 }
        //                 break;
        //             }
        //             else
        //             {
        //                 System.Console.WriteLine("digite uma resposta válida (feminino ou masculino).");
        //             }   
        //         }
        //     }
        //         System.Console.WriteLine("Resultado da Pesquisa:");
        //         System.Console.WriteLine($"O número de pessoas que responderam sim: {female.yes+male.yes}");
        //         System.Console.WriteLine($"O número de pessoas que responderam não: {female.no+male.no}");
        //         System.Console.WriteLine($"A percentagem de pessoas do sexo feminino que responderam sim:{female.yes*100/female.N}%");
        //         System.Console.WriteLine($"A percentagem de pessoas do sexo masculino que responderam não:{male.no*100/male.N}%");
        // }
        // static void Exercise4()
        // //4. Desenvolver um programa que efetue a leitura de cinco elementos de uma matriz 
        // // A do tipo vetor.
        // // No final, apresente o total da soma de todos os elementos 
        // // que sejam impares.
        // {
        //     var arsA = new int[5];
        //     var sum = 0;
        //     System.Console.WriteLine("Criando um conjunto A de 10 valores:");
        //     for (int i = 0; i < arsA.Length; i++)
        //    {
        //         System.Console.WriteLine($"digite o um número:");
        //         while (true)
        //         {
        //             try
        //             {
        //                 arsA[i] = int.Parse(System.Console.ReadLine());
        //                 break;
                        
        //             }
        //             catch (System.Exception)
        //             {
        //                 System.Console.WriteLine($"digite o um número válido.");
        //             }
        //         }
        //     }
        //     for (int x = 0; x < arsA.Length ; x++)
        //     {
        //         sum += arsA[x]; 
        //     }
        //     System.Console.WriteLine($"Soma dos elementos:{sum}");
        // }
        // static void Exercise5()
        // //5. Contar quantos valores de um vetor de 10 posições são positivos.
        // {
        //     var arsA = new int[10];
        //     var sum = 0;
        //     System.Console.WriteLine("Criando um conjunto A de 10 valores:");
        //     for (int i = 0; i < arsA.Length; i++)
        //    {
        //         System.Console.WriteLine($"digite o um número:");
        //         while (true)
        //         {
        //             try
        //             {
        //                 arsA[i] = int.Parse(System.Console.ReadLine());
        //                 break;
        //             }
        //             catch (System.Exception)
        //             {
        //                 System.Console.WriteLine($"digite o um número válido.");
        //             }
        //         }
        //     }

        //     for (int x = 0; x < arsA.Length ; x++)
        //     {
        //         if(arsA[x]>0)
        //         {
        //           sum ++; 
        //         }
        //     }
        //     System.Console.WriteLine($"quantos elementos são positivos:{sum}");
        // }
        // static void Exercise6()
        // //6. Ler um vetor de 10 posições (aceitar somente números positivos.
        // //Escrever a seguir o valor do maior elemento de Q e a respectiva posição que ele ocupa no vetor.
        // {
        //     var arsA = new int[10];
        //     (int highest, int position) element = (0,0);
        //     System.Console.WriteLine("Criando um conjunto A de 10 valores:");
        //     for (int i = 0; i < arsA.Length; i++)
        //    {
        //         System.Console.WriteLine($"digite o um número:");
        //         while(true)
        //         {
        //             var input =System.Console.ReadLine();
        //             try
        //             {
        //                 arsA[i] =Int32.Parse(input);
        //             }
        //             catch (System.Exception)
        //             {

        //             }
        //             if(arsA[i]>0)
        //             {
        //                 System.Console.WriteLine("insira um valor positivo");
        //             }
        //             else
        //             {
        //                 break;
        //             }
        //         }
        //     }
        //     for (int x = 0; x < arsA.Length ; x++)
        //     {
        //         if(arsA[x]>element.highest)
        //         {
        //           element.highest = arsA[x];
        //           element.position = x+1;
        //         }
        //     }
        //     System.Console.WriteLine($"O maior elemento do conjunto é {element.highest} e a sua posição é {element.position}");
        // }
        // static void Exercise7()
        // //7. Crie e popule um vetor A e imprima na tela o número de vezes que existe 
        // //um número residindo na mesma posição do vetor que seu valor numérico.
        // {
        //     var arsA = new int[5];
        //     var times = 0;
        //     System.Console.WriteLine("Criando um conjunto A de 10 valores:");
        //     for (int i = 0; i < arsA.Length; i++)
        //    {
        //         System.Console.WriteLine($"digite o um número:");
        //         while (true)
        //         {
        //             try
        //             {
        //                   arsA[i] = int.Parse(System.Console.ReadLine());
        //                   break;
        //             }
        //             catch (System.Exception)
        //             {
        //                 System.Console.WriteLine($"digite o um número válido.");
        //             }
        //         }
        //         if(arsA[i]==i+1)
        //         {
        //             times++;
        //         }
        //     }
        //     System.Console.WriteLine($"existem {times} elementos na posição correspondente ao seu valor numérico.");
        // }
        // static void Exercise8()
        // //8. Crie um vetor de strings de 10 posições onde cada posição recebe uma letra do alfabeto.
        // // No final, imprima quantas destas são vogais.
        // {
        //     var arsA = new string[10];
        //     var vogais = 0;
        //     System.Console.WriteLine("Criando um conjunto 10 letras:");
        //     for (int i = 0; i < arsA.Length; i++)
        //    {
        //         System.Console.WriteLine($"digite o uma letra do alfabeto:");
        //         arsA[i] =(System.Console.ReadLine());
        //         if(arsA[i] == "a" || arsA[i]== "e" || arsA[i]== "i" || arsA[i]== "o" )
        //         {
        //             vogais++;
        //         }
        //     }
        //     System.Console.WriteLine($"existem {vogais} vogais no conjunto.");
        // }
        // static void Exercise9()
        // //9. Crie um vetor de strings de 10 posições onde cada posição recebe uma letra do alfabeto.
        // // No final, imprima a string resultante da soma das strings que residem em índices pares.
        // {
        // var arsB = new string[5];
        // var sum = "";
        // for (int j = 0; j < arsB.Length; j++)
        // {
        //     System.Console.WriteLine("digite o uma letra do alfabeto:");
        //     arsB[j] =System.Console.ReadLine();
        // }
        // for (int j = 0; j < arsB.Length; j+=2)
        //     {
        //         sum= sum + arsB[j];
        //         System.Console.WriteLine($"{sum}");
        //     }
        // }
    }
}