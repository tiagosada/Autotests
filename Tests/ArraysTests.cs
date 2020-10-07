using Xunit;
using Domain;

namespace Tests
{
    public class ArraysTests
    {
        [Theory]
        [InlineData(new double[3]{1,2,3}, new double[3]{1,2,3}, new double[3]{0,0,0})]
        [InlineData(new double[3]{3,2,1}, new double[3]{1,2,3}, new double[3]{2,0,-2})]
       public void Exercise1(double[] arsA, double[] arsB, double[] expected)
       {
            //1. Leia dois arrays A e B com 15 elementos. 
            //Construir um array C, onde cada elemento de C é a subtração
            // do elemento correspondente de A com B.

            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1,
            // então a aplicação deverá retornar um conjunto C com a soma dos outros dois conjuntos.

            // Dado / Setup
            var arrays = new Arrays();

            // Quando / Ação
            var result = arrays.Exercise1(arsA, arsB);

            // Deve / Asserções
            Assert.Equal(expected, result);

       }
        [Theory]
        [InlineData(new double[3]{1,2,3}, new double[3]{3,2,1})]
        [InlineData(new double[4]{0,1,2,3}, new double[4]{3,2,1,0})]
       public void Exercise2(double[] arsA, double[] expected)
       {
            //2. Ler um array com 10 inteiros e mostrar os números na ordem direta e inversa a que foram escritos.

            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 2,
            // então a aplicação deverá retornar um conjunto com a os mesmos elementos do conjunto inicial
            // porém em ordem inversa .

            // Dado / Setup
            var arrays = new Arrays();

            // Quando / Ação
            var result = arrays.Exercise2(arsA);

            // Deve / Asserções
            Assert.Equal(expected, result);

       }
        [Theory]
        [InlineData(new double[3]{1,2,3}, 2, true)]
        [InlineData(new double[4]{0,1,2,3}, 5, false)]
       public void Exercise3(double[] arsA, double val, bool expected)
       {
            //3. Leia 10 elementos e armazene em um array A. Em seguida, solicite pelo teclado um número qualquer
            // e pesquise no array se o número existe. 
            // Caso, sexa verdade imprima a mensagem: “O número existe no array” ,
            // caso contrário “Número inexistente”.

            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 3,
            // então a aplicação deverá retornar um bool ao procurar um valor no array.

            // Dado / Setup
            var arrays = new Arrays();

            // Quando / Ação
            var result = arrays.Exercise3(arsA, val);

            // Deve / Asserções
            Assert.Equal(expected, result);

       }
       [Theory]
        [InlineData(new double[3]{1,2,3}, new double[3]{1,2,3}, true)]
        [InlineData(new double[4]{0,1,2,3}, new double[4]{0,1,3,2}, false)]
       public void Exercise4(double[] arsA, double[] arsB, bool expected)
       {
            //4. Leia dois arrays A e B com 10 elementos.
            //Em seguida, compare os arrays e verifique se os mesmos são iguais ou diferentes.

            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 4,
            // então a aplicação deverá retornar um bool ao COMPARAR array A com array B.

            // Dado / Setup
            var arrays = new Arrays();

            // Quando / Ação
            var result = arrays.Exercise4(arsA, arsB);

            // Deve / Asserções
            Assert.Equal(expected, result);

       }
        [Theory]
        [InlineData(new int[3]{1,2,3}, 1,1,1)]
        [InlineData(new int[2]{8,6}, 1,1,0 )]
       public void Exercise5(int[] arsA, int expectedA,int expectedB,int expectedC)
       {
            //5. Leia um array A com 15 elementos,
            // e calcule a média aritmética dos mesmos, em seguida,
            // diga quantos dos elementos lidos estão abaixo, acima e na média.

            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 5,
            // então a aplicação deverá retornar uma tupla contendo elementos a baixo, acima e na média.

            // Dado / Setup
            var arrays = new Arrays();

            // Quando / Ação
            var result = arrays.Exercise5(arsA);
            (int Ov, int Ab, int On) expected =(expectedA, expectedB, expectedC);
            // Deve / Asserções
            Assert.Equal(expected, result);

       }
        [Theory]
        [InlineData(new int[3]{3,2,1}, new int[3]{4,5,6}, new int[3]{5,3,1})]
        [InlineData(new int[2]{8,6}, new int[2]{4,2}, new int[2]{2,4})]
       public void Exercise6(int[] arsA, int[] arsB, int[] expected)
       { 
               //6. Leia um array A com 4 elementos. Após sua leitura, colocar os seus elementos em ordem crescente.
               //Depois ler um array B também com doze elementos, colocar os elementos de B em ordem decrescente.
               //Construir um array C, onde cada elemento de C é a soma do elemento correspondente de A com b.
               //Colocar em ordem crescente a matriz C e apresentar os seus valores.

            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 5,
            // então a aplicação deverá retornar um array resultado da soma dos arrays anteriores em ordem opostas.

            // Dado / Setup
            var arrays = new Arrays();

            // Quando / Ação
            var result = arrays.Exercise6(arsA, arsB);
            // Deve / Asserções
            Assert.Equal(expected, result);

       }
 
   }
}