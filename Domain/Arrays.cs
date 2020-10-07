using System;
using System.Linq;

namespace Domain
{
    public class Arrays
    {
        public double[] Exercise1(double[] arsA, double[] arsB)
        {
            //1. Leia dois arrays A e B com 15 elementos. 
            //Construir um array C, onde cada elemento de C é a subtração
            // do elemento correspondente de A com B.
            var arsC = new double[arsA.Length];

            for (int b = 0; b < arsC.Length; b++)
            {
                arsC[b] = arsA[b] - arsB[b];
            }

            return arsC;
        }
         public double[] Exercise2(double[] arsA)
        {
            //2. Ler um array com 10 inteiros e mostrar os números na ordem direta e inversa a que foram escritos.
            
            return (arsA.Reverse()).ToArray();
        }
        public bool Exercise3(double[] arsA, double val)
        {
            //3. Leia 10 elementos e armazene em um array A. Em seguida, solicite pelo teclado um número qualquer
            // e pesquise no array se o número existe. 
            // Caso, sexa verdade imprima a mensagem: “O número existe no array” ,
            // caso contrário “Número inexistente”.
            
            return Array.Exists(arsA , x => x == val);
        }
        public bool Exercise4(double[] arsA, double[] arsB)
        {
            //4. Leia dois arrays A e B com 10 elementos.
            //  Em seguida, compare os arrays e verifique se os mesmos são iguais ou diferentes.
            bool iguais = true;
            for (int i = 0; i < arsA.Length; i++)
            {
                if (arsA[i] != arsB[i] )
                {
                    iguais = false;
                    break;
                }
            }
           return iguais;
        }
        public (int OV, int Ab, int On) Exercise5(int[] arsA)
        //5. Leia um array A com 15 elementos,
        // e calcule a média aritmética dos mesmos, em seguida,
        // diga quantos dos elementos lidos estão abaixo, acima e na média.
        {
            (int Ov, int Ab, int On) average = (0,0,0);
           
            var media = arsA.Sum() / arsA.Length;
            
            for (int i = 0; i < arsA.Length; i++)
            {
                if(arsA[i] < media)
                {
                    average.Ab++;
                }
                else if(arsA[i] == media)
                {
                    average.On++;
                }
                else 
                {
                    average.Ov++;
                }
            }
           return average;
        }
        
        public int[] Exercise6(int[] arsA, int[] arsB)
        //6. Leia um array A com 4 elementos. Após sua leitura, colocar os seus elementos em ordem crescente.
        //Depois ler um array B também com doze elementos, colocar os elementos de B em ordem decrescente.
        //Construir um array C, onde cada elemento de C é a soma do elemento correspondente de A com b.
        //Colocar em ordem crescente a matriz C e apresentar os seus valores.
        {
            var arsC = new int[arsA.Length]; 
            // colocando matrix A em ordem crescente
            Array.Sort(arsA);
            // colocando matrix B em ordem decrescente
            Array.Sort(arsB).Reverse(arsB);
            for (int b = 0; b < arsB.Length; b++)
            {
                arsC[b] = arsA[b] + arsB[b];
            }
            // colocando matrix C em ordem crescente
           Array.Sort(arsC);
            return arsC;
        }

    }
}