namespace Autotests
{
    class Calculator
    {
        public double Sum(double firstNumber, double secondNumber)
        {
            var result = firstNumber + secondNumber;

            return result;
        }

        public double Divide(double firstNumber, double secondNumber)
        {
            if (secondNumber == 0)
            {
                return 0.0;
            }
            var result = firstNumber / secondNumber;

            return result;
        }
    }
}