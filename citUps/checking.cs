using System;
using System.Collections.Generic;
using System.Text;

namespace citUps
{
     partial class Checking
    {
         private string name;
        private int age;
        public Checking(string name,int age,int she,int all)
        {
            this.name = name;
            this.age = age;
            this.she = she;
            this.all = all;


        }

        public virtual  void Demo()
        {
            Console.WriteLine(name +" " +age);
            Console.WriteLine(age);
            Console.WriteLine(she);
            Console.WriteLine(all);
        }
        

    }
    class Sames: Child
    {
        public Sames():base(43,23,"ADITYA",23)
        {

        }
        public override void Demo()
        {
            Console.WriteLine("Sames Demo");
            base.Demo();
        }
    }
}
