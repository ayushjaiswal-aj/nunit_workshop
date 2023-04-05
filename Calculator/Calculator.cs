namespace CalculatorLibrary
{
    public class Calculator
    {

        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Sub(int num1, int num2)
        {
            return (num1 - num2);
        }

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Divide(int numerator, int denominator)
        {
            if(denominator == 0)
            {
                throw new DivideByZeroException();
            }
            return (numerator / denominator);
        }
    }
}