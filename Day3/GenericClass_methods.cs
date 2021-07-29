using System;
using System.Collections.Generic;
using System.Text;

namespace Day3
{
   class Sample<T>
    {
        T Name;
        T City;

        internal Sample(T Name, T City)
        {
            this.Name = Name;
            this.City = City;
        }
        
        //normal method= taking only integers
        internal void Add(int x, int y)
        {
            Console.WriteLine("Addition is :{0},(x+y)");
        }
        // <T>

        internal void Swap<T> (T x, T y)
        {
            T temp;
            temp = x;
            x = y;
            y = temp;
            Console.WriteLine("X is {0} || Y is {1}", x, y);
        }
    }
    /* GENERIC CONSTRAINT
     * where T:Struct //value type
     * where T:Class // reference type
     * where T: new //default parameter constraint
     * where T:<interface name>
     */
    class Student<S> where S : struct
    {
        
    }
     class SEG<T> where T: class
    {
    }

    class GenericClass_methods
    {
        static void Main()
        {
            Sample<string> sample = new Sample<string>("ana","Mumbai");
            sample.Swap<int>(6, 7);
            sample.Swap<string>("Morning","Good" );

            //struct constraint
            //error because student class will only accept value type
            //Student<string> student = new Student<string>();

            Student<int>student  = new Student<int>();

        }
    }
}
