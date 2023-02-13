using System;

namespace EXERCISES2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Tran Dinh Khanh _ 20IT271 _20MC";
            Person person = new Person();
            Student student = new Student();

            while (true)
            {
               student.Input();
              
               int m = 0;

                if (student.Age > 0)
                {
                    student.PrintStudent();
                    return;
                  
                }
                else
                {
                    Console.WriteLine("Tuoi khong hop le vui long nhap lai thong tin:");
                  
                }
                m++;
            }

          
        }
    }
}
