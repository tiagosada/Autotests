using System;
using System.Collections.Generic;

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
        public double Exercise13(List<double> users)
        {
            var higher = double.MinValue;
            foreach (var item in users)
            {
                if (item > higher)
                {
                    higher = item;
                }
            }
            return higher;
        }
        public List<int> Exercise14(List<int> users)
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
    }
}