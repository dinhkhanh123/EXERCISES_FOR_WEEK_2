using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCISES2
{
     class Student : Person 
    {
        private double gpa;

        public double Gpa 
        {
            get { return gpa; }
            set { gpa = value; }
        }

        public Student() 
        {

        }

        public Student(string name, int age,double gpa) : base(name,age)
        {
            this.gpa = gpa; 
        }

        public new void Input() 
        {
            base.Input();
            Console.Write("Nhap diem trung binh: ");
            gpa = double.Parse(Console.ReadLine());
        }

        public void PrintStudent()
        {
            DisplayPerson();
            Console.Write($"Gpa: {gpa}");
        }

    }
}
