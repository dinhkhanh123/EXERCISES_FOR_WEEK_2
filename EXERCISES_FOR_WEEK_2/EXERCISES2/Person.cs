using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCISES2
{
    internal class Person
    {
       private int age;
       private string name;
       public Person() { }
        public Person(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        public int Age { 
            get 
            {
                return age; 
            } 
            set 
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                    throw new Exception("Invalid Age");
            } 
        }
        public string Name { get { return name; } set { name = value; } }
        public void Input()
        {
            Console.Write("Input name student: ");
            name = Console.ReadLine();

            Console.Write("Input age student: ");
            age = int.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            return "Name: " + name + "\n Age: " + age;
        }
        public void DisplayPerson()
        {
            Console.WriteLine(ToString());
        }
    }
}
