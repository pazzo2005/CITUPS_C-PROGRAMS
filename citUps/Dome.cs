using System;
using System.Collections.Generic;
using System.Text;
using citUps;

namespace citUps
{
     partial class Checking
    {
        int she;
        int all;
       

        //public void Sig()
        //{
        //    Console.WriteLine(this.name + " " + this.age);
        //}




        }

    }
    class Child : Checking

    {
       public Child(int she,int all,string name,int age) :base(name,age,she ,all)
    {   

    }
    public override void Demo()
    {
        Console.WriteLine("Child Demo");
        base.Demo();
        Console.WriteLine(34);
    }
    

    }

