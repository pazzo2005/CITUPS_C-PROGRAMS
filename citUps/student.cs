//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace citUps
//{
//    internal class student
//    {
//        private string name;
//        private int age;

//        public string Name
//        {
//            get { return this.name; }
//            set { this.name = value; }
//        }

//        public int Age
//        {
//            get { return this.age; }
//            set { this.age = value; }
//        }

//        public student(string name, int age)
//        {
//            this.name = name;
//            this.age = age;
//        }

//        public void Display()
//        {
//            Console.WriteLine($"{this.Name} - {this.Age}");
//        }

//        static void Main()
//        {
//            student s1 = new student("Aditya", 21);

//            s1.Display();

//            s1.Name = "Rahul";
//            s1.Age = 22;

//            s1.Display();
//        }
//    }
//}
