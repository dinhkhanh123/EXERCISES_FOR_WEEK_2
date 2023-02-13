using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCISES4
{
     class Fraction
    {
        private int numerator;
        private int denominator;  
        public void InputFractions(int firstNumerator, int firstDenominator, int secondNumerator, int secondDenominator)
        {        
            numerator = firstNumerator * secondDenominator + secondNumerator * firstDenominator;
            denominator = firstDenominator * secondDenominator;
            Normalize();
        }
        public void Add(int firstNumerator, int firstDenominator, int secondNumerator, int secondDenominator)
        {
            numerator = firstNumerator * secondDenominator + secondNumerator * firstDenominator;
            denominator = firstDenominator * secondDenominator;
            Normalize();
        }
        public void Subtract(int firstNumerator, int firstDenominator, int secondNumerator, int secondDenominator)
        {
            numerator = firstNumerator * secondDenominator - secondNumerator * firstDenominator;
            denominator = firstDenominator * secondDenominator;
            Normalize();
        }
        public void Multiply(int firstNumerator, int firstDenominator, int secondNumerator, int secondDenominator)
        {
            numerator = firstNumerator * secondNumerator;
            denominator = firstDenominator * secondDenominator;
            Normalize();
        }
        public void Divide(int firstNumerator, int firstDenominator, int secondNumerator, int secondDenominator)
        {
            numerator = firstNumerator * secondDenominator;
            denominator = firstDenominator * secondNumerator;
            Normalize();
        }     
        private int GCD(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            return GCD(b, a % b);
        }
        public void Normalize()
        {
            int gcd = GCD(numerator, denominator);   
           numerator /= gcd;
            denominator /= gcd;

        }
        public override string ToString()
        {
            return "("+ numerator + "/" + denominator+ ")";
        }
        public void DisplayAsDecimal()
        {
            Console.WriteLine("{0:0.000}",(double)numerator / denominator);
        }   
    }
}
