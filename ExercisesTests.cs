using Xunit;
using System.Collections.Generic;
using System.Linq;

namespace Autotests
{
    public class ExercisesTests
    {
        [Fact]
        public void should_return_an_array_from_1_to_10()
        {
            // BDD - Behavior Driven Design
            // Dado, Quando, Deve

            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1,
            // então a aplicação deverá retornar todos os número de 1 a 10

            // Dado / Setup
            var exercises = new Exercises();

            // Quando / Ação
            var result = exercises.Exercise1A();

            // Deve / Asserções
            var expectedOutput = new int[10]
            {
                1,2,3,4,5,6,7,8,9,10
            };

            for (int i = 0; i < expectedOutput.Length; i++)
            {
                Assert.Equal(expectedOutput[i], result[i]);
            }
        }

        [Fact]
        public void should_return_an_array_from_10_to_1()
        {
            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1b,
            // então a aplicação deverá retornar todos os números de 1 a 10 de forma decrescente

            // Dado / Setup
            var exercises = new Exercises();

            // Quando / Ação
            int[] returnedValues = exercises.Exercise1B();

            // Deve / Asserções
            var expectedOutput = new int[10]
            {
                10,9,8,7,6,5,4,3,2,1
            };

            for (int i = 0; i < expectedOutput.Length; i++)
            {
                Assert.Equal(expectedOutput[i], returnedValues[i]);
            }
        }
        
        [Fact]
        public void should_return_an_array_from_1_to_10_but_only_even()
        {
            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1c,
            // então a aplicação deverá retornar os números de 1 a 10, mas somente os pares

            // Dado / Setup
            var exercises = new Exercises();

            // Quando / Ação
            int[] returnedValues = exercises.Exercise1C();

            // Deve / Asserções
            var expectedOutput = new int[5]
            {
                2,4,6,8,10
            };

            Assert.Equal(5, returnedValues.Length);

            for (int i = 0; i < expectedOutput.Length; i++)
            {
                Assert.Equal(expectedOutput[i], returnedValues[i]);
            }
        }
        
        [Fact]
        public void should_return_a_sum_of_an_int_from_1_to_100_()
        {
         // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 2,
         // então a aplicação deverá retornar a soma dos números inteiros de 1 à 100.


            // Dado / Setup
            var exercises = new Exercises();

            // Quando / Ação
            int returnedValue = exercises.Exercise2();

            // Deve / Asserções
            var expectedOutput =  5050;

            Assert.Equal(expectedOutput, returnedValue);
        }
        [Fact]
        public void should_return_a_collection_with_all_odds_betwen_1_and_200_()
        {
         // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 3,
         // então a aplicação deverá imprimir todos numeros ímpares menores que 200.


            // Dado / Setup
            var exercises = new Exercises();

            // Quando / Ação
            int[] returnedValue = exercises.Exercise3();

            // Deve / Asserções
            var expectedOutput =  new int[100] {
                1,3,5,7,9,11,13,15,17,19,21,23,25,27,29,31,33,35,37,39,41,43,45,47,49,51,53,55,57,
                59,61,63,65,67,69,71,73,75,77,79,81,83,85,87,89,91,93,95,97,99,101,103,105,107,109,
                111,113,115,117,119,121,123,125,127,129,131,133,135,137,139,141,143,145,147,149,151,153,155,
                157,159,161,163,165,167,169,171,173,175,177,179,181,183,185,187,189,191,193,195,197,199
                };

            Assert.Equal(expectedOutput, returnedValue);
        }

        [Theory]
        [InlineData(new int[2]{18,22}, 20)]
        [InlineData(new int[5]{18,22,33,36,41},30)]
        public void should_return_average_of_the_parameters(int[] users, double expected)
        {
         // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 4,
         // então a aplicação deverá retornar a méida de idade dos alunos na sala.
            var exercises = new Exercises();
            // Quando / Ação
            var returnedValue = exercises.Exercise4(users.ToList());

            // Deve / Asserções

            Assert.Equal(expected, returnedValue);
        }

