using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces.Interfaces
{
    public interface NextLevel
    {
        void PrintMessage(string message, int repeatCount);
        int CalculateSum(int a, int b);
        string ReverseString(string input);
        double CalculateArea(double length, double width = 10.0);
        List<int> GenerateFibonacci(int count);
        int SumAll(List<int> numbers);
        (int minValue, int maxValue) FindMinMax(List<int> numbers);
    }
}
