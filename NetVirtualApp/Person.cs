using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetVirtualApp
{
    class Person
    {
        public int Id { get; set; } = 1;

        public string? Name { set; get; }
        virtual public int Age { set; get; }

        virtual public void Info()
        {
            Console.Write($"Name: {Name}, Age: {Age}");
        }
    }

    class Employee : Person
    {
        new public int Id { get; set; } = 10;

        public decimal Salary {  set; get; }

        int age;
        public override int Age 
        { 
            get => base.Age; 
            set 
            {
                if (value >= 16 && value < 65)
                    age = value;
                else
                    age = 0;
            }
        }

        override sealed public void Info()
        {
            base.Info();
            Console.Write($", Salary: {Salary}");
        }
    }

}
