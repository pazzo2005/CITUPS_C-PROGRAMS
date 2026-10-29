//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Text;


///**   abstract class StaffTeaching
//   {
//       private string name;
//       public  StaffTeaching(string name)
//       {
//           this.name = name;
//       }
//       public abstract void Teach();

//       public void Display()
//       {
//           Console.WriteLine("Name of the teacher is " + this.name);
//       }

//   }
//   class MathTeacher : StaffTeaching
//   {
//       public MathTeacher(string name): base(name) { 
       
//       }
//       public override void Teach()
//       {
//           Console.WriteLine("The math teacher is teaching ");
//       }
//   }**/
///**abstract class Staff
//{
//      public abstract  void Work();

//}
//  abstract  class Coach : Staff
//{

//}
//class IT : Coach
//{
//    public override void Work()
//    {
//        Console.WriteLine("IT IS TEACHING");
//    }
//}
//class Mech : Coach
//{
//    public override void Work()
//    {
//        Console.WriteLine("Mech is doing the work");
//    }
//}**/
///**class Gram
//{
//    public  virtual void step()
//    {
//        Console.WriteLine("Yesss");
//    }
//}
//class Stamm : Gram
//{
//    public  override void step()
//    {
//        Console.WriteLine("yEAh");
//    }
//}
//**/

////First use case Interface
///** interface IResearcher

// {
//     void Research();
// }
// interface ITeacher
// {
//     void Teach();
// }
// class Professor : IResearcher, ITeacher
// {
//     public void Teach()
//     {
//         Console.WriteLine("Teacher is teaching the class");
//     }
//     public void Research()
//     {
//         Console.WriteLine("Rsearcg is going on");
//     }

// }

// //Second Use case for Interface
// interface IPayment
// {
//     void Pay(int amount);
// }
// class CreditCard:IPayment {
//     public void Pay(int amount)
//     {
//         Console.WriteLine("amout has been credited");
//     }
// }
// class Upi : IPayment
// {
//     public void Pay(int amount)
//     {
//         Console.WriteLine("Amount has been payed");
//     }
// }
// //Encaptuslation Code
 
// interface IAccount
// {
//     void CreateAccount();
//     void DeleteAccount();
//     void Balance();
//     void AddBalance();
//     void WithDraw(decimal amount);
// }
// class Account:IAccount
// {
//     private decimal balance;
//     public void CreateAccount()
//     {
//         Console.WriteLine("Account created ");

//     }
//     public void DeleteAccount()
//     {
//         Console.WriteLine("Account has been deleted");
//     }
//     public void Balance()
//     {
//         Console.WriteLine($"Balance amount {balance}");
//     }
//     public void AddBalance()

//     {
//         balance += 1000;
//         Console.WriteLine("Ad balance");
//     }
//     public void WithDraw(decimal amount)

//     {
//         if (balance < amount) Console.WriteLine("Amount is too low");
//         balance -= amount;

//         Console.WriteLine("Amount has been withdrawn");
//     }
// }

// class Bank : Account
// {
//     private readonly Account acc = new Account();
//     public decimal Amount { set; get; }
//     public Bank(decimal amount)
//     {
//         Amount = amount;
//     }
//     public void CreateAccount() => acc.CreateAccount();
//     public void DeleteAccount() => acc.DeleteAccount();
//     public void Balance() => acc.Balance();
//     public void AddBalance() => acc.AddBalance();
//     public void WithDraw(decimal Amount) => acc.WithDraw(Amount);
// } **/


////Encapsulation
///**
//class StudentManagement
//{
//    private class Student
//    {
//        public string name;
//        public int rollno;
//        public Student(string name,int rollno)
//        {
//            this.name = name;
//            this.rollno = rollno;
//        }
//    }
//    static List<Student> list = new List<Student>();
//    public void CreateStudent(string name,int rollno)
//    {
//        Student st = new Student(name, rollno);
//        list.Add(st);
//        Console.Write("Student has been created");

//    }
//    public void Display()
//    {
//        foreach(Student i in list)
//        {
//            Console.WriteLine(i);
//        }
//    }
//    public void DeleteStudent(string name)
//    {
//        Student st = list.Find(a => a.name == name);
//        list.Remove(st);
//    }
//}
////Abstraction

//interface IMarks
//{
//    void AddMarks();
//    void DeleteMarks();
//    void Show();

//}
//class MarksManagement :IMarks

//{
//    static int marks = 500;
    
//    public void AddMarks()
//    {
//        marks += 100;
//    }
//    public void DeleteMarks()
//    {
//        marks -= 100;
//    }
//    public void Show()
//    {
//        Console.WriteLine(marks);
//    }
//}
//class Access
//{
//    public void Test1()
//    {
//        Console.WriteLine("Hey this is public");
//    }
//    private void Test2()
//    {
//        Console.WriteLine("Hey this is private");
//    }
//    protected void Test3()
//    {
//        Console.WriteLine("hey this is protected");
//    }
//    internal void Test4()
//    {
//        Console.WriteLine("hey this internal method");
//    }
//    internal protected void Test5()
//    {
//        Console.WriteLine("Hey this internal protected");
//    }
   
//}
//class SecondClass : Access
//{
//    public void Test3() { Test3(); }

//}**/

//class MainClass : Charlie
//{
//    public static void Main()
//    {
//        MainClass s = new MainClass();
//        s.Test5();
//    }
//}




