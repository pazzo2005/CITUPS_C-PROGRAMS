using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace citUps
{
   class check
    {
        public class checkup
        {
            string name;
            int age;
            public checkup(string name,int age)
            {
                this.name = name;
                this.age = age;

            }
            public void che()
            {
                Console.WriteLine(name + "" + age);
            }
        }
        

    }
    class EEE<T>
    {
        public T value;
        
        public EEE(T value)
        {
            this.value = value;
        }
        public void Printing(T value)
        {
            Console.WriteLine(value);
        }
    }


    //Record Class

    public  record class Patient(string name,int age)
    {
        public void display()
        {
            Console.WriteLine(this.name + " " + this.age);
        }
        
    }
    class Recordclass
    {
        public static void Main()
        {
            Patient p1 = new Patient("ADITYA", 21)
            {
                name = "Sam"
            };
            p1.display();
            List<int> list = new List<int> { 
            12,34,12,43,23
            };

            foreach(int i in list)
            {
                Console.WriteLine(i);

            }
            Dictionary<int, string> dt = new Dictionary<int, string>
            {
                {1,"Ponambalam" },
                {2,"palam" }
            };
            foreach(var en in dt)
            {
                Console.WriteLine(en);
            }
        }
    }
   
    
}
