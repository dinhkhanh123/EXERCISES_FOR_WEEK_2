using System;
using static System.Net.Mime.MediaTypeNames;

namespace EXERCISES4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tran Dinh Khanh _ 20IT271 _20MC";
            Fraction fraction = new Fraction(); 

            Console.WriteLine("Nhap tu so so cho phan so dau tien: ");
            int firstNumerator = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap mau so so cho phan so dau tien: ");
            int firstDenominator = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap mau so cho phan so thu hai: ");
            int secondDenominator = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap tu so so cho phan so thu hai: ");
            int secondNumerator = int.Parse(Console.ReadLine());
            Console.WriteLine("Ket qua:");
            fraction.InputFractions(firstNumerator, firstDenominator, secondNumerator, secondDenominator);
            Console.Write(" Ket qua nhap 2 phan so: {0} => ", fraction);
            fraction.DisplayAsDecimal();
            fraction.Add(firstNumerator, firstDenominator, secondNumerator, secondDenominator);
            Console.Write(" Ket qua cong 2 phan so: {0} => ", fraction);
            fraction.DisplayAsDecimal();
            fraction.Subtract(firstNumerator, firstDenominator, secondNumerator, secondDenominator);
            Console.Write(" Ket qua tru 2 phan so: {0} => ", fraction);
            fraction.DisplayAsDecimal();
            fraction.Multiply(firstNumerator, firstDenominator, secondNumerator, secondDenominator);
            Console.Write(" Ket qua nhan 2 phan so: {0} => ", fraction);
            fraction.DisplayAsDecimal();
            fraction.Divide(firstNumerator, firstDenominator, secondNumerator, secondDenominator);
            Console.Write(" Ket qua chia 2 phan so: {0} => ", fraction);
            fraction.DisplayAsDecimal();

        }
    }
}