        [Fact]
        public void should_return_40_when_passed_14_18_33_36_41()
        {
         // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 5,
         // então a aplicação deverá retornar a porcentagem dos números entre 18 e 35.


            // Dado / Setup
            var users = new int[5]
            {
                14,18,33,36,41
            };
            var exercises = new Exercises();

            // Quando / Ação
            double returnedValue = exercises.Exercise5(users);

            // Deve / Asserções
            var expectedOutput =  40;

            Assert.Equal(expectedOutput, returnedValue);
        }

        [Fact]
        public void should_return_0_when_passed_0()
        {
         // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 5,
         // então a aplicação deverá retornar a porcentagem dos números entre 18 e 35.


            // Dado / Setup
            var users = new int[5];
            var exercises = new Exercises();

            // Quando / Ação
            double returnedValue = exercises.Exercise5(users);

            // Deve / Asserções
            var expectedOutput =  0;

            Assert.Equal(expectedOutput, returnedValue);
        }
        [Fact]
        public void should_return_nelson_when_passed_candidates_nelson_3_luana_1()
        {
         // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 6,
         // então a aplicação deverá retornar o candidato com mais votos .


            // Dado / Setup
            var candidates = new (string name, int votes)[2]
            {
                ("nelson", 3),("luana",1)
            };
            var exercises = new Exercises();

            // Quando / Ação
            var returnedValue = exercises.Exercise6(candidates);

            // Deve / Asserções
            var expectedOutput =  "nelson";

            Assert.Equal(expectedOutput, returnedValue);
        }
        [Fact]
        public void should_return_segundo_turno_when_passed_candidates_lilia_5_martha_5()
        {
         // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 6,
         // então a aplicação deverá retornar o candidato com mais votos em caso de empate :"segundo turno" .

            // Dado / Setup
            var candidates = new (string name, int votes)[2]
            {
                ("lilia", 4),("martha",4)
            };
            var exercises = new Exercises();

            // Quando / Ação
            var returnedValue = exercises.Exercise6(candidates);

            // Deve / Asserções
            var expectedOutput =  "segundo turno";

            Assert.Equal(expectedOutput, returnedValue);
        }
        [Fact]
        public void should_return_6022_5_when_passed_6_and_10_and_5_5()
        {
         // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 7,
         // então a aplicação deverá retornar o restultado do gasto com cigarros durante o tempo de uso.


            // Dado / Setup
            var usingYears = 6.0;
            var cigarretesPerday = 10.0;
            var CPackPrice = 5.5;
            var exercises = new Exercises();

            // Quando / Ação
            double returnedValue = exercises.Exercise7( cigarretesPerday, usingYears, CPackPrice);

            // Deve / Asserções
            var expectedOutput =  6022.5;

            Assert.Equal(expectedOutput, returnedValue);
        }
        [Fact]
        public void should_return_0_when_passed_0_and_6_and_3()
        {
         // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 7,
         // então a aplicação deverá retornar o restultado do gasto com cigarros durante o tempo de uso.


            // Dado / Setup
            var usingYears = 0.0;
            var cigarretesPerday = 6.0;
            var CPackPrice = 3.0;
            var exercises = new Exercises();

            // Quando / Ação
            double returnedValue = exercises.Exercise7( cigarretesPerday, usingYears, CPackPrice);

            // Deve / Asserções
            var expectedOutput =  0;

            Assert.Equal(expectedOutput, returnedValue);
        }
        [Fact]
        public void should_return_135_and_166_when_passed_3_33_66_99_100()
        {
         // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 12,
         // então a aplicação deverá retornar a soma dos numeros impares e a soma dos que forem pares.

            // Dado / Setup
            var users = new List<double>()
            {
                3,33,66,99,100
            };
            var exercises = new Exercises();

            // Quando / Ação
            var returnedValue = exercises.Exercise12(users);

            // Deve / Asserções
             var expectedOutput = (135,166);

            Assert.Equal(expectedOutput, returnedValue);
        }
        [Fact]
        public void should_return_31_and_80_when_passed_24_56_0_31()
        {
         // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 12,
         // então a aplicação deverá retornar a soma dos numeros impares e a soma dos que forem pares.

            // Dado / Setup
            var users = new List<double>()
            {
                24,56,0,31
            };
            var exercises = new Exercises();

            // Quando / Ação
            var returnedValue = exercises.Exercise12(users);

            // Deve / Asserções
             var expectedOutput = (31,80);

            Assert.Equal(expectedOutput, returnedValue);
        }

