using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQEgDay3
{
   /* Query syntax
    * from <range variable> in enumerable <T> or iquerable <T> Collection
    * standard query operators
    * select or group by operator <result formation>
    
    */

    class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        internal Student(int Rollno, string Name, string City, string Gender, int Age)
        {
            this.RollNo = Rollno;
            this.Name = Name;
            this.City = City;
            this.Gender = Gender;
            this.Age = Age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] book = { "English", "Hindi", "Maths", "Science" };
            //LINQ Query syntax
            var result = from b in book  //b = range variable
                         select b;
        foreach(var bname in result)
            {
                Console.WriteLine(bname);
            }
            Console.WriteLine("-------");
            Console.WriteLine("Display the bookname containing 'a'");
            // display the book name containing a

            var r = from bookname in book
                    where bookname.Contains('a')
                    select bookname;

            //Method Syntax

            var m1 = book.Where(s => s.Contains('a'));


            foreach (var bname in r)
            {
                Console.WriteLine(bname);
            }
            int[] Marks = { 90, 98, 70, 82, 45 };

            Console.WriteLine("Minimum marks: {0}", Marks.Min());
            // Method Syntax
            var minmarks = Marks.Min(mark => Marks.Min());



            Console.WriteLine("Maximum marks: {0}", Marks.Max());

            // marks btw 70 and 100

            var r1 = from m in Marks
                     where m > 70 && m <= 100
                     select m; 

            // method syntax

            var m2 = Marks.Where(mark => mark > 70 && mark <= 100);

            foreach (var m in Marks)
            {
                Console.WriteLine(Marks);
            }

           
            //count
            var r2 = (from m in Marks
                      where m > 70 && m <= 100
                      select m).Count();
            Console.WriteLine("No. of marks between 70 and 100:{0}",r2);


            List<Student> stu = new List<Student>()
            {
                new Student(1001,"Avi","Bangalore","female",20),
                 new Student(1002,"Ramesh","Pune","male",23),
                  new Student(1003,"Mohit","Kolkata","male",25),
                   new Student(1004,"Radha","Delhi","female",22),
            };

            //Method Syntax
            // Display max age of student
           
            var student = stu.Max(stud => stud.Age);

            

            //Display name and city where city is Delhi
            //Deffered execution
            var stucity = from s in stu
                          where s.City.Equals("Delhi")
                          select new { s.Name, s.City };
            Console.WriteLine("-----------");
            Console.WriteLine("Display name and city where city is Delhi");
            foreach(var st in stucity)
            {
                Console.WriteLine(st.Name+" "+ st.City);
            }
            //Immediate execution

            var stucity1 = (from s in stu
                          where s.City.Equals("Pune")
                          select new { s.Name, s.City }).ToList();
            Console.WriteLine("------");
            Console.WriteLine("Display name and city where city is Pune");
            foreach (var st in stucity1)
            {
                Console.WriteLine(st.Name + " " + st.City);
            } 
                // Display the name and age of student

                var m3 = stu.Select(s => new { stuname = s.Name, stuAge = s.Age });
           
            foreach(var Mstu in m3)
            {
                Console.WriteLine(Mstu.stuname + " " + Mstu.stuAge);
            }
            // orderby
            // order by student gender
            var stugender = from s in stu
                          orderby s.Gender,s.Name
                          select s;
            Console.WriteLine("-----------");
            Console.WriteLine("order info based on gender");
            foreach (var st in stugender)
            {
                Console.WriteLine(st.Name + " " + st.City + " " +st.Gender);
            }

            //group by
            //NO of males and females

            Console.WriteLine("No. of males and females");
            var stumf = from s in stu
                        group s by s.Gender;

            foreach(var s in stumf)
            {
                Console.WriteLine(s.Key + " " + s.Count());
            }
                        
        }
    }
}
