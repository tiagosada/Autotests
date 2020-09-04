using Xunit;
using System.Collections.Generic;

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
        public void should_return_30_when_passed_18_22_33_36_41()
        {
         // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 4,
         // então a aplicação deverá retornar a méida de idade dos alunos na sala.


            // Dado / Setup
            var users = new List<int>()
            {
                18,22,33,36,41
            };
            var exercises = new Exercises();

            // Quando / Ação
            double returnedValue = exercises.Exercise4(users);

            // Deve / Asserções
            var expectedOutput =  30;

            Assert.Equal(expectedOutput, returnedValue);
        }
         [Fact]
        public void should_return_20_when_passed_18_22()
        {
         // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 4,
         // então a aplicação deverá retornar a méida de idade dos alunos na sala.


            // Dado / Setup
            var users = new List<int>()
            {
                18,22
            };
            var exercises = new Exercises();

            // Quando / Ação
            double returnedValue = exercises.Exercise4(users);

            // Deve / Asserções
            var expectedOutput =  20;

            Assert.Equal(expectedOutput, returnedValue);
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
        [Fact]
        public void should_return_100_when_passed_3_33_66_99_100()
        {
         // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 13,
         // então a aplicação deverá retornar a o maior valore da lista.

            // Dado / Setup
            var users = new List<double>()
            {
                3,33,66,99,100
            };
            var exercises = new Exercises();

            // Quando / Ação
            var returnedValue = exercises.Exercise13(users);

            // Deve / Asserções
             var expectedOutput = 100;

            Assert.Equal(expectedOutput, returnedValue);
        }
        [Fact]
        public void should_return_30_when_passed_20_1_4_23_30_15()
        {
         // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 13,
         // então a aplicação deverá retornar a o maior valore da lista.

            // Dado / Setup
            var users = new List<double>()
            {
                20,1,4,23,30,15
            };
            var exercises = new Exercises();

            // Quando / Ação
            var returnedValue = exercises.Exercise13(users);

            // Deve / Asserções
             var expectedOutput = 30;

            Assert.Equal(expectedOutput, returnedValue);
        }
        [Fact]
        public void should_return_ordered_when_passed_3_7_2_4()
        {
         // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 14,
         // então a aplicação deverá retornar a os valores do array em ordem crescente.

            // Dado / Setup
            var users = new List<int>()
            {
                3,7,2,4,
            };
            var exercises = new Exercises();

            // Quando / Ação
            List<int> returnedValue = exercises.Exercise14(users);

            // Deve / Asserções
             var expectedOutput = new List<int>()
            {
                2,3,4,7
            };

            Assert.Equal(expectedOutput, returnedValue);
        }
        [Fact]
        public void should_return_ordered_when_passed_2_5_8_1_4_6_3_7()
        {
         // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 14,
         // então a aplicação deverá retornar a os valores do array em ordem crescente.

            // Dado / Setup
            var users = new List<int>()
            {
                2,5,8,1,4,6,3,7
            };
            var exercises = new Exercises();

            // Quando / Ação
            List<int> returnedValue = exercises.Exercise14(users);

            // Deve / Asserções
             var expectedOutput = new List<int>()
            {
                1,2,3,4,5,6,7,8
            };

            Assert.Equal(expectedOutput, returnedValue);
        }

    }
}