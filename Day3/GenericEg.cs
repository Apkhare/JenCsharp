using System;
using System.Collections.Generic;
using System.Text;

namespace Day3
{
    class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        
        internal Person(int id, string name, string city)
        {
            this.id = id;
            this.name = name;
            this.city = city;
        }
    }

    class GenericEg
    {
        static void ListEg()
        {                   // typesafe
            List<string> fruits = new List<string>();
            fruits.Add("Mango");
            fruits.Add("Apple");
            fruits.Add("Orange");

            fruits.Insert(1,"Pineapple");
            fruits.RemoveAt(3);
            //fruits.add(10); //Typesafe

            List<string> vegetables = new List<string>();
            vegetables.Add("Carrot");
            vegetables.Add("Capsicum");
            vegetables.Add("Potato");
            vegetables.AddRange(fruits); //adding one list into another list

            foreach (var list in fruits)
            {
                Console.WriteLine("Fruits{0}", list);
            }
            foreach (var list in vegetables)
            {
                Console.WriteLine("Vegetables {0}", list);
            }
        }
        // Key value pair
        static void DictionaryEg()
        {
            Dictionary<int, string> dt = new Dictionary<int, string>();
            dt.Add(1, "Java");
            dt.Add(2, "Network");
            dt.Add(3, "OS");
            foreach (KeyValuePair<int,string> kp in dt)
            {
                Console.WriteLine(kp.Key + " "+ kp.Value);
            }
        }
        
        static void StackEg()
            //Push, pop, peek , contains, clear
        {
            Stack<int> st = new Stack<int>();
            st.Push(40);
            st.Push(30);
            st.Push(50);
            st.Push(10);

            foreach(var stack in st)
            {
                Console.WriteLine(stack); //output 10,50,30,40
            }
            st.Pop();
            Console.WriteLine("After 1 pop");
            foreach (var stack in st)
            {
                Console.WriteLine("Peek:{0}", st.Peek());
            }
           
        }
        static void Sortedlisteg()
        {
            SortedList<string, string> sl = new SortedList<string, string>();
            sl.Add("hello", "world");
            sl.Add("Welcome", "Home");
          
            foreach(KeyValuePair<string, string> kvp in sl)
            {
                Console.WriteLine("{0},{1}", kvp.Key, kvp.Value);
            }
        }


        static void Main()
        {
            ListEg();
            List<Person> Person = new List<Person>();
            Person.Add(new Person(1, "SAI", "Pune"));
            Person.Add(new Person(2, "Ram", "Mumbai"));
            Person.Add(new Person(3, "Geeta", "Delhi"));
           
            foreach (Person p in Person)
            {
                Console.WriteLine("ID:{0} || name : {1} || city : {2}", p.id, p.name, p.city );
            }
            Console.WriteLine("------");
            DictionaryEg();
            Console.WriteLine("-------");
            StackEg();
            Console.WriteLine("-------");
            Sortedlisteg();
        }
    }
}
