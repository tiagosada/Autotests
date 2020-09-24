using System;
using System.Collections.Generic;
using System.Linq;

namespace Autotests
{
    class Exercises
    {
        public int[] Exercise1A()
        {
            var numbers = new int[10];

            for (int counter = 1; counter < 11; counter++)
            {
				numbers[counter - 1] = counter;
            }

            return numbers;
        }

        // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1b,
        // então a aplicação deverá retornar todos os números de 1 a 10 de forma decrescente
        public int[] Exercise1B()
        {
            int[] numbers = new int[10];
            
            for (int counter = 10; counter > 0; counter--)
            {
                numbers[numbers.Length - counter] = counter;
            }

            return numbers;
        }

        // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1c,
        // então a aplicação deverá retornar os números de 1 a 10, mas somente os pares
        public int[] Exercise1C()
        {
            var numbers = new int[5];

            for (int counter = 2; counter < 11; counter+=2)
            {
                var index = (counter / 2) - 1;
				numbers[index] = counter;
            }

            return numbers;
        }
        // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 2,
        // então a aplicação deverá retornar a soma dos números inteiros de 1 à 100.
        public int Exercise2()
        {
            var sum = 0;
            for (int counter = 1; counter <= 100; counter++)
            {
                sum += counter;
            }
            return sum;
        }
        // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 3,
        // então a aplicação deverá Imprimir todo os números ímpares menores de 200.
        public int[] Exercise3()
        {
            var x =0;
            var ars = new int[100];
            for(int i = 1; i < 200; i+=2)
            {
                
                ars[x] = i; 
                x++;
            }
            return ars;
        }
        // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 4,
        // então a aplicação deverá retornar a méida de idade dos alunos na sala.
        public double Exercise4( List<int> users)
        {
            var sum = 0.0 ;
            foreach (var item in users)
            {
                sum += item;
            }
            sum = sum/users.Count;
            return sum;
        }
        // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 5,
        // então a aplicação deverá retornar a porcentagem dos números entre 18 e 35.
        public double Exercise5( int[] users)
        {
            var percent = 0.0;
            for (int i = 0; i < 5; i++)
            {
               if (users[i] > 17 && users[i] < 36)
				{
					percent++;
				}
            }
            percent= (percent / 5)*100;
            return percent;
        }
        public string Exercise6( (string name, int votes)[] candidates)
        {
            if (candidates[0].votes == candidates[1].votes)
            {
                return "segundo turno";
            }
            else
            {
                var winner = (candidates[0].votes > candidates[1].votes) ? candidates[0] : candidates[1];
                return winner.name;
            }
        }
        public double Exercise7(double cigarretesPerday, double usingYears, double CPackPrice)
        {
            if (cigarretesPerday == 0 || usingYears == 0 || CPackPrice == 0)
            {
                return 0;
            }
            var result =cigarretesPerday*usingYears*365/20*CPackPrice;
            return result;
        }
        public bool Exercise8(int x, int y)
        {
            //8)Ler dois números inteiros, X e Y, e apresentar mensagem informando se o X é múltiplo de Y.
            var multiple = (x % y ==0);
            return multiple;
        }
        public bool Exercise9(int[] number)
		{
            //9)Fazer um algoritmo para ler 03 números reais do teclado e verificar se 
            //o primeiro é maior que a soma dos outros dois.
			
            bool higher = (number[0]>number[1]+number[2]);
            return higher;
		}
        public bool[] Exercise10(int[] number)
		{
            //10)Ler 02 números reais do teclado (A e B), verificar e imprimir qual deles é maior,
		    // ou a mensagem "A = B" caso sejam iguais
            var bools = new bool[3]{number[0] == number[1],number[0] > number[1],number[0] < number[1]};
            
            return bools;
		
        }
        public string Exercise11(double[] number)
		{
            //11)Ler 02 números inteiros do teclado. Se o segundo for diferente de zero, 
            //calcular e imprimir o quociente do primeiro pelo segundo.
            // Caso contrário, imprimir a mensagem: "DIVISÃO POR ZERO".
			var quociente = number[1] != 0 ? $"{number[0] / number[1]}" : "DIVISÃO POR ZERO";
			return quociente;
		}
        public (double,double) Exercise12(List<double> users)
        {
            (double odd, double even) sum = (0,0);
            foreach (var item in users)
            {
                if (item%2 == 0)
			    {
				    sum.even += item;
			    }
			    else if (item%2 != 0)
			    {
			    	sum.odd += item;
                }
            }
            return sum;
        }
        public double Exercise13(List<double> elements)
        {
            // var higher = double.MinValue;
            // foreach (var item in list)
            // {
            //     if (item > higher)
            //     {
            //         higher = item;
            //     }
            // }
            return elements.Max();
        }
        public List<double> Exercise14(List<double> users)
        {
            for (int i = 0; i < users.Count; i++)
            {
                for (int j = 0; j < users.Count-1; j++)
                {
                    if (users[j] > users[j+1])
                    {
                        var temp = users[j+1]; 
                        users[j+1] = users[j];
                        users[j] = temp;
                    }
                }
            }
            return users;
        }
        public (int a, int b) Exercise15(double[] conjunto)
        {
            var a = 0;
            var b = 0;
            foreach (var item in conjunto)
            {
                if (item % 3 == 0)
                {
                    a++;
                }
                else if (item % 5 == 0)
                {
                    b++;
                }
            }
            (int a, int b)quantity =(a,b);
            return quantity;
        }
        public double Exercise16(double salario)
        {
            if(salario<= 600.00)
			{
				return salario;
			}
			else if(salario<= 1200.00)
			{
				return salario * 0.8;
			}
			else if(salario<= 2000.00)
			{
				return salario * 0.75;
			}
			else
			{
				return salario * 0.7;
			} 
        }
         public IEnumerable<int> Exercise17(int number)
		{
            // Imprimir a tabuada de qualquer número fornecido pelo usuário.
            // DADO que a aplicação esteja pronta, QUANDO o usuário informar um número
            // DEVE retornar a tabuada de 1 a 10

            var multiplicationTable = new List<int>(){
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };

            // função que varre a coleção criando uma outra coleção com o valor retornado da multiplicação (neste caso).
            return multiplicationTable.Select(item => item * number);
		}
        public double Exercise18(double quantity)
        {
            if (quantity < 0)
            {
                return 0;
            }
            var totalPrive = quantity < 12 ? quantity*1.3 : quantity ;
            return totalPrive;
        }
    }
}