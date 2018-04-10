using System;

namespace Lab09
{
    class MyMath
    {
        private double result;
        private double operand1;
        private double operand2;

        public void Multiply(double operand1, double operand2)
        {
            result = operand1 * operand2;
        }
        public void Divide(double operand1, double operand2)
        {
            result = operand1 / operand2;
        }
        public void Add(double operand1, double operand2)
        {
            result = operand1 + operand2;
        }
        public void Subtract(double operand1, double operand2)
        {
            result = operand1 - operand2;
        }
        public double GetResult()
        {
            return result;
        }
        static void Main(string[] args)
        {
            MyMath math = new MyMath();
            math.Multiply(2.0, 3.0);
            Console.WriteLine("The result of 2*3 is: {0}", math.GetResult());

            math.Add(2.0, 3.0);
            Console.WriteLine("The result of 2+3 is: {0}", math.GetResult());

            math.Divide(2.0, 3.0);
            Console.WriteLine("The result of 2/3 is: {0}", math.GetResult());

            math.Subtract(2.0, 3.0);
            Console.WriteLine("The result of 2-3 is: {0}", math.GetResult());

        }
    }

}