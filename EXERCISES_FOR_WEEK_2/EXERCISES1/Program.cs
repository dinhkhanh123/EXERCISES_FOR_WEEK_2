using System;
using EXERCISES1;

namespace EXERCISES_FOR_WEEK_2
{
    internal class Program
    {
     
        static void Main(string[] args)
        {
           // Console.Title = "Tran Dinh Khanh_20IT271_20MC";
            int slides;
            Console.WriteLine("Nhap so mat cua xuc sac: ");
            slides = int.Parse(Console.ReadLine());

            Dice dice = new Dice(slides);

            Console.WriteLine("Tien hanh lac xuc sac: ");
            int result = dice.Roll();
            Console.WriteLine("Ket qua : " + result);
            Console.ReadLine();
            
        }
       
    }
}