        [Theory]
        [InlineData(new double[6]{20,1,4,23,30,15},30)]
        [InlineData(new double[5]{3,33,66,99,100},100)]
        
        public void should_return_the_max_number_when_passed_a_collection(double[] elements, int expected)
        {
         // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 13,
         // então a aplicação deverá retornar a o maior valore da lista.

            // Dado / Setup
            
            // list.Add(elements[elements.Length]);

            var exercises = new Exercises();

            // Quando / Ação
            var returnedValue = exercises.Exercise13(elements.ToList());

            // Deve / Asserções

            Assert.Equal(expected, returnedValue);
        }
        [Theory]
        [InlineData(new double[8]{2,5,8,1,4,6,3,7}, new double[8]{1,2,3,4,5,6,7,8})]
        [InlineData(new double[4]{3,7,2,4}, new double[4]{2,3,4,7})]
        public void should_return_ordered_when_passed_disordered(double[] users, double[] expected)
        {
         // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 14,
         // então a aplicação deverá retornar a os valores do array em ordem crescente.

            // Dado / Setup
            var exercises = new Exercises();

            // Quando / Ação
            var returnedValue = exercises.Exercise14(users.ToList());

            // Deve / Asserções

            Assert.Equal(expected, returnedValue);
        }
        [Theory]
        [InlineData(new double[10]{1,2,3,4,5,6,7,8,9,10},3,2)]
        public void should_return_how_much_numbers_are_multiple_of_3_and_5(double[] conjunto, int expectedA, int expectedB)
        {
            // Imprimir quantos números de um conjunto com 10 são multiplos de 3 quantos de 5.
            // DADO que a aplicação esteja pronta, QUANDO o usuário informar um número
            // DEVE retornar quantos são multiplos de 3 quantos de 5.

             // Dado / Setup
            var exercises = new Exercises();
            
            // Quando / Ação
            var result = exercises.Exercise15(conjunto);


            // Deve / Asserções
            (int a, int b) expected = (expectedA, expectedB);
            Assert.Equal(result, expected);
        }
        [Theory]
        [InlineData(600.00,600)]
        [InlineData(1000,800)]
        [InlineData(1500.00,1125)]
        [InlineData(2500,1750)]
        public void should_return_salarioLiquid_when_passed_salario_(double salario, double expected)
        {
            // Imprimir o Salário Líquido de acordo com aredução do imposto.
            // DADO que a aplicação esteja pronta, QUANDO o usuário informar um número
            // DEVE retornar a tabuada de 1 a 10

             // Dado / Setup
            var exercises = new Exercises();
            
            // Quando / Ação
            var result = exercises.Exercise16(salario);


            // Deve / Asserções
            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData(6, new int[10]{6, 12, 18, 24, 30, 36, 42, 48, 54, 60})]
        [InlineData(5, new int[10]{5, 10, 15, 20, 25, 30, 35, 40, 45, 50})]
        public void should_return_the_input_multiplied_by_1_to_10(int number, int[] expectedResult)
        {
            // Imprimir a tabuada de qualquer número fornecido pelo usuário.
            // DADO que a aplicação esteja pronta, QUANDO o usuário informar um número
            // DEVE retornar a tabuada de 1 a 10

            // Dado / Setup
            var exercises = new Exercises();
            
            // Quando / Ação
            var result = exercises.Exercise17(number);


            // Deve / Asserções
            Assert.Equal(result, expectedResult);
        }
        [Theory]
        [InlineData(8,10.4)]
        [InlineData(15,15)]
        [InlineData(-15,0)]
        [InlineData(0,0)]
        public void should_return_totalPrice_when_passed_quantity(double quantity, double expected)
        {
            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 18,
            // então a aplicação deverá retornar o preço total da compra (Q*1,30 if Q>12{ Q*1,00}).
            
            // Dado / Setup
            var exercises = new Exercises();
            
            // Quando / Ação
            var result = exercises.Exercise18(quantity);


            // Deve / Asserções
            Assert.Equal(result, expected);
        }
    }
}