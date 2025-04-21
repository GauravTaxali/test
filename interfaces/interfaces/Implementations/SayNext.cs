using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using interfaces.Interfaces;

namespace interfaces.Implementations
{
    public class SayNext : NextLevel
    {
        public void PrintMessage(string message, int repeatCount)
        {
            for (int i = 0; i < repeatCount; i++)
            {
                Console.WriteLine(message);
            }
        }
        public int CalculateSum(int a, int b)
        {
            return a + b;
        }
        public string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public double CalculateArea(double length, double width = 10.0)
        {
            return length * width;
        }
        public List<int> GenerateFibonacci(int count)
        {
            List<int> fibonacciNumbers = new List<int> { 0, 1 };
            for (int i = 2; i < count; i++)
            {
                fibonacciNumbers.Add(fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2]);
            }
            return fibonacciNumbers;
        }
        public int SumAll(List<int> numbers)
        {
            return numbers.Sum();
        }
        public (int minValue, int maxValue) FindMinMax(List<int> numbers)
        {
            return (numbers.Min(), numbers.Max());
        }
    }
}
