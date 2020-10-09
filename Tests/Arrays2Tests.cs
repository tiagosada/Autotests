using Xunit;
using Domain;

namespace Tests
{
        public class Arrays2Tests
    {
        [Theory]
        [InlineData(new int[3]{1,2,3},new int[3]{4,4,4}, true)]
        public void Exercise1(int[] arsA, int[] arsB, bool Pswrd)
        {
            // Dado que a aplicação está preparada. Quando o usuário chamar a Questão 1,
            // então a aplicação deverá retornar o valor ganho por dia.
            var question = new Arrays2();

            var result1 = question.Exercise1(arsA, arsB, Pswrd);
            
            Pswrd = false;
            
            var result2 = question.Exercise1(arsA, arsB, Pswrd);

            Assert.Equal(arsB, result1);
            Assert.Equal(arsA, result2);
        }
        
    }
}